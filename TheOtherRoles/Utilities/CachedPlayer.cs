using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TheOtherRoles.Modules.CustomHats;
using UnityEngine;

namespace TheOtherRoles.Utilities;

public sealed class CachedPlayer
{
    internal static readonly Dictionary<IntPtr, CachedPlayer> PlayerPtrs = new();
    public static readonly List<CachedPlayer> AllPlayers = [];
    internal static CachedPlayer LocalPlayer => PlayerControl.LocalPlayer;

    public Transform transform { get; init; }
    public PlayerControl PlayerControl { get; init; }
    public PlayerPhysics Physics { get; init; }
    public CustomNetworkTransform Transform { get; init; }

    public GameData.PlayerInfo PlayerInfo { get; set; }

    public CosmeticsLayer cosmeticsLayer { get; set; }

    public byte PlayerId { get; set; }


    public string PlayerName => PlayerInfo.PlayerName;

    public float PlayerSpeed => Physics.Speed;

    public float TrueSpeed => Physics.TrueSpeed;

    public float SpeedMod => Physics.SpeedMod;

    public float GhostSpeed => Physics.GhostSpeed;

    public Vector2 LastPosition => Transform.lastPosition;

    public Vector2 TruePosition => PlayerControl.GetTruePosition();

    public Vector2 ControlOffset => PlayerControl.Collider.offset;

    public bool Disconnected => PlayerInfo.Disconnected;
    public bool CanMove => PlayerControl.CanMove;
    public bool IsDead => PlayerControl.Data.IsDead;

    public bool IsDummy => PlayerControl.isDummy;

    public bool InVent => PlayerControl.inVent;

#nullable enable
    public CustomHat? _customHat { get; set; }
    //public CustomVisor? _CustomVisor { get; set; }
    //public CustomNamePlate? _customNamePlate { get; set; }
#nullable disable


    public void setDefaultLook(bool enforceNightVisionUpdate = true)
    {
        if (MushroomSabotageActive())
        {
            var instance = ShipStatus.Instance.CastFast<FungleShipStatus>().specialSabotage;
            var condensedOutfit = instance.currentMixups[PlayerControl.PlayerId];
            var playerOutfit = instance.ConvertToPlayerOutfit(condensedOutfit);
            PlayerControl.MixUpOutfit(playerOutfit);
        }
        else
        {
            setLook(PlayerControl.Data.PlayerName, PlayerControl.Data.DefaultOutfit.ColorId, PlayerControl.Data.DefaultOutfit.HatId,
                PlayerControl.Data.DefaultOutfit.VisorId, PlayerControl.Data.DefaultOutfit.SkinId, PlayerControl.Data.DefaultOutfit.PetId,
                enforceNightVisionUpdate);
        }
    }

    public void setLook(string playerName, int colorId, string hatId, string visorId,
        string skinId, string petId, bool enforceNightVisionUpdate = true)
    {
        PlayerControl.RawSetColor(colorId);
        PlayerControl.RawSetVisor(visorId, colorId);
        PlayerControl.RawSetHat(hatId, colorId);
        PlayerControl.RawSetName(hidePlayerName(LocalPlayer.PlayerControl, PlayerControl) ? "" : playerName);


        SkinViewData nextSkin;
        try
        {
            nextSkin = ShipStatus.Instance.CosmeticsCache.GetSkin(skinId);
        }
        catch
        {
            return;
        }

        var playerPhysics = PlayerControl.MyPhysics;
        AnimationClip clip;
        var spriteAnim = playerPhysics.myPlayer.cosmetics.skin.animator;
        var currentPhysicsAnim = playerPhysics.Animations.Animator.GetCurrentAnimation();


        if (currentPhysicsAnim == playerPhysics.Animations.group.RunAnim) clip = nextSkin.RunAnim;
        else if (currentPhysicsAnim == playerPhysics.Animations.group.SpawnAnim) clip = nextSkin.SpawnAnim;
        else if (currentPhysicsAnim == playerPhysics.Animations.group.EnterVentAnim) clip = nextSkin.EnterVentAnim;
        else if (currentPhysicsAnim == playerPhysics.Animations.group.ExitVentAnim) clip = nextSkin.ExitVentAnim;
        else if (currentPhysicsAnim == playerPhysics.Animations.group.IdleAnim) clip = nextSkin.IdleAnim;
        else clip = nextSkin.IdleAnim;
        var progress = playerPhysics.Animations.Animator.m_animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
        playerPhysics.myPlayer.cosmetics.skin.skin = nextSkin;
        playerPhysics.myPlayer.cosmetics.skin.UpdateMaterial();

        spriteAnim.Play(clip);
        spriteAnim.m_animator.Play("a", 0, progress % 1);
        spriteAnim.m_animator.Update(0f);

        PlayerControl.RawSetPet(petId, colorId);

        /*if (enforceNightVisionUpdate) SurveillanceMinigamePatch.enforceNightVision(target);
        Chameleon.update(); */
    }

    public CachedPlayer SetName(string name, Color color = default, float size = -1)
    {
        return this;
    }

    private bool Equals(CachedPlayer other)
    {
        return Equals(PlayerControl, other.PlayerControl) && PlayerId == other.PlayerId;
    }

    public override bool Equals(object obj)
    {
        return ReferenceEquals(this, obj) || (obj is CachedPlayer other && Equals(other));
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(PlayerControl);
    }

    public static implicit operator bool(CachedPlayer player)
    {
        return player != null && player.PlayerControl;
    }

    public static implicit operator byte(CachedPlayer player)
    {
        return player.PlayerId;
    }

    public static implicit operator PlayerControl(CachedPlayer player)
    {
        return player.PlayerControl;
    }

    public static implicit operator PlayerPhysics(CachedPlayer player)
    {
        return player.Physics;
    }

    public static implicit operator CachedPlayer(PlayerControl player)
    {
        return AllPlayers.FirstOrDefault(n => n.PlayerControl == player);
    }

    public static implicit operator CachedPlayer(PlayerPhysics player)
    {
        return AllPlayers.FirstOrDefault(n => n.Physics == player);
    }

    public static implicit operator CosmeticsLayer(CachedPlayer player)
    {
        return player.cosmeticsLayer;
    }

    public static bool operator ==(CachedPlayer cache, PlayerControl player)
    {
        return cache != null && player != null && cache.PlayerControl == player;
    }

    public static bool operator !=(CachedPlayer cache, PlayerControl player)
    {
        return cache == null || player == null || cache.PlayerControl != player;
    }

}

[HarmonyPatch]
public static class CachedPlayerPatches
{
    public static CachedPlayer GetCachePlayer(this byte id) => CachedPlayer.AllPlayers.FirstOrDefault(n => n.PlayerId == id);

    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.Awake))]
    [HarmonyPostfix]
    public static void CachePlayerPatch(PlayerControl __instance)
    {
        if (__instance.notRealPlayer) return;
        var player = new CachedPlayer
        {
            transform = __instance.transform,
            PlayerControl = __instance,
            Physics = __instance.MyPhysics,
            Transform = __instance.NetTransform,
            cosmeticsLayer = __instance.cosmetics,
            PlayerInfo = __instance.Data
        };
        CachedPlayer.AllPlayers.Add(player);
        CachedPlayer.PlayerPtrs[__instance.Pointer] = player;
    }

    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.OnDestroy))]
    [HarmonyPostfix]
    public static void RemoveCachedPlayerPatch(PlayerControl __instance)
    {
        if (__instance.notRealPlayer) return;
        CachedPlayer.AllPlayers.RemoveAll(p => p.PlayerControl.Pointer == __instance.Pointer);
        CachedPlayer.PlayerPtrs.Remove(__instance.Pointer);
    }



    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.Deserialize))]
    [HarmonyPostfix]
    public static void SetCachedPlayerId(PlayerControl __instance)
    {
        CachedPlayer.PlayerPtrs[__instance.Pointer].PlayerId = __instance.PlayerId;
    }
}

// GameStates Form TOH