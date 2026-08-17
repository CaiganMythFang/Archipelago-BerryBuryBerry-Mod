using System;
using System.Collections.Generic;
using System.Text;
using BerryAP.Managers;
using HarmonyLib;

namespace BerryAP.Patches
{
    [HarmonyPatch(typeof(BreakableWall), "BreakWall")]
    class BreakableWallPatch
    {
        public static bool Prefix(BreakableWall __instance)
        {
            /// Debug code : sending data to console log
            Plugin.Log("Wall Broken [" + __instance + "]!");
            var name = __instance.name.ToString();
            //Plugin.Log("Sending prop name" + name + "to Data Manager");
            DataManager.wall_list = DataManager.wall_list + "\n" + name;
            //Plugin.Log("Naming out prop list");
            Plugin.Log(DataManager.wall_list);
            return true;
        }
    }
}
