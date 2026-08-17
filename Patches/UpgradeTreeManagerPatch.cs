using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace BerryAP.Patches
{
    [HarmonyPatch(typeof(UpgradeTreeManager), "UnlockUpgrade")]
    public class UpgradeTreeManagerPatch
    {

        public static bool Prefix(UpgradeTreeManager __instance, UpgradeTreeButton _upgrade, bool _SetValuesAfter = true)
        {
            
            /// Replacing Upgrade Manager with copy of the code block, adding in debug logs to console to track when they are used for modifying later.

            Plugin.Log("Unlock Manager Received : Unlock" + _upgrade.ToString() + "!");
            if (_upgrade.upgradeIdentity == UpgradeTreeIdentity.NextRoundButton)
            {
                __instance.disableAllInteractionsWithShopButtons = true;
                GameManager.Singleton.InShop_CloseShopAndStartNextRound();
                return false;
            }
            switch (_upgrade.upgradeIdentity)
            {
                case UpgradeTreeIdentity.AdditionalCultist:
                    Plugin.Log("Upgrade : Cultist Buddy Test Log");
                    __instance.additionalCultist_UpgradeLevel++;
                    __instance.SpawnANewCultistFromUpgradeButtonClick(_upgrade.tier);
                    HudManager.Singleton.PlayFeedback_PiggyBankPickUp();
                    break;
                case UpgradeTreeIdentity.GrowthRateUp:
                    Plugin.Log("Upgrade : Growth Rate Up");
                    PlayerStats.Singleton.berryGrowthRate_Multiplier += __instance.growthRate_LevelValues[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.GoldRush_Unlock:
                    Plugin.Log("Upgrade : Berry Rush Unlocked");
                    PlayerStats.Singleton.goldRush_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.GoldRush_Duration:
                    Plugin.Log("Upgrade : Berry Rush Duration");
                    PlayerStats.Singleton.goldRush_Duration_Max += __instance.goldRush_DurationValues[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.GoldRush_Cooldown:
                    Plugin.Log("Upgrade : Berry Rush Cooldown");
                    PlayerStats.Singleton.goldRush_Cooldown_Max -= __instance.goldRush_TimeCooldownValues[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.GoldRush_BonusGrowthRate:
                    Plugin.Log("Upgrade : Berry Rush Bonus Growth");
                    PlayerStats.Singleton.goldRush_BonusGrowthRate += __instance.goldRush_BonusGrowthRateValues[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.BigHole_Unlock:
                    Plugin.Log("Upgrade : Big Hole Unlock");
                    PlayerStats.Singleton.bigHole_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.BigHole_Cooldown:
                    Plugin.Log("Upgrade : Big Hole Cooldown");
                    PlayerStats.Singleton.bigHole_Cooldown_Max -= __instance.bigHole_TimeCooldownValues[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.BigHole_Size:
                    Plugin.Log("Upgrade : Big Hole Size");
                    PlayerStats.Singleton.bigHole_Size += __instance.bigHole_SizeValues[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.Vacuum_Unlock:
                    Plugin.Log("Upgrade : Vaccuum Unlock");
                    PlayerStats.Singleton.vacuum_Unlocked = true;
                    PlayerStats.Singleton.broom_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.Vacuum_Capacity:
                    Plugin.Log("Upgrade : Vaccuum Capacity");
                    PlayerStats.Singleton.vacuumCapacity += __instance.vacuum_CapacityValues[_upgrade.tier];
                    PlayerStats.Singleton.vacShootDowntime_Max -= __instance.vacuum_FireRateIncreasePerUpgrade;
                    break;
                case UpgradeTreeIdentity.Broom_Unlock:
                    Plugin.Log("Upgrade : Broom Unlocked");
                    PlayerStats.Singleton.broom_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.GoldenBerry_SpawnChance:
                    Plugin.Log("Upgrade : Gold Berry Chance");
                    PlayerStats.Singleton.goldenBerryChance_Curr += __instance.goldenBerry_ChanceValues[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.GoldenBerry_Multiplier:
                    Plugin.Log("Upgrade : Gold Berry Multiplier");
                    PlayerStats.Singleton.goldenBerry_ValueMultiplier_Curr += __instance.goldenBerry_MultiplierValues[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.PiggyBank_Unlock:
                    Plugin.Log("Upgrade : Piggy Bank Unlock");
                    PlayerStats.Singleton.piggyBank_Unlocked = true;
                    GameManager.Singleton.prefabBank.piggyBankInScene.SetActive(value: true);
                    break;
                case UpgradeTreeIdentity.PiggyBank_Capacity:
                    Plugin.Log("Upgrade : Piggy Bank Capacity");
                    PlayerStats.Singleton.piggyBank_Limit += __instance.piggyBank_CapacityValues[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.Bush_Upgrade:
                    Plugin.Log("Upgrade : Bush Upgrade");
                    PlayerStats.Singleton.bushUpgrade_Unlocked = true;
                    GameManager.Singleton.prefabBank.plantBed_SpawnedInScene.UpgradeToBush();
                    break;
                case UpgradeTreeIdentity.Tree_Upgrade:
                    Plugin.Log("Upgrade : Tree Upgrade");
                    PlayerStats.Singleton.treeUpgrade_Unlocked = true;
                    GameManager.Singleton.prefabBank.plantBed_SpawnedInScene.UpgradeToTree();
                    break;
                case UpgradeTreeIdentity.ConveyorBelt_Upgrade:
                    Plugin.Log("Upgrade : Conveyor Belt Upgrade");
                    PlayerStats.Singleton.conveyorBelt_Unlocked = true;
                    GameManager.Singleton.prefabBank.conveyorBelt_InScene.SetActive(value: true);
                    break;
                case UpgradeTreeIdentity.BerryPlant_BerryTier_Upgrade:
                    Plugin.Log("Upgrade : Berry Plant Tier Upgrade");
                    GameManager.Singleton.prefabBank.plantBed_SpawnedInScene.ChangeBerryProfile(GameManager.Singleton.prefabBank.berryProfiles[_upgrade.tier]);
                    break;
                case UpgradeTreeIdentity.AutoCoinPickUp_Unlock:
                    Plugin.Log("Upgrade : Auto Coin Pickup Unlock");
                    PlayerStats.Singleton.autoCoinPickup_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.AutoCoinPickUp_Size:
                    Plugin.Log("Upgrade : Auto Coin Pickup Range");
                    PlayerStats.Singleton.autoCoinPickUp_RadiusLevel++;
                    PlayerStats.Singleton.autoCoinPickUp_Radius_Current += PlayerStats.Singleton.autoCoinPickUp_RadiusLevel_Values[PlayerStats.Singleton.autoCoinPickUp_RadiusLevel];
                    break;
                case UpgradeTreeIdentity.CultistCapacity:
                    Plugin.Log("Upgrade : Cultist Capacity");
                    PlayerStats.Singleton.cultistCapacity_Curr += __instance.cultistCapacity_Values[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.HoleMoveJuiceCapacity:
                    Plugin.Log("Upgrade : Hole Distance");
                    PlayerStats.Singleton.holeMoveJuiceCapacity_Curr += __instance.holeMoveJuiceCapacity_Values[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.HoleMoveSpeed:
                    Plugin.Log("Upgrade : Hole Speed");
                    PlayerStats.Singleton.holeMoveSpeed_Curr += __instance.holeMoveSpeed_Values[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.HoleMove_Unlock:
                    Plugin.Log("Upgrade : Hole Move Unlock");
                    PlayerStats.Singleton.holeMove_IsUnlocked = true;
                    break;
                case UpgradeTreeIdentity.BlenderBot_Unlock:
                    Plugin.Log("Upgrade : Chainsaw Unlock");
                    PlayerStats.Singleton.blenderBot_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.RoundTimerIncrease:
                    Plugin.Log("Upgrade : Day Length Increase");
                    PlayerStats.Singleton.roundTimerLength += __instance.roundTimerIncrease_Values[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.StarOrbGen_Unlock:
                    Plugin.Log("Upgrade : Star Orb Generator");
                    PlayerStats.Singleton.starOrbGen_IsUnlocked = true;
                    break;
                case UpgradeTreeIdentity.StarOrbGen_SpawnsPerRound:
                    Plugin.Log("Upgrade : Star Orb Chance");
                    PlayerStats.Singleton.starOrbGen_SpawnsPerRound += __instance.starOrbGen_AmtIncreaseValues[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.BubbleJetpack:
                    Plugin.Log("Upgrade : Bubble Unlock");
                    PlayerStats.Singleton.bubbleJetpack_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.Pinata_Unlock:
                    Plugin.Log("Upgrade : Pinata Unlock");
                    PlayerStats.Singleton.pinata_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.Pinata_ZoneTierUp:
                    Plugin.Log("Upgrade : Pinata Zone Upgrade");
                    PlayerStats.Singleton.pinata_ZoneSpawnTier++;
                    break;
                case UpgradeTreeIdentity.AutoPopStarOrbs_Unlock:
                    Plugin.Log("Upgrade : Auto Star Popper");
                    PlayerStats.Singleton.autoPopStarOrbs_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.Cultist_AddNewBlueBerry:
                    Plugin.Log("First Cultist Buddy Selected");
                    if (GameManager.Singleton.gameState == GameManager.GameState.RoundOverShop)
                    {
                        __instance.SpawnANewCultistFromUpgradeButtonClick(0);
                    }
                    break;
                case UpgradeTreeIdentity.StarWand_Unlock:
                    Plugin.Log("Upgrade : Star Wand Unlock");
                    PlayerStats.Singleton.StarWand_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.SledgeHammer_Unlock:
                    Plugin.Log("Upgrade : Sledgehammer Unlock");
                    PlayerStats.Singleton.SledgeHammer_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.SledgeHammer_TierUp:
                    Plugin.Log("Upgrade : Sledgehammer Strength");
                    PlayerStats.Singleton.SledgeHammer_Tier++;
                    break;
                case UpgradeTreeIdentity.Rewind:
                    Plugin.Log("Upgrade : Rewind");
                    __instance.disableAllInteractionsWithShopButtons = true;
                    GameManager.Singleton.ActivateRewind();
                    break;
                case UpgradeTreeIdentity.PopGun_Unlock:
                    Plugin.Log("Upgrade : Popgun Unlock");
                    PlayerStats.Singleton.popgun_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.BerryPicker_Unlock:
                    Plugin.Log("Upgrade : Berry Picker Unlock");
                    PlayerStats.Singleton.berryPicker_IsUnlocked = true;
                    break;
                case UpgradeTreeIdentity.Juiced_Multiplier:
                    Plugin.Log("Upgrade : JUICED Multiplier");
                    PlayerStats.Singleton.juiced_GrowthMultiplier += __instance.JUICED_MultiplierValues[_upgrade.tier];
                    break;
                case UpgradeTreeIdentity.Trampoline_Unlock:
                    Plugin.Log("Upgrade : Trampoline Unlock");
                    PlayerStats.Singleton.trampoline_Unlocked = true;
                    break;
                case UpgradeTreeIdentity.StarKey_Unlock:
                    Plugin.Log("Upgrade : StarKey Unlock");
                    PlayerStats.Singleton.starKey_Unlocked = true;
                    break;
            }
            if (GameManager.Singleton.gameState == GameManager.GameState.RoundOverShop)
            {
                if (_upgrade.upgradeCostType == UpgradeTreeCostType.Money)
                {
                    PlayerStats.Singleton.SpendMoney(_upgrade.calculatedPrice);
                }
                else if (_upgrade.upgradeCostType == UpgradeTreeCostType.StarOrb)
                {
                    PlayerStats.Singleton.starOrbs -= _upgrade.calculatedPrice;
                }
            }
            _upgrade.OnSuccessfulUnlock();
            if (_SetValuesAfter)
            {
                __instance.SetValuesFromUnlocks();
                SaveLoadManager.Singleton.CheckForAllUpgradesUnlocked_Achievement();
            }

            return false;
        }
    }
}
