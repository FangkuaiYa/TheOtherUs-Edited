using System;
using System.Collections.Generic;
using UnityEngine;

namespace TheOtherRoles.Roles;

public class RoleInfo
{
    private static readonly List<RoleInfo> _AllRoleInfo = [];

    public RoleInfo()
    {
        _AllRoleInfo.Add(this);
    }

    public static IReadOnlyList<RoleInfo> AllRoleInfo => _AllRoleInfo;

    public Color Color { get; set; }
    public string Name { get; set; }
    public RoleId RoleId { get; set; }
    public string DescriptionText { get; set; } = string.Empty;
    public string IntroInfo { get; set; } = string.Empty;
    public RoleTeam RoleTeam { get; set; }
    public string RoleClassName => RoleClassType.Name;

    public string introDescription => getString(Name + "IntroDesc");
    public string shortDescription => getString(Name + "ShortDesc");
    public string fullDescription => getString(Name + "FullDesc");

    public CustomRoleType RoleType { get; set; } = CustomRoleType.Main;
    public Func<RoleBase> GetRole { get; set; }

    public Func<PlayerControl, RoleControllerBase> CreateRoleController { get; set; }

    public Type RoleClassType { get; set; }
}

[Flags]
public enum CustomRoleType
{
    Main = 1,
    Modifier = 2,
    ModeRole = 5,
    MainAndModifier = Main | Modifier
}