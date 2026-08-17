using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace BerryAP.Patches
{
    [HarmonyPatch(typeof(CassettesManager), "PickedUpTape")]
    class CassettesManagerPatch
    {
        public static bool Prefix(CassettesManager __instance, int _index)
        {
            Plugin.Log("Cassette Tape Obtained [" + _index + "]!");
            return true;
        }
    }
}
