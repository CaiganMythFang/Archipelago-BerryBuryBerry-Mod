using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace BerryAP.Patches
{
    [HarmonyPatch(typeof(SpeechBubbleConditionChecker), "OnDestroy")]
    class SpeechBubbleConditionCheckerPatch
    {
        public static bool Prefix(SpeechBubbleConditionChecker __instance)
        {
            Plugin.Log("Speech Bubble Consumed [" + __instance + "]!");
            return true;
        }
    }
}
