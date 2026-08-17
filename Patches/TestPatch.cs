using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using HarmonyLib;
using Random = UnityEngine.Random;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace BerryAP.Patches
{
   ///  Test patch : replacing Berry Buddy names. Did this to test my understanding of Harmony prefix + no return patching.
    [HarmonyPatch(typeof(CultistNameGenerator), nameof(CultistNameGenerator.PickARandomName))]
    public class CultistNameGeneratorPatch
    {
        [HarmonyPrefix]
        public static bool Prefix(ref string __result)
        {

            string[] nameBank = new string[] { "Test_Name_1", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
                             , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
                             , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25", "Test_Name_26", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
                             , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
                             , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
                             , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
                             , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
                             , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
                             , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
                             , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
                             , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
                             , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
                             , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
                             , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
                             , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
                             , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
                             , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
                             , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
                             , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
                             , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
                             , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
                             , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
                             , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
                             , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
                             , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25" };
            int num = Random.Range(0, nameBank.Length);
            __result = nameBank[num];
            return false;
        }
        //{
        //    [HarmonyPatch(typeof(CultistNameGenerator))]
        //    internal class CultistNameGeneratorPatch
        //    {
        //    [HarmonyPatch(typeof(CultistNameGenerator), nameof(CultistNameGenerator.PickARandomName))]
        //    [HarmonyPrefix]
        //    private static bool ChangeCultistNames()
        //    {
        //        string[] nameBank = [ "Test_Name_1", "Test_Name_2", "Test_Name_3", "Test_Name_4", "Test_Name_5", "Test_Name_6", "Test_Name_7", "Test_Name_8"
        //                     , "Test_Name_9", "Test_Name_10", "Test_Name_11", "Test_Name_12", "Test_Name_13", "Test_Name_14", "Test_Name_15", "Test_Name_16", "Test_Name_17"
        //                     , "Test_Name_18", "Test_Name_19", "Test_Name_20", "Test_Name_21", "Test_Name_22", "Test_Name_23", "Test_Name_24", "Test_Name_25", "Test_Name_26"];
        //        int num = Random.Range(0, nameBank.Length);
        //        return nameBank[num];
        //        return false;
        //    }
        //}
    }
}