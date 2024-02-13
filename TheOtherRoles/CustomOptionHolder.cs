using System.Collections.Generic;
using UnityEngine;
using static TheOtherRoles.Guesser;
using static TheOtherRoles.TheOtherRoles;
using Types = TheOtherRoles.CustomOption.CustomOptionType;

namespace TheOtherRoles {
    public class CustomOptionHolder {
        public static string[] rates = new string[]{"0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"};
        public static string[] ratesModifier = new string[]{"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
        public static string[] presets = new string[] { "Ԥ�� 1", "Ԥ�� 2", "���Ԥ�衪Skeld", "���Ԥ�衪Mira HQ", "���Ԥ�衪Polus", "���Ԥ�衪Airship", "���Ԥ�衪Submerged", "���Ԥ�衪Fungle" };

        public static CustomOption presetSelection;
        public static CustomOption activateRoles;
        public static CustomOption crewmateRolesCountMin;
        public static CustomOption crewmateRolesCountMax;
        public static CustomOption crewmateRolesFill;
        public static CustomOption neutralRolesCountMin;
        public static CustomOption neutralRolesCountMax;
        public static CustomOption impostorRolesCountMin;
        public static CustomOption impostorRolesCountMax;
        public static CustomOption modifiersCountMin;
        public static CustomOption modifiersCountMax;

        public static CustomOption enableCodenameHorsemode;
        public static CustomOption enableCodenameDisableHorses;

        public static CustomOption cultistSpawnRate;

        public static CustomOption minerSpawnRate;
		public static CustomOption minerCooldown;
        public static CustomOption mafiaSpawnRate;
        public static CustomOption janitorCooldown;

        public static CustomOption morphlingSpawnRate;
        public static CustomOption morphlingCooldown;
        public static CustomOption morphlingDuration;

        public static CustomOption bomber2SpawnRate;
        public static CustomOption bomber2BombCooldown;
        public static CustomOption bomber2Delay;
        public static CustomOption bomber2Timer;
        //public static CustomOption bomber2HotPotatoMode;

        public static CustomOption undertakerSpawnRate;
        public static CustomOption undertakerDragingDelaiAfterKill;
        public static CustomOption undertakerCanDragAndVent;

        public static CustomOption camouflagerSpawnRate;
        public static CustomOption camouflagerCooldown;
        public static CustomOption camouflagerDuration;

        public static CustomOption vampireSpawnRate;
        public static CustomOption vampireKillDelay;
        public static CustomOption vampireCooldown;
        public static CustomOption vampireGarlicButton;
        public static CustomOption vampireCanKillNearGarlics;

        public static CustomOption poucherSpawnRate;
        public static CustomOption mimicSpawnRate;

        public static CustomOption eraserSpawnRate;
        public static CustomOption eraserCooldown;
        public static CustomOption eraserCanEraseAnyone;
        
        public static CustomOption guesserSpawnRate;
        public static CustomOption guesserIsImpGuesserRate;
        public static CustomOption guesserNumberOfShots;
        public static CustomOption guesserHasMultipleShotsPerMeeting;
        public static CustomOption guesserShowInfoInGhostChat;
        public static CustomOption guesserKillsThroughShield;
        public static CustomOption guesserEvilCanKillSpy;
        public static CustomOption guesserEvilCanKillCrewmate;
        public static CustomOption guesserSpawnBothRate;
        public static CustomOption guesserCantGuessSnitchIfTaksDone;

        public static CustomOption jesterSpawnRate;
        public static CustomOption jesterCanCallEmergency;
        public static CustomOption jesterCanVent;
        public static CustomOption jesterHasImpostorVision;

        public static CustomOption amnisiacSpawnRate;
        public static CustomOption amnisiacShowArrows;
        public static CustomOption amnisiacResetRole;

        public static CustomOption arsonistSpawnRate;
        public static CustomOption arsonistCooldown;
        public static CustomOption arsonistDuration;

        public static CustomOption jackalSpawnRate;
        public static CustomOption jackalKillCooldown;
        public static CustomOption jackalChanceSwoop;
        public static CustomOption swooperCooldown;
        public static CustomOption swooperDuration;
        public static CustomOption jackalCreateSidekickCooldown;
        public static CustomOption jackalKillFakeImpostor;
        public static CustomOption jackalCanUseVents;
        public static CustomOption jackalCanUseSabo;
        public static CustomOption jackalCanCreateSidekick;
        public static CustomOption sidekickPromotesToJackal;
        public static CustomOption sidekickCanKill;
        public static CustomOption sidekickCanUseVents;
        public static CustomOption jackalPromotedFromSidekickCanCreateSidekick;
        public static CustomOption jackalCanCreateSidekickFromImpostor;
        public static CustomOption jackalAndSidekickHaveImpostorVision;

        public static CustomOption bountyHunterSpawnRate;
        public static CustomOption bountyHunterBountyDuration;
        public static CustomOption bountyHunterReducedCooldown;
        public static CustomOption bountyHunterPunishmentTime;
        public static CustomOption bountyHunterShowArrow;
        public static CustomOption bountyHunterArrowUpdateIntervall;

        public static CustomOption witchSpawnRate;
        public static CustomOption witchCooldown;
        public static CustomOption witchAdditionalCooldown;
        public static CustomOption witchCanSpellAnyone;
        public static CustomOption witchSpellCastingDuration;
        public static CustomOption witchTriggerBothCooldowns;
        public static CustomOption witchVoteSavesTargets;

        public static CustomOption ninjaSpawnRate;
        public static CustomOption ninjaCooldown;
        public static CustomOption ninjaKnowsTargetLocation;
        public static CustomOption ninjaTraceTime;
        public static CustomOption ninjaTraceColorTime;
        public static CustomOption ninjaInvisibleDuration;

        public static CustomOption blackmailerSpawnRate;
        public static CustomOption blackmailerCooldown;

        public static CustomOption mayorSpawnRate;
        public static CustomOption mayorCanSeeVoteColors;
        public static CustomOption mayorTasksNeededToSeeVoteColors;
        public static CustomOption mayorMeetingButton;
        public static CustomOption mayorMaxRemoteMeetings;
        public static CustomOption mayorChooseSingleVote;

        public static CustomOption portalmakerSpawnRate;
        public static CustomOption portalmakerCooldown;
        public static CustomOption portalmakerUsePortalCooldown;
        public static CustomOption portalmakerLogOnlyColorType;
        public static CustomOption portalmakerLogHasTime;
        public static CustomOption portalmakerCanPortalFromAnywhere;

        public static CustomOption engineerSpawnRate;
        public static CustomOption engineerRemoteFix;
        //public static CustomOption engineerExpertRepairs;
        public static CustomOption engineerResetFixAfterMeeting;
        public static CustomOption engineerNumberOfFixes;
        public static CustomOption engineerHighlightForImpostors;
        public static CustomOption engineerHighlightForTeamJackal;

        public static CustomOption privateInvestigatorSpawnRate;
        public static CustomOption privateInvestigatorSeeColor;

        public static CustomOption sheriffSpawnRate;
        public static CustomOption sheriffMisfireKills;
        public static CustomOption sheriffCooldown;
        public static CustomOption sheriffCanKillNeutrals;
        public static CustomOption sheriffCanKillArsonist;
        public static CustomOption sheriffCanKillLawyer;
        public static CustomOption sheriffCanKillProsecutor;
        public static CustomOption sheriffCanKillJester;
        public static CustomOption sheriffCanKillVulture;
        public static CustomOption sheriffCanKillThief;
        public static CustomOption sheriffCanKillAmnesiac;
        public static CustomOption sheriffCanKillPursuer;
        public static CustomOption sheriffCanKillDoomsayer;
        public static CustomOption deputySpawnRate;

        public static CustomOption deputyNumberOfHandcuffs;
        public static CustomOption deputyHandcuffCooldown;
        public static CustomOption deputyGetsPromoted;
        public static CustomOption deputyKeepsHandcuffs;
        public static CustomOption deputyHandcuffDuration;
        public static CustomOption deputyKnowsSheriff;

        public static CustomOption lighterSpawnRate;
        public static CustomOption lighterModeLightsOnVision;
        public static CustomOption lighterModeLightsOffVision;
        public static CustomOption lighterFlashlightWidth;

        public static CustomOption detectiveSpawnRate;
        public static CustomOption detectiveAnonymousFootprints;
        public static CustomOption detectiveFootprintIntervall;
        public static CustomOption detectiveFootprintDuration;
        public static CustomOption detectiveReportNameDuration;
        public static CustomOption detectiveReportColorDuration;

        public static CustomOption timeMasterSpawnRate;
        public static CustomOption timeMasterCooldown;
        public static CustomOption timeMasterRewindTime;
        public static CustomOption timeMasterShieldDuration;

        public static CustomOption veterenSpawnRate;
        public static CustomOption veterenCooldown;
        public static CustomOption veterenAlertDuration;

        public static CustomOption medicSpawnRate;
        public static CustomOption medicShowShielded;
        public static CustomOption medicShowAttemptToShielded;
        public static CustomOption medicSetOrShowShieldAfterMeeting;
        public static CustomOption medicShowAttemptToMedic;
        public static CustomOption medicSetShieldAfterMeeting;
        public static CustomOption medicBreakShield;
        public static CustomOption medicResetTargetAfterMeeting;

        public static CustomOption swapperSpawnRate;
        public static CustomOption swapperCanCallEmergency;
        public static CustomOption swapperCanFixSabotages;
        public static CustomOption swapperCanOnlySwapOthers;
        public static CustomOption swapperSwapsNumber;
        public static CustomOption swapperRechargeTasksNumber;

        public static CustomOption seerSpawnRate;
        public static CustomOption seerMode;
        public static CustomOption seerSoulDuration;
        public static CustomOption seerLimitSoulDuration;

        public static CustomOption hackerSpawnRate;
        public static CustomOption hackerCooldown;
        public static CustomOption hackerHackeringDuration;
        public static CustomOption hackerOnlyColorType;
        public static CustomOption hackerToolsNumber;
        public static CustomOption hackerRechargeTasksNumber;
        public static CustomOption hackerNoMove;

        public static CustomOption trackerSpawnRate;
        public static CustomOption trackerUpdateIntervall;
        public static CustomOption trackerResetTargetAfterMeeting;
        public static CustomOption trackerCanTrackCorpses;
        public static CustomOption trackerCorpsesTrackingCooldown;
        public static CustomOption trackerCorpsesTrackingDuration;

        public static CustomOption snitchSpawnRate;
        public static CustomOption snitchLeftTasksForReveal;
        public static CustomOption snitchMode;
        public static CustomOption snitchTargets;

        public static CustomOption spySpawnRate;
        public static CustomOption spyCanDieToSheriff;
        public static CustomOption spyImpostorsCanKillAnyone;
        public static CustomOption spyCanEnterVents;
        public static CustomOption spyHasImpostorVision;

        public static CustomOption tricksterSpawnRate;
        public static CustomOption tricksterPlaceBoxCooldown;
        public static CustomOption tricksterLightsOutCooldown;
        public static CustomOption tricksterLightsOutDuration;

        public static CustomOption cleanerSpawnRate;
        public static CustomOption cleanerCooldown;
        
        public static CustomOption warlockSpawnRate;
        public static CustomOption warlockCooldown;
        public static CustomOption warlockRootTime;

        public static CustomOption securityGuardSpawnRate;
        public static CustomOption securityGuardCooldown;
        public static CustomOption securityGuardTotalScrews;
        public static CustomOption securityGuardCamPrice;
        public static CustomOption securityGuardVentPrice;
        public static CustomOption securityGuardCamDuration;
        public static CustomOption securityGuardCamMaxCharges;
        public static CustomOption securityGuardCamRechargeTasksNumber;
        public static CustomOption securityGuardNoMove;

        public static CustomOption bodyGuardSpawnRate;
        public static CustomOption bodyGuardFlash;
        public static CustomOption bodyGuardResetTargetAfterMeeting;

        public static CustomOption vultureSpawnRate;
        public static CustomOption vultureCooldown;
        public static CustomOption vultureNumberToWin;
        public static CustomOption vultureCanUseVents;
        public static CustomOption vultureShowArrows;

        public static CustomOption mediumSpawnRate;
        public static CustomOption mediumCooldown;
        public static CustomOption mediumDuration;
        public static CustomOption mediumOneTimeUse;
        public static CustomOption mediumChanceAdditionalInfo;

        public static CustomOption lawyerSpawnRate;
        public static CustomOption lawyerTargetKnows;
        public static CustomOption lawyerIsProsecutorChance;
        public static CustomOption lawyerTargetCanBeJester;
        public static CustomOption lawyerVision;
        public static CustomOption lawyerKnowsRole;
        public static CustomOption lawyerCanCallEmergency;
        public static CustomOption pursuerCooldown;
        public static CustomOption pursuerBlanksNumber;

        public static CustomOption jumperSpawnRate;
        public static CustomOption jumperJumpTime;
        public static CustomOption jumperChargesOnPlace;
        public static CustomOption jumperResetPlaceAfterMeeting;
     //   public static CustomOption jumperChargesGainOnMeeting;
        //public static CustomOption jumperMaxCharges;

        public static CustomOption escapistSpawnRate;
        public static CustomOption escapistEscapeTime;
        public static CustomOption escapistChargesOnPlace;
        public static CustomOption escapistResetPlaceAfterMeeting;
     //   public static CustomOption jumperChargesGainOnMeeting;
        //public static CustomOption escapistMaxCharges;

        public static CustomOption werewolfSpawnRate;
        public static CustomOption werewolfRampageCooldown;
        public static CustomOption werewolfRampageDuration;
        public static CustomOption werewolfKillCooldown;

        public static CustomOption thiefSpawnRate;
        public static CustomOption thiefCooldown;
        public static CustomOption thiefHasImpVision;
        public static CustomOption thiefCanUseVents;
        public static CustomOption thiefCanKillSheriff;
        public static CustomOption thiefCanStealWithGuess;

        //�������
        public static CustomOption juggernautSpawnRate;
        public static CustomOption juggernautCooldown;
        public static CustomOption juggernautHasImpVision;
        public static CustomOption juggernautReducedkillEach;
        //ĩ��Ԥ�Լ�
        public static CustomOption doomsayerSpawnRate;
        public static CustomOption doomsayerCooldown;
        public static CustomOption doomsayerHasMultipleShotsPerMeeting;
        public static CustomOption doomsayerShowInfoInGhostChat;
        public static CustomOption doomsayerCanGuessNeutral;
        public static CustomOption doomsayerCanGuessImpostor;
        public static CustomOption doomsayerGuesserCantGuessSnitch;
        public static CustomOption doomsayerkillToWin;

        public static CustomOption trapperSpawnRate;
        public static CustomOption trapperCooldown;
        public static CustomOption trapperMaxCharges;
        public static CustomOption trapperRechargeTasksNumber;
        public static CustomOption trapperTrapNeededTriggerToReveal;
        public static CustomOption trapperAnonymousMap;
        public static CustomOption trapperInfoType;
        public static CustomOption trapperTrapDuration;

        public static CustomOption bomberSpawnRate;
        public static CustomOption bomberBombDestructionTime;
        public static CustomOption bomberBombDestructionRange;
        public static CustomOption bomberBombHearRange;
        public static CustomOption bomberDefuseDuration;
        public static CustomOption bomberBombCooldown;
        public static CustomOption bomberBombActiveAfter;

        public static CustomOption modifiersAreHidden;

        public static CustomOption modifierAssassin;
        public static CustomOption modifierAssassinQuantity;
        public static CustomOption modifierAssassinNumberOfShots;
        public static CustomOption modifierAssassinMultipleShotsPerMeeting;
        public static CustomOption modifierAssassinKillsThroughShield;
        public static CustomOption modifierAssassinCultist;

        public static CustomOption modifierBait;
        public static CustomOption modifierBaitQuantity;
        public static CustomOption modifierBaitReportDelayMin;
        public static CustomOption modifierBaitReportDelayMax;
        public static CustomOption modifierBaitShowKillFlash;

        public static CustomOption modifierLover;
        public static CustomOption modifierLoverImpLoverRate;
        public static CustomOption modifierLoverBothDie;
        public static CustomOption modifierLoverEnableChat;

        public static CustomOption modifierBloody;
        public static CustomOption modifierBloodyQuantity;
        public static CustomOption modifierBloodyDuration;

        public static CustomOption modifierAntiTeleport;
        public static CustomOption modifierAntiTeleportQuantity;

        public static CustomOption modifierTieBreaker;

        public static CustomOption modifierSunglasses;
        public static CustomOption modifierSunglassesQuantity;
        public static CustomOption modifierSunglassesVision;

        public static CustomOption modifierTorch;
        public static CustomOption modifierTorchQuantity;

        public static CustomOption modifierMultitasker;
        public static CustomOption modifierMultitaskerQuantity;

        public static CustomOption modifierDisperser;
        
        public static CustomOption modifierMini;
        public static CustomOption modifierMiniGrowingUpDuration;
        public static CustomOption modifierMiniGrowingUpInMeeting;

        public static CustomOption modifierIndomitable;

        public static CustomOption modifierBlind;

        public static CustomOption modifierTunneler;

        public static CustomOption modifierWatcher;

        public static CustomOption modifierRadar;

        public static CustomOption modifierSlueth;
        //public static CustomOption modifierSwooper;

        public static CustomOption modifierCursed;

        public static CustomOption modifierVip;
        public static CustomOption modifierVipQuantity;
        public static CustomOption modifierVipShowColor;

        public static CustomOption modifierInvert;
        public static CustomOption modifierInvertQuantity;
        public static CustomOption modifierInvertDuration;

        public static CustomOption modifierChameleon;
        public static CustomOption modifierChameleonQuantity;
        public static CustomOption modifierChameleonHoldDuration;
        public static CustomOption modifierChameleonFadeDuration;
        public static CustomOption modifierChameleonMinVisibility;

        public static CustomOption modifierShifter;

        public static CustomOption maxNumberOfMeetings;
        public static CustomOption blockSkippingInEmergencyMeetings;
        public static CustomOption noVoteIsSelfVote;
        public static CustomOption hidePlayerNames;
        public static CustomOption showButtonTarget;
        public static CustomOption blockGameEnd;
        public static CustomOption allowParallelMedBayScans;
        public static CustomOption shieldFirstKill;
        public static CustomOption hideVentAnimOnShadows;
        public static CustomOption disableCamsRound1;
        public static CustomOption hideOutOfSightNametags;
        public static CustomOption impostorSeeRoles;
        public static CustomOption transparentTasks;
        public static CustomOption randomGameStartPosition;
        public static CustomOption allowModGuess;
        public static CustomOption finishTasksBeforeHauntingOrZoomingOut;
        public static CustomOption camsNightVision;
        public static CustomOption camsNoNightVisionIfImpVision;

        public static CustomOption dynamicMap;
        public static CustomOption dynamicMapEnableSkeld;
        public static CustomOption dynamicMapEnableMira;
        public static CustomOption dynamicMapEnablePolus;
        public static CustomOption dynamicMapEnableAirShip;
        public static CustomOption dynamicMapEnableFungle;
        public static CustomOption dynamicMapEnableSubmerged;
        public static CustomOption dynamicMapSeparateSettings;

        public static CustomOption movePolusVents;
		public static CustomOption swapNavWifi;
		public static CustomOption movePolusVitals;
		public static CustomOption enableBetterPolus;
		public static CustomOption moveColdTemp;

        public static CustomOption disableMedbayWalk;

        public static CustomOption enableCamoComms;

        public static CustomOption restrictDevices;
        //public static CustomOption restrictAdmin;
        public static CustomOption restrictCameras;
        public static CustomOption restrictVents;

        //Guesser Gamemode
        public static CustomOption guesserGamemodeCrewNumber;
        public static CustomOption guesserGamemodeNeutralNumber;
        public static CustomOption guesserGamemodeImpNumber;
        public static CustomOption guesserForceJackalGuesser;
        public static CustomOption guesserForceThiefGuesser;
        public static CustomOption guesserGamemodeHaveModifier;
        public static CustomOption guesserGamemodeNumberOfShots;
        public static CustomOption guesserGamemodeHasMultipleShotsPerMeeting;
        public static CustomOption guesserGamemodeKillsThroughShield;
        public static CustomOption guesserGamemodeEvilCanKillSpy;
        public static CustomOption guesserGamemodeCantGuessSnitchIfTaksDone;

        // Hide N Seek Gamemode
        public static CustomOption hideNSeekHunterCount;
        public static CustomOption hideNSeekKillCooldown;
        public static CustomOption hideNSeekHunterVision;
        public static CustomOption hideNSeekHuntedVision;
        public static CustomOption hideNSeekTimer;
        public static CustomOption hideNSeekCommonTasks;
        public static CustomOption hideNSeekShortTasks;
        public static CustomOption hideNSeekLongTasks;
        public static CustomOption hideNSeekTaskWin;
        public static CustomOption hideNSeekTaskPunish;
        public static CustomOption hideNSeekCanSabotage;
        public static CustomOption hideNSeekMap;
        public static CustomOption hideNSeekHunterWaiting;

        public static CustomOption hunterLightCooldown;
        public static CustomOption hunterLightDuration;
        public static CustomOption hunterLightVision;
        public static CustomOption hunterLightPunish;
        public static CustomOption hunterAdminCooldown;
        public static CustomOption hunterAdminDuration;
        public static CustomOption hunterAdminPunish;
        public static CustomOption hunterArrowCooldown;
        public static CustomOption hunterArrowDuration;
        public static CustomOption hunterArrowPunish;

        public static CustomOption huntedShieldCooldown;
        public static CustomOption huntedShieldDuration;
        public static CustomOption huntedShieldRewindTime;
        public static CustomOption huntedShieldNumber;

        // Prop Hunt Settings
        public static CustomOption propHuntMap;
        public static CustomOption propHuntTimer;
        public static CustomOption propHuntNumberOfHunters;
        public static CustomOption hunterInitialBlackoutTime;
        public static CustomOption hunterMissCooldown;
        public static CustomOption hunterHitCooldown;
        public static CustomOption hunterMaxMissesBeforeDeath;
        public static CustomOption propBecomesHunterWhenFound;
        public static CustomOption propHunterVision;
        public static CustomOption propVision;
        public static CustomOption propHuntRevealCooldown;
        public static CustomOption propHuntRevealDuration;
        public static CustomOption propHuntRevealPunish;
        public static CustomOption propHuntUnstuckCooldown;
        public static CustomOption propHuntUnstuckDuration;
        public static CustomOption propHuntInvisCooldown;
        public static CustomOption propHuntInvisDuration;
        public static CustomOption propHuntSpeedboostCooldown;
        public static CustomOption propHuntSpeedboostDuration;
        public static CustomOption propHuntSpeedboostSpeed;
        public static CustomOption propHuntSpeedboostEnabled;
        public static CustomOption propHuntInvisEnabled;
        public static CustomOption propHuntAdminCooldown;
        public static CustomOption propHuntFindCooldown;
        public static CustomOption propHuntFindDuration;

        internal static Dictionary<byte, byte[]> blockedRolePairings = new Dictionary<byte, byte[]>();

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }

        public static bool isMapSelectionOption(CustomOption option) {
            return option == CustomOptionHolder.propHuntMap && option == CustomOptionHolder.hideNSeekMap;
        }

        public static void Load() {

            CustomOption.vanillaSettings = TheOtherRolesPlugin.Instance.Config.Bind("Ԥ��0", "ԭ������", "");

            // Role Options
            presetSelection = CustomOption.Create(0, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "����"), presets, null, true);
            activateRoles = CustomOption.Create(1, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "����ģ��ְҵ������ԭ��ְҵ"), true, null, true);

            if (Utilities.EventUtility.canBeEnabled) enableCodenameHorsemode = CustomOption.Create(10423, Types.General, cs(Color.green, "����Horsemode"), true, null, true);
            if (Utilities.EventUtility.canBeEnabled) enableCodenameDisableHorses = CustomOption.Create(10424, Types.General, cs(Color.green, "����Horses"), false, enableCodenameHorsemode, false);

            // Using new id's for the options to not break compatibilty with older versions
            crewmateRolesCountMin = CustomOption.Create(300, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С��Ա��Ӫְҵ��"), 15f, 0f, 15f, 1f, null, true);
            crewmateRolesCountMax = CustomOption.Create(301, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "���Ա��Ӫְҵ��"), 15f, 0f, 15f, 1f);
            crewmateRolesFill = CustomOption.Create(308, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "���д�Ա�ض�ӵ��ְҵ\n(������С/�������)"), false);
            neutralRolesCountMin = CustomOption.Create(302, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С������Ӫְҵ��"), 15f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��������Ӫְҵ��"), 15f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С�ڹ���Ӫְҵ��"), 15f, 0f, 15f, 1f);
            impostorRolesCountMax = CustomOption.Create(305, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "����ڹ���Ӫְҵ��"), 15f, 0f, 15f, 1f);
            modifiersCountMin = CustomOption.Create(306, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С����ְҵ��"), 15f, 0f, 15f, 1f);
            modifiersCountMax = CustomOption.Create(307, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��󸽼�ְҵ��"), 15f, 0f, 15f, 1f);

            modifierAssassin = CustomOption.Create(2000, Types.Impostor, cs(Color.red, "�̿�"), rates, null, true);
            modifierAssassinQuantity = CustomOption.Create(2001, Types.Impostor, cs(Color.red, "�̿�����"), ratesModifier, modifierAssassin);
            modifierAssassinNumberOfShots = CustomOption.Create(2002, Types.Impostor, "�ɲ²����", 5f, 1f, 15f, 1f, modifierAssassin);
            modifierAssassinMultipleShotsPerMeeting = CustomOption.Create(2003, Types.Impostor, "ͬһ�ֻ���ɶ�β²�", true, modifierAssassin);
            guesserEvilCanKillSpy = CustomOption.Create(2004, Types.Impostor, "���Բ²�ְҵ���Եס�", true, modifierAssassin);
            guesserEvilCanKillCrewmate = CustomOption.Create(20045, Types.Impostor, "���Բ²�ְҵ����Ա��", true, modifierAssassin);
            guesserCantGuessSnitchIfTaksDone = CustomOption.Create(2005, Types.Impostor, "���ɲ²����������ع�", true, modifierAssassin);
            modifierAssassinKillsThroughShield = CustomOption.Create(2006, Types.Impostor, "�²����ӷ�ҽ���ܱ���", false, modifierAssassin);
            modifierAssassinCultist = CustomOption.Create(2004446, Types.Impostor, "����ͽ�ɳ�Ϊ�̿�", false, modifierAssassin);

            mafiaSpawnRate = CustomOption.Create(18, Types.Impostor, cs(Janitor.color, "���ֵ�"), rates, null, true);
            janitorCooldown = CustomOption.Create(19, Types.Impostor, "��๤������ȴ", 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

            morphlingSpawnRate = CustomOption.Create(20, Types.Impostor, cs(Morphling.color, "������"), rates, null, true);
            morphlingCooldown = CustomOption.Create(21, Types.Impostor, "������ȴ", 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
            morphlingDuration = CustomOption.Create(22, Types.Impostor, "���γ���ʱ��", 10f, 1f, 20f, 0.5f, morphlingSpawnRate);

            bomber2SpawnRate = CustomOption.Create(8840, Types.Impostor, cs(Bomber2.color, "ը����"), rates, null, true);
            bomber2BombCooldown = CustomOption.Create(8841, Types.Impostor, "ը����ȴ", 30f, 25f, 60f, 2.5f, bomber2SpawnRate);
            bomber2Delay = CustomOption.Create(8842, Types.Impostor, "ը���ӳ�", 10f, 1f, 20f, 0.5f, bomber2SpawnRate);
            bomber2Timer = CustomOption.Create(8843, Types.Impostor, "ը������ʱ��", 10f, 5f, 30f, 5f, bomber2SpawnRate);
            //bomber2HotPotatoMode = CustomOption.Create(2526236, Types.Impostor, "Hot Potato Mode", false, bomber2SpawnRate);

            undertakerSpawnRate = CustomOption.Create(1201, Types.Impostor, cs(Undertaker.color, "�а�ɥ����"), rates, null, true);
            undertakerDragingDelaiAfterKill = CustomOption.Create(1202, Types.Impostor, "�ӻ�ɱ���ָ���ҷ��������ʱ��", 0f, 0f, 15, 1f, undertakerSpawnRate);
            undertakerCanDragAndVent = CustomOption.Create(1203, Types.Impostor, "��ҷ�����п�ʹ�ùܵ�", true, undertakerSpawnRate);

            camouflagerSpawnRate = CustomOption.Create(30, Types.Impostor, cs(Camouflager.color, "������"), rates, null, true);
            camouflagerCooldown = CustomOption.Create(31, Types.Impostor, "����״̬��ȴ", 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
            camouflagerDuration = CustomOption.Create(32, Types.Impostor, "����״̬����ʱ��", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

            vampireSpawnRate = CustomOption.Create(40, Types.Impostor, cs(Vampire.color, "��Ѫ��"), rates, null, true);
            vampireKillDelay = CustomOption.Create(41, Types.Impostor, "����Ѫ����ɱ����ʱ��", 10f, 1f, 20f, 1f, vampireSpawnRate);
            vampireCooldown = CustomOption.Create(42, Types.Impostor, "��Ѫ��ȴ", 30f, 10f, 60f, 2.5f, vampireSpawnRate);
            vampireGarlicButton = CustomOption.Create(43277854, Types.Impostor, "�ɷ��ô���", true, vampireSpawnRate);
            vampireCanKillNearGarlics = CustomOption.Create(43, Types.Impostor, "���ڴ��⸽��������ɱ", true, vampireGarlicButton);

            eraserSpawnRate = CustomOption.Create(230, Types.Impostor, cs(Eraser.color, "Ĩ����"), rates, null, true);
            eraserCooldown = CustomOption.Create(231, Types.Impostor, "Ĩ����ȴ", 30f, 10f, 120f, 5f, eraserSpawnRate);
            eraserCanEraseAnyone = CustomOption.Create(232, Types.Impostor, "��Ĩ���κ���", false, eraserSpawnRate);

            poucherSpawnRate = CustomOption.Create(8833, Types.Impostor, cs(Poucher.color, "����ʦ"), rates, null, true);
            mimicSpawnRate = CustomOption.Create(8835, Types.Impostor, cs(Mimic.color, "ģ����"), rates, null, true);

            escapistSpawnRate = CustomOption.Create(905000, Types.Impostor, cs(Escapist.color, "������"), rates, null, true);
            escapistEscapeTime = CustomOption.Create(905100, Types.Impostor, "���/������ȴ", 30, 0, 60, 5, escapistSpawnRate);
            escapistChargesOnPlace = CustomOption.Create(905200, Types.Impostor, "ÿ������/�������ĵ���", 1, 1, 10, 1, escapistSpawnRate);
            //       jumperResetPlaceAfterMeeting = CustomOption.Create(9052, Types.Crewmate, "Reset Places After Meeting", true, jumperSpawnRate);
            //       jumperChargesGainOnMeeting = CustomOption.Create(9053, Types.Crewmate, "Charges Gained After Meeting", 2, 0, 10, 1, jumperSpawnRate);
            //escapistMaxCharges = CustomOption.Create(905400, Types.Impostor, "Maximum Charges", 3, 0, 10, 1, escapistSpawnRate);

            cultistSpawnRate = CustomOption.Create(3801, Types.Impostor, cs(Cultist.color, "����ʿ"), rates, null, true);

            tricksterSpawnRate = CustomOption.Create(250, Types.Impostor, cs(Trickster.color, "ƭ��ʦ"), rates, null, true);
            tricksterPlaceBoxCooldown = CustomOption.Create(251, Types.Impostor, "���þ��ź���ȴ", 10f, 2.5f, 30f, 2.5f, tricksterSpawnRate);
            tricksterLightsOutCooldown = CustomOption.Create(252, Types.Impostor, "Ϩ����ȴ", 30f, 10f, 60f, 5f, tricksterSpawnRate);
            tricksterLightsOutDuration = CustomOption.Create(253, Types.Impostor, "Ϩ�Ƴ���ʱ��", 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

            cleanerSpawnRate = CustomOption.Create(260, Types.Impostor, cs(Cleaner.color, "������"), rates, null, true);
            cleanerCooldown = CustomOption.Create(261, Types.Impostor, "������ȴ", 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

            warlockSpawnRate = CustomOption.Create(270, Types.Impostor, cs(Cleaner.color, "��ʿ"), rates, null, true);
            warlockCooldown = CustomOption.Create(271, Types.Impostor, "������ȴ", 30f, 10f, 60f, 2.5f, warlockSpawnRate);
            warlockRootTime = CustomOption.Create(272, Types.Impostor, "ʹ��������ɱ�������ʱ��", 5f, 0f, 15f, 1f, warlockSpawnRate);

            bountyHunterSpawnRate = CustomOption.Create(320, Types.Impostor, cs(BountyHunter.color, "�ͽ�����"), rates, null, true);
            bountyHunterBountyDuration = CustomOption.Create(321, Types.Impostor, "�ͽ�Ŀ��������", 60f, 10f, 180f, 10f, bountyHunterSpawnRate);
            bountyHunterReducedCooldown = CustomOption.Create(322, Types.Impostor, "��ɱĿ���Ľ�����ȴ", 2.5f, 0f, 30f, 2.5f, bountyHunterSpawnRate);
            bountyHunterPunishmentTime = CustomOption.Create(323, Types.Impostor, "��ɱ��Ŀ���ĳͷ���ȴ", 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate);
            bountyHunterShowArrow = CustomOption.Create(324, Types.Impostor, "��ʾָ������Ŀ��ļ�ͷ", true, bountyHunterSpawnRate);
            bountyHunterArrowUpdateIntervall = CustomOption.Create(325, Types.Impostor, "��ͷ���¼��", 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow);

            witchSpawnRate = CustomOption.Create(370, Types.Impostor, cs(Witch.color, "Ů��"), rates, null, true);
            witchCooldown = CustomOption.Create(371, Types.Impostor, "������ȴ", 30f, 10f, 120f, 5f, witchSpawnRate);
            witchAdditionalCooldown = CustomOption.Create(372, Types.Impostor, "������ȴ����", 10f, 0f, 60f, 5f, witchSpawnRate);
            witchCanSpellAnyone = CustomOption.Create(373, Types.Impostor, "�������κ���", false, witchSpawnRate);
            witchSpellCastingDuration = CustomOption.Create(374, Types.Impostor, "������������ʱ��", 1f, 0f, 10f, 1f, witchSpawnRate);
            witchTriggerBothCooldowns = CustomOption.Create(375, Types.Impostor, "�������ɱ��ȴ����", true, witchSpawnRate);
            witchVoteSavesTargets = CustomOption.Create(376, Types.Impostor, "����Ů�׿����ȱ�������", true, witchSpawnRate);

            ninjaSpawnRate = CustomOption.Create(380, Types.Impostor, cs(Ninja.color, "����"), rates, null, true);
            ninjaCooldown = CustomOption.Create(381, Types.Impostor, "�����ȴ", 30f, 10f, 120f, 5f, ninjaSpawnRate);
            ninjaKnowsTargetLocation = CustomOption.Create(382, Types.Impostor, "��ʾָ����ɱ����ļ�ͷ", true, ninjaSpawnRate);
            ninjaTraceTime = CustomOption.Create(383, Types.Impostor, "��ɱ����Ҷ�ۼ�����ʱ��", 5f, 1f, 20f, 0.5f, ninjaSpawnRate);
            ninjaTraceColorTime = CustomOption.Create(384, Types.Impostor, "��ɱ��ۼ���ɫ����ʱ��", 2f, 0f, 20f, 0.5f, ninjaSpawnRate);
            ninjaInvisibleDuration = CustomOption.Create(385, Types.Impostor, "��ɱ���������ʱ��", 3f, 0f, 20f, 1f, ninjaSpawnRate);

            blackmailerSpawnRate = CustomOption.Create(710, Types.Impostor, cs(Blackmailer.color, "������"), rates, null, true);
            blackmailerCooldown = CustomOption.Create(711, Types.Impostor, "������ȴ", 30f, 5f, 120f, 5f, blackmailerSpawnRate);

            bomberSpawnRate = CustomOption.Create(460, Types.Impostor, cs(Bomber.color, "�ֲ�����"), rates, null, true);
            bomberBombDestructionTime = CustomOption.Create(461, Types.Impostor, "ը����ըʱ�䣨ը���ӿ�ʼ��������ը��ʱ������", 20f, 2.5f, 120f, 2.5f, bomberSpawnRate);
            bomberBombDestructionRange = CustomOption.Create(462, Types.Impostor, "ը����ը��Χ", 50f, 5f, 150f, 5f, bomberSpawnRate);
            bomberBombHearRange = CustomOption.Create(463, Types.Impostor, "ը���ɼ���Χ", 60f, 5f, 150f, 5f, bomberSpawnRate);
            bomberDefuseDuration = CustomOption.Create(464, Types.Impostor, "���ը������ʱ��", 3f, 0.5f, 30f, 0.5f, bomberSpawnRate);
            bomberBombCooldown = CustomOption.Create(465, Types.Impostor, "ը��������ȴ", 15f, 2.5f, 30f, 2.5f, bomberSpawnRate);
            bomberBombActiveAfter = CustomOption.Create(466, Types.Impostor, "����ը����ը���ɱ�������ը����ʼ��������ʱ����", 3f, 0.5f, 15f, 0.5f, bomberSpawnRate);
            /*
                        guesserSpawnRate = CustomOption.Create(310, Types.Neutral, cs(Guesser.color, "Guesser"), rates, null, true);
                        guesserIsImpGuesserRate = CustomOption.Create(311, Types.Neutral, "Chance That The Guesser Is An Impostor", rates, guesserSpawnRate);
                        guesserNumberOfShots = CustomOption.Create(312, Types.Neutral, "Guesser Number Of Shots", 2f, 1f, 15f, 1f, guesserSpawnRate);
                        guesserHasMultipleShotsPerMeeting = CustomOption.Create(313, Types.Neutral, "Guesser Can Shoot Multiple Times Per Meeting", false, guesserSpawnRate);
                        guesserKillsThroughShield  = CustomOption.Create(315, Types.Neutral, "Guesses Ignore The Medic Shield", true, guesserSpawnRate);
                        guesserEvilCanKillSpy  = CustomOption.Create(316, Types.Neutral, "Evil Guesser Can Guess The Spy", true, guesserSpawnRate);
                        guesserSpawnBothRate = CustomOption.Create(317, Types.Neutral, "Both Guesser Spawn Rate", rates, guesserSpawnRate);
                        guesserCantGuessSnitchIfTaksDone = CustomOption.Create(318, Types.Neutral, "Guesser Can't Guess Snitch When Tasks Completed", true, guesserSpawnRate);
                        */

            jesterSpawnRate = CustomOption.Create(60, Types.Neutral, cs(Jester.color, "С��yumu"), rates, null, true);
            jesterCanCallEmergency = CustomOption.Create(61, Types.Neutral, "С����ٿ�����", true, jesterSpawnRate);
            jesterCanVent = CustomOption.Create(1901, Types.Neutral, "С���ʹ�ùܵ�", true, jesterSpawnRate);
            jesterHasImpostorVision = CustomOption.Create(62, Types.Neutral, "ӵ���ڹ���Ұ", false, jesterSpawnRate);

            amnisiacSpawnRate = CustomOption.Create(616, Types.Neutral, cs(Amnisiac.color, "ʧ����"), rates, null, true);
            amnisiacShowArrows = CustomOption.Create(617, Types.Neutral, "��ʾָ��ʬ��ļ�ͷ", true, amnisiacSpawnRate);
            amnisiacResetRole = CustomOption.Create(618, Types.Neutral, "��������ø�ְҵ����ʹ�ô���", true, amnisiacSpawnRate);

            arsonistSpawnRate = CustomOption.Create(290, Types.Neutral, cs(Arsonist.color, "�ݻ�"), rates, null, true);
            arsonistCooldown = CustomOption.Create(291, Types.Neutral, "Ϳ����ȴ", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
            arsonistDuration = CustomOption.Create(292, Types.Neutral, "Ϳ������ʱ��", 3f, 1f, 10f, 1f, arsonistSpawnRate);

            jackalSpawnRate = CustomOption.Create(220, Types.Neutral, cs(Jackal.color, "����"), rates, null, true);
            jackalKillCooldown = CustomOption.Create(221, Types.Neutral, "����/�����ɱ��ȴ", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalChanceSwoop = CustomOption.Create(3642134, Types.Neutral, "���ǻ�����������ĸ���", rates, jackalSpawnRate);
            swooperCooldown = CustomOption.Create(1111, Types.Neutral, "������ȴ", 30f, 10f, 60f, 2.5f, jackalChanceSwoop);
            swooperDuration = CustomOption.Create(1112, Types.Neutral, "�������ʱ��", 10f, 1f, 20f, 0.5f, jackalChanceSwoop);
            jackalCreateSidekickCooldown = CustomOption.Create(222, Types.Neutral, "������ļ��ȴ", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCanUseVents = CustomOption.Create(223, Types.Neutral, "���ǿ�ʹ�ùܵ�", true, jackalSpawnRate);
            jackalCanUseSabo = CustomOption.Create(8876, Types.Neutral, "����/����ɽ����ƻ�", false, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224, Types.Neutral, "���ǿ�����ļ����", false, jackalSpawnRate);
            sidekickPromotesToJackal = CustomOption.Create(225, Types.Neutral, "�����������ɽ���", false, jackalCanCreateSidekick);
            sidekickCanKill = CustomOption.Create(226, Types.Neutral, "����ɽ��л�ɱ", false, jackalCanCreateSidekick);
            sidekickCanUseVents = CustomOption.Create(227, Types.Neutral, "�����ʹ�ùܵ�", true, jackalCanCreateSidekick);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, Types.Neutral, "������Ĳ��ǿ�����ļ����", true, sidekickPromotesToJackal);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, Types.Neutral, "���ǿ�����ļ�ڹ�Ϊ����", true, jackalCanCreateSidekick);
            jackalKillFakeImpostor = CustomOption.Create(7885, Types.Neutral, "���ǲ��ɻ�ɱ����ļʧ�ܵ��ڹ�", true, jackalCanCreateSidekick);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, Types.Neutral, "����/����ӵ���ڹ���Ұ", false, jackalSpawnRate);

            minerSpawnRate = CustomOption.Create(1120, Types.Impostor, cs(Miner.color, "�ܵ���"), rates, null, true);
            minerCooldown = CustomOption.Create(1121, Types.Impostor, "����ܵ���ȴ", 25f, 10f, 60f, 2.5f, minerSpawnRate);

            vultureSpawnRate = CustomOption.Create(340, Types.Neutral, cs(Vulture.color, "ͺ��"), rates, null, true);
            vultureCooldown = CustomOption.Create(341, Types.Neutral, "������ȴ", 15f, 10f, 60f, 2.5f, vultureSpawnRate);
            vultureNumberToWin = CustomOption.Create(342, Types.Neutral, "��ʤ�������ɴ���", 4f, 1f, 10f, 1f, vultureSpawnRate);
            vultureCanUseVents = CustomOption.Create(343, Types.Neutral, "��ʹ�ùܵ�", true, vultureSpawnRate);
            vultureShowArrows = CustomOption.Create(344, Types.Neutral, "��ʾָ��ʬ��ļ�ͷ", true, vultureSpawnRate);

            lawyerSpawnRate = CustomOption.Create(350, Types.Neutral, cs(Lawyer.color, "�绤��ʦ"), rates, null, true);
            lawyerIsProsecutorChance = CustomOption.Create(358, Types.Neutral, "�绤��ʦΪ�����ߵĸ���", rates, lawyerSpawnRate);
            lawyerTargetKnows = CustomOption.Create(3511, Types.Neutral, "�ͻ�֪����ʦ����", true, lawyerSpawnRate);
            lawyerVision = CustomOption.Create(354, Types.Neutral, "��Ұ����", 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate);
            lawyerKnowsRole = CustomOption.Create(355, Types.Neutral, "��ʦ/�����߿ɵ�֪Ŀ��ְҵ", false, lawyerSpawnRate);
            lawyerCanCallEmergency = CustomOption.Create(352, Types.Neutral, "��ʦ/�����߿��ٿ�����", true, lawyerSpawnRate);
            lawyerTargetCanBeJester = CustomOption.Create(351, Types.Neutral, "С����Գ�Ϊ�ͻ�", false, lawyerSpawnRate);
            pursuerCooldown = CustomOption.Create(356, Types.Neutral, "�����˿հ�����ȴ", 30f, 5f, 60f, 2.5f, lawyerSpawnRate);
            pursuerBlanksNumber = CustomOption.Create(357, Types.Neutral, "�����˿հ������ô���", 5f, 1f, 20f, 1f, lawyerSpawnRate);

            werewolfSpawnRate = CustomOption.Create(1501, Types.Neutral, cs(Werewolf.color, "��������"), rates, null, true);
            werewolfRampageCooldown = CustomOption.Create(1502, Types.Neutral, "����ȴ", 30f, 10f, 60f, 2.5f, werewolfSpawnRate);
            werewolfRampageDuration = CustomOption.Create(1503, Types.Neutral, "�񱩳���ʱ��", 15f, 1f, 20f, 0.5f, werewolfSpawnRate);
            werewolfKillCooldown = CustomOption.Create(1504, Types.Neutral, "��ɱ��ȴ", 3f, 1f, 60f, 1f, werewolfSpawnRate);

            guesserSpawnRate = CustomOption.Create(310, Types.Crewmate, cs(Guesser.color, "�Ĺ�"), rates, null, true);
            guesserNumberOfShots = CustomOption.Create(311, Types.Crewmate, "�ɲ²����", 5f, 1f, 15f, 1f, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(312, Types.Crewmate, "ͬһ�ֻ���ɶ�β²�", true, guesserSpawnRate);
            guesserShowInfoInGhostChat = CustomOption.Create(313, Types.Crewmate, "���ɼ��²���", true, guesserSpawnRate);
            guesserKillsThroughShield = CustomOption.Create(314, Types.Crewmate, "�²����ӷ�ҽ���ܱ���", false, guesserSpawnRate);

            mayorSpawnRate = CustomOption.Create(80, Types.Crewmate, cs(Mayor.color, "�г�"), rates, null, true);
            mayorCanSeeVoteColors = CustomOption.Create(81, Types.Crewmate, "ӵ�п�Ʊ����", false, mayorSpawnRate);
            mayorTasksNeededToSeeVoteColors = CustomOption.Create(82, Types.Crewmate, "��ÿ�Ʊ����������ɵ�������", 5f, 0f, 20f, 1f, mayorCanSeeVoteColors);
            mayorMeetingButton = CustomOption.Create(83, Types.Crewmate, "��Զ���ٿ�����", true, mayorSpawnRate);
            mayorMaxRemoteMeetings = CustomOption.Create(84, Types.Crewmate, "Զ���ٿ�������ô���", 1f, 1f, 5f, 1f, mayorMeetingButton);
            mayorChooseSingleVote = CustomOption.Create(85, Types.Crewmate, "�г���ѡ��Ͷ��Ʊ", new string[] { "��", "�� (ͶƱǰѡ��)", "�� (�������ǰ����ѡ��)" }, mayorSpawnRate);

            engineerSpawnRate = CustomOption.Create(90, Types.Crewmate, cs(Engineer.color, "����ʦ"), rates, null, true);
            engineerRemoteFix = CustomOption.Create(911221, Types.Crewmate, "��Զ�������ƻ�", true, engineerSpawnRate);
            engineerResetFixAfterMeeting = CustomOption.Create(9111, Types.Crewmate, "����������������", false, engineerRemoteFix);
            engineerNumberOfFixes = CustomOption.Create(91, Types.Crewmate, "Զ��������ô���", 1f, 1f, 3f, 1f, engineerRemoteFix);
            //engineerExpertRepairs = CustomOption.Create(91121, Types.Crewmate, "Advanced Sabotage Repair", false, engineerSpawnRate);
            engineerHighlightForImpostors = CustomOption.Create(92, Types.Crewmate, "�ڹ�ɼ�����ʦ�ܵ��߹�", true, engineerSpawnRate);
            engineerHighlightForTeamJackal = CustomOption.Create(93, Types.Crewmate, "����/����ɼ�����ʦ�ܵ��߹� ", true, engineerSpawnRate);

            privateInvestigatorSpawnRate = CustomOption.Create(8839, Types.Crewmate, cs(PrivateInvestigator.color, "�۲���"), rates, null, true);
            privateInvestigatorSeeColor = CustomOption.Create(8844, Types.Crewmate, "�ɼ����ܴ���ʱ�Է�������ɫ", true, privateInvestigatorSpawnRate);

            sheriffSpawnRate = CustomOption.Create(100, Types.Crewmate, cs(Sheriff.color, "����"), rates, null, true);
            sheriffCooldown = CustomOption.Create(101, Types.Crewmate, "ִ����ȴ", 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
            sheriffMisfireKills = CustomOption.Create(2101, Types.Crewmate, "�߻�ʱ��������", new string[] { "����", "�Է�", "˫��" }, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102, Types.Crewmate, "��ִ��������Ӫ", false, sheriffSpawnRate);
            sheriffCanKillJester = CustomOption.Create(2104, Types.Crewmate, "��ִ�� " + cs(Jester.color, "С��"), false, sheriffCanKillNeutrals);
            sheriffCanKillProsecutor = CustomOption.Create(2105, Types.Crewmate, "��ִ�� " + cs(Lawyer.color, "������"), false, sheriffCanKillNeutrals);
            sheriffCanKillAmnesiac = CustomOption.Create(210278, Types.Crewmate, "��ִ�� " + cs(Amnisiac.color, "ʧ����"), false, sheriffCanKillNeutrals);
            sheriffCanKillArsonist = CustomOption.Create(2102, Types.Crewmate, "��ִ�� " + cs(Arsonist.color, "�ݻ�"), false, sheriffCanKillNeutrals);
            sheriffCanKillVulture = CustomOption.Create(2107, Types.Crewmate, "��ִ�� " + cs(Vulture.color, "ͺ��"), false, sheriffCanKillNeutrals);
            sheriffCanKillLawyer = CustomOption.Create(2103, Types.Crewmate, "��ִ�� " + cs(Lawyer.color, "��ʦ"), false, sheriffCanKillNeutrals);
            sheriffCanKillThief = CustomOption.Create(210277, Types.Crewmate, "��ִ�� " + cs(Thief.color, "�������"), false, sheriffCanKillNeutrals);
            sheriffCanKillPursuer = CustomOption.Create(2106, Types.Crewmate, "��ִ�� " + cs(Pursuer.color, "������"), false, sheriffCanKillNeutrals);
            sheriffCanKillDoomsayer = CustomOption.Create(2108, Types.Crewmate, "��ִ�� " + cs(Doomsayer.color, "ĩ��Ԥ�Լ�"), false, sheriffCanKillNeutrals);

            deputySpawnRate = CustomOption.Create(103, Types.Crewmate, "��ӵ��һ������", rates, sheriffSpawnRate);
            deputyNumberOfHandcuffs = CustomOption.Create(104, Types.Crewmate, "����������ô���", 3f, 1f, 10f, 1f, deputySpawnRate);
            deputyHandcuffCooldown = CustomOption.Create(105, Types.Crewmate, "������ȴ", 30f, 10f, 60f, 2.5f, deputySpawnRate);
            deputyHandcuffDuration = CustomOption.Create(106, Types.Crewmate, "�������ʱ��", 15f, 5f, 60f, 2.5f, deputySpawnRate);
            deputyKnowsSheriff = CustomOption.Create(107, Types.Crewmate, "����/�������Ի���֪�� ", true, deputySpawnRate);
            deputyGetsPromoted = CustomOption.Create(108, Types.Crewmate, "�������󸨾��ɽ���", new string[] { "��", "��������", "��������" }, deputySpawnRate);
            deputyKeepsHandcuffs = CustomOption.Create(109, Types.Crewmate, "��������������", true, deputyGetsPromoted);

            lighterSpawnRate = CustomOption.Create(110, Types.Crewmate, cs(Lighter.color, "ִ����"), rates, null, true);
            lighterModeLightsOnVision = CustomOption.Create(111, Types.Crewmate, "�ƹ�����ʱ���״̬�µ���Ұ����", 1.5f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterModeLightsOffVision = CustomOption.Create(112, Types.Crewmate, "Ϩ��ʱ���״̬�µ���Ұ����", 0.5f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterFlashlightWidth = CustomOption.Create(113, Types.Crewmate, "�ֵ�Ͳ��Χ", 0.3f, 0.1f, 1f, 0.1f, lighterSpawnRate);

            detectiveSpawnRate = CustomOption.Create(120, Types.Crewmate, cs(Detective.color, "��̽"), rates, null, true);
            detectiveAnonymousFootprints = CustomOption.Create(121, Types.Crewmate, "������ӡ", false, detectiveSpawnRate);
            detectiveFootprintIntervall = CustomOption.Create(122, Types.Crewmate, "��ӡ���¼��", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(123, Types.Crewmate, "��ӡ����ʱ��", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveReportNameDuration = CustomOption.Create(124, Types.Crewmate, "����ʱ���ڱ���ɵ�֪��������", 0, 0, 60, 2.5f, detectiveSpawnRate);
            detectiveReportColorDuration = CustomOption.Create(125, Types.Crewmate, "����ʱ���ڱ���ɵ�֪������ɫ����", 20, 0, 120, 2.5f, detectiveSpawnRate);

            timeMasterSpawnRate = CustomOption.Create(130, Types.Crewmate, cs(TimeMaster.color, "ʱ��֮��"), rates, null, true);
            timeMasterCooldown = CustomOption.Create(131, Types.Crewmate, "ʱ��֮����ȴ", 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
            timeMasterRewindTime = CustomOption.Create(132, Types.Crewmate, "����ʱ��", 3f, 1f, 10f, 1f, timeMasterSpawnRate);
            timeMasterShieldDuration = CustomOption.Create(133, Types.Crewmate, "ʱ��֮�ܳ���ʱ��", 3f, 1f, 20f, 1f, timeMasterSpawnRate);

            veterenSpawnRate = CustomOption.Create(4450, Types.Crewmate, cs(Veteren.color, "�ϱ�"), rates, null, true);
            veterenCooldown = CustomOption.Create(4451, Types.Crewmate, "������ȴ", 30f, 10f, 120f, 2.5f, veterenSpawnRate);
            veterenAlertDuration = CustomOption.Create(4452, Types.Crewmate, "�������ʱ��", 3f, 1f, 20f, 1f, veterenSpawnRate);

            medicSpawnRate = CustomOption.Create(140, Types.Crewmate, cs(Medic.color, "��ҽ"), rates, null, true);
            medicShowShielded = CustomOption.Create(143, Types.Crewmate, "�ɼ���ҽ���ܵ����", new string[] { "������", "��������+��ҽ", "��ҽ" }, medicSpawnRate);
            medicBreakShield = CustomOption.Create(1146, Types.Crewmate, "���ܳ�����Ч", true, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144, Types.Crewmate, "�������߿ɼ���ɱ����", false, medicBreakShield);
            medicResetTargetAfterMeeting = CustomOption.Create(1423234, Types.Crewmate, "��������ñ���Ŀ��", false, medicSpawnRate);
            medicSetOrShowShieldAfterMeeting = CustomOption.Create(145, Types.Crewmate, "������Ч��ɼ�ʱ��", new string[] { "������Ч�ҿɼ�", "������Ч�һ����ɼ�", "�������Ч�ҿɼ�" }, medicSpawnRate);
            medicShowAttemptToMedic = CustomOption.Create(146, Types.Crewmate, "��ҽ�ɼ��Ա������ߵĻ�ɱ����", false, medicBreakShield);

            swapperSpawnRate = CustomOption.Create(150, Types.Crewmate, cs(Swapper.color, "��Ʊʦ"), rates, null, true);
            swapperCanCallEmergency = CustomOption.Create(151, Types.Crewmate, "���ٿ�����", false, swapperSpawnRate);
            swapperCanFixSabotages = CustomOption.Create(1512, Types.Crewmate, "����������ƻ�", false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152, Types.Crewmate, "ֻ�ɽ�������", false, swapperSpawnRate);

            swapperSwapsNumber = CustomOption.Create(153, Types.Crewmate, "��ʼ�ɻ�Ʊ����", 1f, 0f, 5f, 1f, swapperSpawnRate);
            swapperRechargeTasksNumber = CustomOption.Create(154, Types.Crewmate, "��������������", 2f, 1f, 10f, 1f, swapperSpawnRate);


            seerSpawnRate = CustomOption.Create(160, Types.Crewmate, cs(Seer.color, "��ý"), rates, null, true);
            seerMode = CustomOption.Create(161, Types.Crewmate, "��֪ģʽ", new string[] { "��������+�ɼ����", "��������", "�ɼ����" }, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163, Types.Crewmate, "�������ɼ�ʱ��", false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162, Types.Crewmate, "���ɼ�ʱ��", 15f, 0f, 120f, 5f, seerLimitSoulDuration);

            hackerSpawnRate = CustomOption.Create(170, Types.Crewmate, cs(Hacker.color, "����"), rates, null, true);
            hackerCooldown = CustomOption.Create(171, Types.Crewmate, "������ȴ", 30f, 5f, 60f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(172, Types.Crewmate, "�������ʱ��", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
            hackerOnlyColorType = CustomOption.Create(173, Types.Crewmate, "�����ֻ�ɼ���ɫ����", false, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(174, Types.Crewmate, "�ƶ��豸�����ܴ���", 5f, 1f, 30f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(175, Types.Crewmate, "��������������", 2f, 1f, 5f, 1f, hackerSpawnRate);
            hackerNoMove = CustomOption.Create(176, Types.Crewmate, "�������ƶ�ʱʹ���ƶ��豸", true, hackerSpawnRate);

            trackerSpawnRate = CustomOption.Create(200, Types.Crewmate, cs(Tracker.color, "������"), rates, null, true);
            trackerUpdateIntervall = CustomOption.Create(201, Types.Crewmate, "��ͷ���¼��", 5f, 1f, 30f, 1f, trackerSpawnRate);
            trackerResetTargetAfterMeeting = CustomOption.Create(202, Types.Crewmate, "��������ø���Ŀ��", false, trackerSpawnRate);
            trackerCanTrackCorpses = CustomOption.Create(203, Types.Crewmate, "�ɸ���ʬ��", true, trackerSpawnRate);
            trackerCorpsesTrackingCooldown = CustomOption.Create(204, Types.Crewmate, "����ʬ����ȴ", 30f, 5f, 120f, 5f, trackerCanTrackCorpses);
            trackerCorpsesTrackingDuration = CustomOption.Create(205, Types.Crewmate, "����ʬ�����ʱ��", 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses);

            snitchSpawnRate = CustomOption.Create(210, Types.Crewmate, cs(Snitch.color, "������"), rates, null, true);
            snitchLeftTasksForReveal = CustomOption.Create(219, Types.Crewmate, "ʣ���������ʱ�ɱ�����", 5f, 0f, 25f, 1f, snitchSpawnRate);
            snitchMode = CustomOption.Create(211, Types.Crewmate, "��Ϣ��ʾ", new string[] { "�����", "��ͼ", "�����+��ͼ" }, snitchSpawnRate);
            snitchTargets = CustomOption.Create(212, Types.Crewmate, "��ʾĿ��", new string[] { "����а��ְҵ", "ɱ��ְҵ" }, snitchSpawnRate);

            spySpawnRate = CustomOption.Create(240, Types.Crewmate, cs(Spy.color, "�Ե�"), rates, null, true);
            spyCanDieToSheriff = CustomOption.Create(241, Types.Crewmate, "�ɱ�����ִ��", false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242, Types.Crewmate, "�Ե��ڳ�ʱ�ڹ�ɻ�ɱ����", true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243, Types.Crewmate, "��ʹ�ùܵ�", false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244, Types.Crewmate, "ӵ���ڹ���Ұ", false, spySpawnRate);

            portalmakerSpawnRate = CustomOption.Create(390, Types.Crewmate, cs(Portalmaker.color, "���ŵ�����"), rates, null, true);
            portalmakerCooldown = CustomOption.Create(391, Types.Crewmate, "����������ȴ", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerUsePortalCooldown = CustomOption.Create(392, Types.Crewmate, "ʹ��������ȴ", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerLogOnlyColorType = CustomOption.Create(393, Types.Crewmate, "������־ֻ��ʾ��ɫ����", true, portalmakerSpawnRate);
            portalmakerLogHasTime = CustomOption.Create(394, Types.Crewmate, "������־��¼ʹ��ʱ��", true, portalmakerSpawnRate);
            portalmakerCanPortalFromAnywhere = CustomOption.Create(395, Types.Crewmate, "�ɴ��κεط��������Լ����õĴ�����", true, portalmakerSpawnRate);

            securityGuardSpawnRate = CustomOption.Create(280, Types.Crewmate, cs(SecurityGuard.color, "����"), rates, null, true);
            securityGuardCooldown = CustomOption.Create(281, Types.Crewmate, "������ȴ", 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardTotalScrews = CustomOption.Create(282, Types.Crewmate, "����ӵ����˿��", 7f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamPrice = CustomOption.Create(283, Types.Crewmate, "���ü��������˿��", 2f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardVentPrice = CustomOption.Create(284, Types.Crewmate, "�����ܵ�������˿��", 1f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamDuration = CustomOption.Create(285, Types.Crewmate, "�������ܳ���ʱ��", 10f, 2.5f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardCamMaxCharges = CustomOption.Create(286, Types.Crewmate, "��˿��������", 5f, 1f, 30f, 1f, securityGuardSpawnRate);
            securityGuardCamRechargeTasksNumber = CustomOption.Create(287, Types.Crewmate, "��������������", 3f, 1f, 10f, 1f, securityGuardSpawnRate);
            securityGuardNoMove = CustomOption.Create(288, Types.Crewmate, "�����ʱ�޷��ƶ�", true, securityGuardSpawnRate);

            mediumSpawnRate = CustomOption.Create(360, Types.Crewmate, cs(Medium.color, "ͨ��ʦ"), rates, null, true);
            mediumCooldown = CustomOption.Create(361, Types.Crewmate, "ͨ����ȴ", 30f, 5f, 120f, 5f, mediumSpawnRate);
            mediumDuration = CustomOption.Create(362, Types.Crewmate, "ͨ������ʱ��", 3f, 0f, 15f, 1f, mediumSpawnRate);
            mediumOneTimeUse = CustomOption.Create(363, Types.Crewmate, "ÿ�����ֻ�ܱ�ͨ��һ��", false, mediumSpawnRate);
            mediumChanceAdditionalInfo = CustomOption.Create(364, Types.Crewmate, "�ش����������Ϣ�Ŀ�����", rates, mediumSpawnRate);

            jumperSpawnRate = CustomOption.Create(9050, Types.Crewmate, cs(Jumper.color, "����ʦ"), rates, null, true);
            jumperJumpTime = CustomOption.Create(9051, Types.Crewmate, "����ʦ��ȴ", 30, 0, 60, 5, jumperSpawnRate);
            jumperChargesOnPlace = CustomOption.Create(9052, Types.Crewmate, "ÿ������/�������ĵ���", 1, 1, 10, 1, jumperSpawnRate);
            //       jumperResetPlaceAfterMeeting = CustomOption.Create(9052, Types.Crewmate, "Reset Places After Meeting", true, jumperSpawnRate);
            //       jumperChargesGainOnMeeting = CustomOption.Create(9053, Types.Crewmate, "Charges Gained After Meeting", 2, 0, 10, 1, jumperSpawnRate);
            //jumperMaxCharges = CustomOption.Create(9054, Types.Crewmate, "Maximum Charges", 3, 0, 10, 1, jumperSpawnRate);

            bodyGuardSpawnRate = CustomOption.Create(8820, Types.Crewmate, cs(BodyGuard.color, "����"), rates, null, true);
            bodyGuardResetTargetAfterMeeting = CustomOption.Create(8821, Types.Crewmate, "��������ñ���Ŀ��", true, bodyGuardSpawnRate);
            bodyGuardFlash = CustomOption.Create(8822, Types.Crewmate, "����ʱ����", true, bodyGuardSpawnRate);

            thiefSpawnRate = CustomOption.Create(400, Types.Neutral, cs(Thief.color, "�������"), rates, null, true);
            thiefCooldown = CustomOption.Create(401, Types.Neutral, "��ȡ��ȴ", 30f, 5f, 120f, 5f, thiefSpawnRate);
            thiefCanKillSheriff = CustomOption.Create(402, Types.Neutral, "����������Ի�ɱ����", true, thiefSpawnRate);
            thiefHasImpVision = CustomOption.Create(403, Types.Neutral, "�������ӵ��αװ����Ұ", true, thiefSpawnRate);
            thiefCanUseVents = CustomOption.Create(404, Types.Neutral, "�����������ʹ�ùܵ�", true, thiefSpawnRate);
            thiefCanStealWithGuess = CustomOption.Create(405, Types.Neutral, "���������ͨ���²���ȡ��ݣ��Ĺ�ģʽ��", false, thiefSpawnRate);



            juggernautSpawnRate = CustomOption.Create(10101, Types.Neutral, cs(Juggernaut.color, "����"), rates, null, true);
            juggernautCooldown = CustomOption.Create(10102, Types.Neutral, "��ɱ��ȴ", 27.5f, 2.5f, 60f, 2.5f, juggernautSpawnRate);
            juggernautHasImpVision = CustomOption.Create(10103, Types.Neutral, "����ӵ��αװ����Ұ", true, juggernautSpawnRate);
            juggernautReducedkillEach = CustomOption.Create(10104, Types.Neutral, "ÿ�λ�ɱ����ٵ�cd", 5f, 2.5f, 10f, 2.5f, juggernautSpawnRate);

            /*
           public static CustomOption doomsayerSpawnRate;
        public static CustomOption doomsayerCooldown;
        public static CustomOption doomsayerHasMultipleShotsPerMeeting;
        public static CustomOption doomsayerShowInfoInGhostChat;
        public static CustomOption doomsayerCanGuessNeutral;
        public static CustomOption doomsayerCanGuessImpostor;
        public static CustomOption doomsayerGuesserCantGuessSnitch;
        public static CustomOption doomsayerkillToWin;
                        guesserSpawnRate = CustomOption.Create(310, Types.Crewmate, cs(Guesser.color, "�Ĺ�"), rates, null, true);
            guesserNumberOfShots = CustomOption.Create(311, Types.Crewmate, "�ɲ²����", 5f, 1f, 15f, 1f, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(312, Types.Crewmate, "ͬһ�ֻ���ɶ�β²�", true, guesserSpawnRate);
            guesserShowInfoInGhostChat = CustomOption.Create(313, Types.Crewmate, "���ɼ��²���", true, guesserSpawnRate);
            guesserKillsThroughShield = CustomOption.Create(314, Types.Crewmate, "�²����ӷ�ҽ���ܱ���", false, guesserSpawnRate);
             */

            doomsayerSpawnRate = CustomOption.Create(10111, Types.Neutral, cs(Doomsayer.color, "ĩ��Ԥ�Լ�"), rates, null, true);
            doomsayerCooldown = CustomOption.Create(10112, Types.Neutral, "������ȴ", 27.5f, 2.5f, 60f, 2.5f, doomsayerSpawnRate);
            doomsayerHasMultipleShotsPerMeeting = CustomOption.Create(10113, Types.Neutral, "ͬһ�ֻ���ɶ�β²�", true, doomsayerSpawnRate);
            doomsayerShowInfoInGhostChat = CustomOption.Create(10114, Types.Neutral, "���ɼ��²���", true, doomsayerSpawnRate);
            doomsayerCanGuessNeutral = CustomOption.Create(10115, Types.Neutral, "���Բ²�����", true, doomsayerSpawnRate);
            doomsayerCanGuessImpostor = CustomOption.Create(10116, Types.Neutral, "���Բ²��ڹ�", true, doomsayerSpawnRate);
            doomsayerkillToWin = CustomOption.Create(10117, Types.Neutral, "��Ҫ�ɹ��²⼸�λ�ʤ", 3f,1f,10f,1f, doomsayerSpawnRate);


            trapperSpawnRate = CustomOption.Create(410, Types.Crewmate, cs(Trapper.color, "����ʦ"), rates, null, true);
            trapperCooldown = CustomOption.Create(420, Types.Crewmate, "������ȴ", 30f, 5f, 120f, 5f, trapperSpawnRate);
            trapperMaxCharges = CustomOption.Create(440, Types.Crewmate, "���������", 5f, 1f, 15f, 1f, trapperSpawnRate);
            trapperRechargeTasksNumber = CustomOption.Create(450, Types.Crewmate, "��������������", 2f, 1f, 15f, 1f, trapperSpawnRate);
            trapperTrapNeededTriggerToReveal = CustomOption.Create(451, Types.Crewmate, "�����ṩ��Ϣ���败������", 3f, 2f, 10f, 1f, trapperSpawnRate);
            trapperAnonymousMap = CustomOption.Create(452, Types.Crewmate, "��ʾ������ͼ", false, trapperSpawnRate);
            trapperInfoType = CustomOption.Create(453, Types.Crewmate, "������Ϣ����", new string[] { "ְҵ", "����/а��", "����" }, trapperSpawnRate);
            trapperTrapDuration = CustomOption.Create(454, Types.Crewmate, "�������嶨��ʱ��", 5f, 1f, 15f, 1f, trapperSpawnRate);

            // Modifier (1000 - 1999)
            modifiersAreHidden = CustomOption.Create(1009, Types.Modifier, cs(Color.yellow, "�����ն�������ʱ����Ч���ĸ�ְҵ"), true, null, true);

            modifierDisperser = CustomOption.Create(200220, Types.Modifier, cs(Color.red, "��ɢ��"), rates, null, true);

            modifierBloody = CustomOption.Create(1000, Types.Modifier, cs(Color.yellow, "��Ѫ��"), rates, null, true);
            modifierBloodyQuantity = CustomOption.Create(1001, Types.Modifier, cs(Color.yellow, "��Ѫ����"), ratesModifier, modifierBloody);
            modifierBloodyDuration = CustomOption.Create(1002, Types.Modifier, "Ѫ������ʱ��", 10f, 3f, 60f, 1f, modifierBloody);

            modifierAntiTeleport = CustomOption.Create(1010, Types.Modifier, cs(Color.yellow, "ͨѶ��"), rates, null, true);
            modifierAntiTeleportQuantity = CustomOption.Create(1011, Types.Modifier, cs(Color.yellow, "ͨѶ������"), ratesModifier, modifierAntiTeleport);

            modifierTieBreaker = CustomOption.Create(1020, Types.Modifier, cs(Color.yellow, "��ƽ��"), rates, null, true);

            modifierBait = CustomOption.Create(1030, Types.Modifier, cs(Color.yellow, "�ն�"), rates, null, true);
            modifierBaitQuantity = CustomOption.Create(1031, Types.Modifier, cs(Color.yellow, "�ն�����"), ratesModifier, modifierBait);
            modifierBaitReportDelayMin = CustomOption.Create(1032, Types.Modifier, "�ն������ӳ�ʱ��(��С)", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitReportDelayMax = CustomOption.Create(1033, Types.Modifier, "�ն������ӳ�ʱ��(���)", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitShowKillFlash = CustomOption.Create(1034, Types.Modifier, "���������⾯ʾ����", true, modifierBait);

            modifierLover = CustomOption.Create(1040, Types.Modifier, cs(Color.yellow, "����"), rates, null, true);
            modifierLoverImpLoverRate = CustomOption.Create(1041, Types.Modifier, "���������ڹ�ĸ���", rates, modifierLover);
            modifierLoverBothDie = CustomOption.Create(1042, Types.Modifier, "����ͬ������", true, modifierLover);
            modifierLoverEnableChat = CustomOption.Create(1043, Types.Modifier, "����˽����������Ƶ��", true, modifierLover);

            modifierSunglasses = CustomOption.Create(1050, Types.Modifier, cs(Color.yellow, "̫����"), rates, null, true);
            modifierSunglassesQuantity = CustomOption.Create(1051, Types.Modifier, cs(Color.yellow, "̫��������"), ratesModifier, modifierSunglasses);
            modifierSunglassesVision = CustomOption.Create(1052, Types.Modifier, "̫��������Ұ", new string[] { "-10%", "-20%", "-30%", "-40%", "-50%" }, modifierSunglasses);

            modifierTorch = CustomOption.Create(1053, Types.Modifier, cs(Color.yellow, "���"), rates, null, true);
            modifierTorchQuantity = CustomOption.Create(1054, Types.Modifier, cs(Color.yellow, "�������"), ratesModifier, modifierTorch);

            modifierMultitasker = CustomOption.Create(10523233, Types.Modifier, cs(Color.yellow, "���߳�"), rates, null, true);
            modifierMultitaskerQuantity = CustomOption.Create(10232354, Types.Modifier, cs(Color.yellow, "���߳�����"), ratesModifier, modifierMultitasker);

            modifierMini = CustomOption.Create(1061, Types.Modifier, cs(Color.yellow, "С��"), rates, null, true);
            modifierMiniGrowingUpDuration = CustomOption.Create(1062, Types.Modifier, "С����������ʱ��", 400f, 100f, 1500f, 100f, modifierMini);
            modifierMiniGrowingUpInMeeting = CustomOption.Create(1063, Types.Modifier, "С�������ڼ������", true, modifierMini);

            modifierIndomitable = CustomOption.Create(1276, Types.Modifier, cs(Color.yellow, "��η"), rates, null, true);

            modifierBlind = CustomOption.Create(8810, Types.Modifier, cs(Color.yellow, "��С��"), rates, null, true);

            modifierWatcher = CustomOption.Create(10401, Types.Modifier, cs(Color.yellow, "������"), rates, null, true);

            modifierRadar = CustomOption.Create(1040122, Types.Modifier, cs(Color.yellow, "�״�"), rates, null, true);

            modifierTunneler = CustomOption.Create(8819, Types.Modifier, cs(Color.yellow, "�ܵ�����ʦ"), rates, null, true);

            modifierSlueth = CustomOption.Create(8830, Types.Modifier, cs(Color.yellow, "����Ա"), rates, null, true);

            modifierCursed = CustomOption.Create(1277, Types.Modifier, cs(Color.yellow, "����"), rates, null, true);

            modifierVip = CustomOption.Create(1070, Types.Modifier, cs(Color.yellow, "VIP"), rates, null, true);
            modifierVipQuantity = CustomOption.Create(1071, Types.Modifier, cs(Color.yellow, "VIP����"), ratesModifier, modifierVip);
            modifierVipShowColor = CustomOption.Create(1072, Types.Modifier, "����ʱȫ����ʾ��Ӫ��ɫ", true, modifierVip);

            modifierInvert = CustomOption.Create(1080, Types.Modifier, cs(Color.yellow, "�ƹ�"), rates, null, true);
            modifierInvertQuantity = CustomOption.Create(1081, Types.Modifier, cs(Color.yellow, "�ƹ�����"), ratesModifier, modifierInvert);
            modifierInvertDuration = CustomOption.Create(1082, Types.Modifier, "���״̬����������", 3f, 1f, 15f, 1f, modifierInvert);

            modifierChameleon = CustomOption.Create(1090, Types.Modifier, cs(Color.yellow, "��ɫ��"), rates, null, true);
            modifierChameleonQuantity = CustomOption.Create(1091, Types.Modifier, cs(Color.yellow, "��ɫ������"), ratesModifier, modifierChameleon);
            modifierChameleonHoldDuration = CustomOption.Create(1092, Types.Modifier, "�Ӳ�������ɫ��ʼ�ļ��ʱ��", 3f, 1f, 10f, 0.5f, modifierChameleon);
            modifierChameleonFadeDuration = CustomOption.Create(1093, Types.Modifier, "��ɫ���̳���ʱ��", 1f, 0.25f, 10f, 0.25f, modifierChameleon);
            modifierChameleonMinVisibility = CustomOption.Create(1094, Types.Modifier, "���͸����", new string[] { "0%", "10%", "20%", "30%", "40%", "50%" }, modifierChameleon);

            modifierShifter = CustomOption.Create(1100, Types.Modifier, cs(Color.yellow, "����ʦ"), rates, null, true);

            // Guesser Gamemode (2000 - 2999)
            guesserGamemodeCrewNumber = CustomOption.Create(2001, Types.Guesser, cs(Guesser.color, "��Ա�Ĺ�����"), 15f, 1f, 15f, 1f, null, true);
            guesserGamemodeNeutralNumber = CustomOption.Create(2002, Types.Guesser, cs(Guesser.color, "�����Ĺ�����"), 15f, 1f, 15f, 1f, null, true);
            guesserGamemodeImpNumber = CustomOption.Create(2003, Types.Guesser, cs(Guesser.color, "αװ�߶Ĺ�����"), 15f, 1f, 15f, 1f, null, true);
            guesserForceJackalGuesser = CustomOption.Create(2007, Types.Guesser, "ǿ�Ʋ���Ϊ�Ĺ�", false, null, true);
            guesserForceThiefGuesser = CustomOption.Create(2011, Types.Guesser, "ǿ���������Ϊ�Ĺ�", false, null, true);
            guesserGamemodeHaveModifier = CustomOption.Create(2004, Types.Guesser, "�Ĺֿ�ӵ�и���ְҵ", true, null);
            guesserGamemodeNumberOfShots = CustomOption.Create(2005, Types.Guesser, "�²����", 3f, 1f, 15f, 1f, null);
            guesserGamemodeHasMultipleShotsPerMeeting = CustomOption.Create(2006, Types.Guesser, "ͬһ����������²�", false, null);
            guesserGamemodeKillsThroughShield = CustomOption.Create(2008, Types.Guesser, "�²����ӷ�ҽ���ܱ���", true, null);
            guesserGamemodeEvilCanKillSpy = CustomOption.Create(2009, Types.Guesser, "а��Ĺֿɲ²��Ե�", true, null);
            guesserGamemodeCantGuessSnitchIfTaksDone = CustomOption.Create(2010, Types.Guesser, "�Ĺֲ��ܶ��������ĸ�����", true, null);

            // Hide N Seek Gamemode (3000 - 3999)
            hideNSeekMap = CustomOption.Create(3020, Types.HideNSeekMain, cs(Color.yellow, "��ɱģʽ��ͼ"), new string[] { "The Skeld", "Mira", "Polus", "Airship", "Fungle", "Submerged", "LI Map" }, null, true, onChange: () => { int map = hideNSeekMap.selection; if (map >= 3) map++; GameOptionsManager.Instance.currentNormalGameOptions.MapId = (byte)map; });
            hideNSeekHunterCount = CustomOption.Create(3000, Types.HideNSeekMain, cs(Color.yellow, "��������"), 1f, 1f, 3f, 1f);
            hideNSeekKillCooldown = CustomOption.Create(3021, Types.HideNSeekMain, cs(Color.yellow, "��ɱ��ȴ"), 10f, 2.5f, 60f, 2.5f);
            hideNSeekHunterVision = CustomOption.Create(3001, Types.HideNSeekMain, cs(Color.yellow, "������Ұ"), 0.5f, 0.25f, 2f, 0.25f);
            hideNSeekHuntedVision = CustomOption.Create(3002, Types.HideNSeekMain, cs(Color.yellow, "������Ұ"), 2f, 0.25f, 5f, 0.25f);
            hideNSeekCommonTasks = CustomOption.Create(3023, Types.HideNSeekMain, cs(Color.yellow, "��ͨ������"), 1f, 0f, 4f, 1f);
            hideNSeekShortTasks = CustomOption.Create(3024, Types.HideNSeekMain, cs(Color.yellow, "��������"), 3f, 1f, 23f, 1f);
            hideNSeekLongTasks = CustomOption.Create(3025, Types.HideNSeekMain, cs(Color.yellow, "��������"), 3f, 0f, 15f, 1f);
            hideNSeekTimer = CustomOption.Create(3003, Types.HideNSeekMain, cs(Color.yellow, "��Ϸʱ��"), 5f, 1f, 30f, 0.5f);
            hideNSeekTaskWin = CustomOption.Create(3004, Types.HideNSeekMain, cs(Color.yellow, "�������������ʤ"), false);
            hideNSeekTaskPunish = CustomOption.Create(3017, Types.HideNSeekMain, cs(Color.yellow, "�������һ�������ʱ������"), 10f, 0f, 30f, 1f);
            hideNSeekCanSabotage = CustomOption.Create(3019, Types.HideNSeekMain, cs(Color.yellow, "���˿����ƻ�"), false);
            hideNSeekHunterWaiting = CustomOption.Create(3022, Types.HideNSeekMain, cs(Color.yellow, "��Ϸ��ʼʱ���˵ȴ�ʱ��"), 15f, 2.5f, 60f, 2.5f);

            hunterLightCooldown = CustomOption.Create(3005, Types.HideNSeekRoles, cs(Color.red, "���˿�����ȴ"), 30f, 5f, 60f, 1f, null, true);
            hunterLightDuration = CustomOption.Create(3006, Types.HideNSeekRoles, cs(Color.red, "���˿��Ƴ���ʱ��"), 5f, 1f, 60f, 1f);
            hunterLightVision = CustomOption.Create(3007, Types.HideNSeekRoles, cs(Color.red, "���˿�����Ұ"), 3f, 1f, 5f, 0.25f);
            hunterLightPunish = CustomOption.Create(3008, Types.HideNSeekRoles, cs(Color.red, "���˿���ʱ������"), 5f, 0f, 30f, 1f);
            hunterAdminCooldown = CustomOption.Create(3009, Types.HideNSeekRoles, cs(Color.red, "���˹ۿ������ͼ��ȴ"), 30f, 5f, 60f, 1f);
            hunterAdminDuration = CustomOption.Create(3010, Types.HideNSeekRoles, cs(Color.red, "���˿ɹۿ������ͼʱ��"), 5f, 1f, 60f, 1f);
            hunterAdminPunish = CustomOption.Create(3011, Types.HideNSeekRoles, cs(Color.red, "���˹ۿ������ͼ��ʱ������"), 5f, 0f, 30f, 1f);
            hunterArrowCooldown = CustomOption.Create(3012, Types.HideNSeekRoles, cs(Color.red, "���˿�����ͷ��ȴ"), 30f, 5f, 60f, 1f);
            hunterArrowDuration = CustomOption.Create(3013, Types.HideNSeekRoles, cs(Color.red, "���˿�����ͷ����ʱ��"), 5f, 0f, 60f, 1f);
            hunterArrowPunish = CustomOption.Create(3014, Types.HideNSeekRoles, cs(Color.red, "���˿�����ͷ��ʱ������"), 5f, 0f, 30f, 1f);

            huntedShieldCooldown = CustomOption.Create(3015, Types.HideNSeekRoles, cs(Color.gray, "���￪��������ȴ"), 30f, 5f, 60f, 1f, null, true);
            huntedShieldDuration = CustomOption.Create(3016, Types.HideNSeekRoles, cs(Color.gray, "���ﻤ�ܳ���ʱ��"), 5f, 1f, 60f, 1f);
            huntedShieldRewindTime = CustomOption.Create(3018, Types.HideNSeekRoles, cs(Color.gray, "���ﻤ�ܻ���ʱ��"), 3f, 1f, 10f, 1f);
            huntedShieldNumber = CustomOption.Create(3026, Types.HideNSeekRoles, cs(Color.gray, "���ﻤ��ʹ�ô���"), 3f, 1f, 15f, 1f);

            // Prop Hunt General Options
            propHuntMap = CustomOption.Create(4020, Types.PropHunt, cs(Color.yellow, "��èèģʽ��ͼ"), new string[] { "The Skeld", "Mira", "Polus", "Airship", "Fungle", "Submerged", "LI Map" }, null, true, onChange: () => { int map = propHuntMap.selection; if (map >= 3) map++; GameOptionsManager.Instance.currentNormalGameOptions.MapId = (byte)map; });
            propHuntTimer = CustomOption.Create(4021, Types.PropHunt, cs(Color.yellow, "���ٶ��ʱ��"), 5f, 1f, 30f, 0.5f);
            propHuntUnstuckCooldown = CustomOption.Create(4011, Types.PropHunt, cs(Color.yellow, "��ǽ��ȴʱ��"), 30f, 2.5f, 60f, 2.5f);
            propHuntUnstuckDuration = CustomOption.Create(4012, Types.PropHunt, cs(Color.yellow, "��ǽ����ʱ��"), 2f, 1f, 60f, 1f);
            propHunterVision = CustomOption.Create(4006, Types.PropHunt, cs(Color.yellow, "������Ұ"), 0.5f, 0.25f, 2f, 0.25f);
            propVision = CustomOption.Create(4007, Types.PropHunt, cs(Color.yellow, "�������Ұ"), 2f, 0.25f, 5f, 0.25f);
            // Hunter Options
            propHuntNumberOfHunters = CustomOption.Create(4000, Types.PropHunt, cs(Color.red, "��������"), 1f, 1f, 5f, 1f, null, true);
            hunterInitialBlackoutTime = CustomOption.Create(4001, Types.PropHunt, cs(Color.red, "���˿��ֵȴ�ʱ��"), 10f, 5f, 20f, 1f);
            hunterMissCooldown = CustomOption.Create(4004, Types.PropHunt, cs(Color.red, "�����ɱ�����ȴ�ͷ�"), 10f, 2.5f, 60f, 2.5f);
            hunterHitCooldown = CustomOption.Create(4005, Types.PropHunt, cs(Color.red, "�ɹ���ɱ�����ȴ����"), 10f, 2.5f, 60f, 2.5f);
            propHuntRevealCooldown = CustomOption.Create(4008, Types.PropHunt, cs(Color.red, "������ȴʱ��"), 30f, 10f, 90f, 2.5f);
            propHuntRevealDuration = CustomOption.Create(4009, Types.PropHunt, cs(Color.red, "���γ���ʱ��"), 5f, 1f, 60f, 1f);
            propHuntRevealPunish = CustomOption.Create(4010, Types.PropHunt, cs(Color.red, "����ʱ��ͷ�"), 10f, 0f, 1800f, 5f);
            propHuntAdminCooldown = CustomOption.Create(4022, Types.PropHunt, cs(Color.red, "���˲鿴�����ͼ��ȴʱ��"), 30f, 2.5f, 1800f, 2.5f);
            propHuntFindCooldown = CustomOption.Create(4023, Types.PropHunt, cs(Color.red, "��Ѱ��ȴʱ��"), 60f, 2.5f, 1800f, 2.5f);
            propHuntFindDuration = CustomOption.Create(4024, Types.PropHunt, cs(Color.red, "��Ѱ����ʱ��"), 5f, 1f, 15f, 1f);
            // Prop Options
            propBecomesHunterWhenFound = CustomOption.Create(4003, Types.PropHunt, cs(Palette.CrewmateBlue, "����߱����ֺ�ת��Ϊ����"), false, null, true);
            propHuntInvisEnabled = CustomOption.Create(4013, Types.PropHunt, cs(Palette.CrewmateBlue, "������������"), true, null, true);
            propHuntInvisCooldown = CustomOption.Create(4014, Types.PropHunt, cs(Palette.CrewmateBlue, "������ȴ"), 120f, 10f, 1800f, 2.5f, propHuntInvisEnabled);
            propHuntInvisDuration = CustomOption.Create(4015, Types.PropHunt, cs(Palette.CrewmateBlue, "�������ʱ��"), 5f, 1f, 30f, 1f, propHuntInvisEnabled);
            propHuntSpeedboostEnabled = CustomOption.Create(4016, Types.PropHunt, cs(Palette.CrewmateBlue, "���ü�������"), true, null, true);
            propHuntSpeedboostCooldown = CustomOption.Create(4017, Types.PropHunt, cs(Palette.CrewmateBlue, "������ȴ"), 60f, 2.5f, 1800f, 2.5f, propHuntSpeedboostEnabled);
            propHuntSpeedboostDuration = CustomOption.Create(4018, Types.PropHunt, cs(Palette.CrewmateBlue, "���ܳ���ʱ��"), 5f, 1f, 15f, 1f, propHuntSpeedboostEnabled);
            propHuntSpeedboostSpeed = CustomOption.Create(4019, Types.PropHunt, cs(Palette.CrewmateBlue, "�����ٶ�����"), 2f, 1.25f, 5f, 0.25f, propHuntSpeedboostEnabled);



            // Other options
            maxNumberOfMeetings = CustomOption.Create(3, Types.General, "�����������ȥ�г�Զ��������", 10, 0, 15, 1, null, true);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4, Types.General, "�����ֹ����", false);
            noVoteIsSelfVote = CustomOption.Create(5, Types.General, "��ͶƱĬ��Ͷ�Լ�", false, blockSkippingInEmergencyMeetings);
            hidePlayerNames = CustomOption.Create(6, Types.General, "�����������", false);
            allowParallelMedBayScans = CustomOption.Create(7, Types.General, "����ͬʱ����ˮ", false);
            shieldFirstKill = CustomOption.Create(8, Types.General, "�׵�����", false);
            hideOutOfSightNametags = CustomOption.Create(6006, Types.General, "�������谭���������", false);
            hideVentAnimOnShadows = CustomOption.Create(822445, Types.General, "���Բ�����Ұ��������Ҳ��Źܵ�����", false);
            finishTasksBeforeHauntingOrZoomingOut = CustomOption.Create(9, Types.General, "δ�����������ǰ��겻��ʹ�ø��漰ǧ����", true);
            camsNightVision = CustomOption.Create(11, Types.General, "Ϩ��ʱ��ؿ���ҹ��ģʽ", false, null, true);
            camsNoNightVisionIfImpVision = CustomOption.Create(12, Types.General, "�ڹ����Ӽ�ص�ҹ��ģʽ", false, camsNightVision, false);
            impostorSeeRoles = CustomOption.Create(9, Types.General, "�ڹ�ɼ�����ְҵ", false);
            transparentTasks = CustomOption.Create(814142, Types.General, "�������͸��", false);
            dynamicMap = CustomOption.Create(500, Types.General, "�����ͼ", false, null, true);
            dynamicMapEnableSkeld = CustomOption.Create(501, Types.General, "Skeld", rates, dynamicMap, false);
            dynamicMapEnableMira = CustomOption.Create(502, Types.General, "Mira", rates, dynamicMap, false);
            dynamicMapEnablePolus = CustomOption.Create(503, Types.General, "Polus", rates, dynamicMap, false);
            dynamicMapEnableAirShip = CustomOption.Create(504, Types.General, "Airship", rates, dynamicMap, false);
            dynamicMapEnableFungle = CustomOption.Create(506, Types.General, "Fungle", rates, dynamicMap, false);
            dynamicMapEnableSubmerged = CustomOption.Create(505, Types.General, "Submerged", rates, dynamicMap, false);
            dynamicMapSeparateSettings = CustomOption.Create(509, Types.General, "ʹ�������ͼԤ��", false, dynamicMap, false);
            enableBetterPolus = CustomOption.Create(7878, Types.General, "���õ�Polus��ͼ", false, null, false);
            movePolusVents = CustomOption.Create(7879, Types.General, "�ܵ�����", false, enableBetterPolus, false);
            movePolusVitals = CustomOption.Create(7880, Types.General, "����������ƶ���ʵ����", false, enableBetterPolus, false);
            swapNavWifi = CustomOption.Create(7881, Types.General, "����WIFI�뵼������λ�ý���", false, enableBetterPolus, false);
            moveColdTemp = CustomOption.Create(7882, Types.General, "�¶ȵ��������ƶ���������·�", false, enableBetterPolus, false);
            enableCamoComms = CustomOption.Create(1105, Types.General, "ͨ���ƻ�����С����ģʽ", false, null, false);
            disableMedbayWalk = CustomOption.Create(8847, Types.General, "���񶯻����ɼ�", false, null, false);
            restrictDevices = CustomOption.Create(1101, Types.General, "���Ƶ�ͼ��Ϣ�豸ʹ��", new string[] { "��", "ÿһ�غ�", "ÿ����Ϸ" }, null, false);
            //restrictAdmin = CustomOption.Create(1102, Types.General, "Restrict Admin Table", 30f, 0f, 600f, 5f, restrictDevices);
            restrictCameras = CustomOption.Create(1103, Types.General, "���Ƽ�عۿ�ʱ��", 30f, 0f, 600f, 5f, restrictDevices);
            restrictVents = CustomOption.Create(1104, Types.General, "������������ǹۿ�ʱ��", 30f, 0f, 600f, 5f, restrictDevices);
            disableCamsRound1 = CustomOption.Create(8834, Types.General, "��һ�غ��޷������", false, null, false);
            showButtonTarget = CustomOption.Create(9994, Types.General, "�ڼ��ܰ�ť����ʾĿ�����", true);
            blockGameEnd = CustomOption.Create(9995, Types.General, "ǿ��ְҵ�ڳ���Ϸ����", false);
            randomGameStartPosition = CustomOption.Create(9041, Types.General, "���������", false);
            allowModGuess = CustomOption.Create(9043, Types.General, "����²ⲿ�ָ�ְҵ", false);



            blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
            blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
            blockedRolePairings.Add((byte)RoleId.Spy, new [] { (byte)RoleId.Mini});
            blockedRolePairings.Add((byte)RoleId.Mini, new [] { (byte)RoleId.Spy});
            blockedRolePairings.Add((byte)RoleId.Vulture, new [] { (byte)RoleId.Cleaner});
            blockedRolePairings.Add((byte)RoleId.Cleaner, new [] { (byte)RoleId.Vulture});

            blockedRolePairings.Add((byte)RoleId.Mayor, new [] { (byte)RoleId.Watcher});
            blockedRolePairings.Add((byte)RoleId.Watcher, new [] { (byte)RoleId.Mayor});
            blockedRolePairings.Add((byte)RoleId.Engineer, new [] { (byte)RoleId.Tunneler});
            blockedRolePairings.Add((byte)RoleId.Tunneler, new [] { (byte)RoleId.Engineer});
            blockedRolePairings.Add((byte)RoleId.Bomber2, new [] { (byte)RoleId.Bait});
            blockedRolePairings.Add((byte)RoleId.Bait, new [] { (byte)RoleId.Bomber2});
            
        }
    }
}
