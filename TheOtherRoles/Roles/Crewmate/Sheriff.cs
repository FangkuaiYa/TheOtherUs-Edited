﻿using System.Linq;
using UnityEngine;

namespace TheOtherRoles.Roles.Crewmate;

public static class Sheriff
{
    public static PlayerControl sheriff;
    public static Color color = new Color32(248, 205, 70, byte.MaxValue);

    public static float cooldown = 30f;
    public static bool canKillNeutrals;
    public static bool canKillLawyer;
    public static bool canKillSurvivor;
    public static bool canKillJester;
    public static bool canKillPursuer;
    public static bool canKillPartTimer;
    public static bool canKillVulture;
    public static bool canKillThief;
    public static bool canKillAmnesiac;
    public static bool canKillExecutioner;
    public static bool canKillDoomsayer;
    public static bool spyCanDieToSheriff;
    public static int misfireKills; // Self: 0, Target: 1, Both: 2

    public static PlayerControl currentTarget;

    public static PlayerControl formerDeputy; // Needed for keeping handcuffs + shifting
    public static PlayerControl formerSheriff; // When deputy gets promoted...

    public static void replaceCurrentSheriff(PlayerControl deputy)
    {
        if (!formerSheriff) formerSheriff = sheriff;
        sheriff = deputy;
        currentTarget = null;
        cooldown = CustomOptionHolder.sheriffCooldown.getFloat();
    }

    public static bool sheriffCanKillNeutral(PlayerControl target)
    {
        return (target != Mini.mini || Mini.isGrownUp()) &&
               (target.Data.Role.IsImpostor ||
                Jackal.jackal == target ||
                Sidekick.sidekick == target ||
                Juggernaut.juggernaut == target ||
                Werewolf.werewolf == target ||
                Swooper.swooper == target ||
                Pavlovsdogs.pavlovsowner == target ||
                Pavlovsdogs.pavlovsdogs.Any(p => p == target) ||
                (spyCanDieToSheriff && Spy.spy == target) ||
                (canKillNeutrals &&
                    (Akujo.akujo == target || isKiller(target) ||
                        (Survivor.survivor.Contains(target) && canKillSurvivor) ||
                        (Jester.jester == target && canKillJester) ||
                        (Vulture.vulture == target && canKillVulture) ||
                        (Thief.thief == target && canKillThief) ||
                        (Amnisiac.amnisiac == target && canKillAmnesiac) ||
                        (PartTimer.partTimer == target && canKillPartTimer) ||
                        (Lawyer.lawyer == target && canKillLawyer) ||
                        (Executioner.executioner == target && canKillExecutioner) ||
                        (Pursuer.pursuer.Contains(target) && canKillPursuer) ||
                        (Doomsayer.doomsayer == target && canKillDoomsayer))));
    }

    public static void clearAndReload()
    {
        sheriff = null;
        currentTarget = null;
        formerDeputy = null;
        formerSheriff = null;
        misfireKills = CustomOptionHolder.sheriffMisfireKills.getSelection();
        cooldown = CustomOptionHolder.sheriffCooldown.getFloat();
        canKillNeutrals = CustomOptionHolder.sheriffCanKillNeutrals.getBool();
        canKillSurvivor = CustomOptionHolder.sheriffCanKillSurvivor.getBool();
        canKillLawyer = CustomOptionHolder.sheriffCanKillLawyer.getBool();
        canKillJester = CustomOptionHolder.sheriffCanKillJester.getBool();
        canKillPursuer = CustomOptionHolder.sheriffCanKillPursuer.getBool();
        canKillPartTimer = CustomOptionHolder.sheriffCanKillPartTimer.getBool();
        canKillVulture = CustomOptionHolder.sheriffCanKillVulture.getBool();
        canKillThief = CustomOptionHolder.sheriffCanKillThief.getBool();
        canKillAmnesiac = CustomOptionHolder.sheriffCanKillAmnesiac.getBool();
        canKillExecutioner = CustomOptionHolder.sheriffCanKillExecutioner.getBool();
        spyCanDieToSheriff = CustomOptionHolder.spyCanDieToSheriff.getBool();
        canKillDoomsayer = CustomOptionHolder.sheriffCanKillDoomsayer.getBool();
    }
}
