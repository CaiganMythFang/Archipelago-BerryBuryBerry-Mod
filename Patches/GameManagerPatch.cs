using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine;
using BepInEx;
using BepInEx.Logging;
using System.Reflection;
using BerryAP.Managers;

namespace BerryAP.Patches
{
    [HarmonyPatch(typeof(GameManager), "SpawnStarOrbsFromHoleDeposit")]
    class GameManagerPatch
    {
        public static bool Prefix(GameManager __instance, PickUppable _pickUp)
        {
            /// Debug logging when a prop falls into the hole, sending the internal name to the Console log
            Plugin.Log("Star Orb Spawner Called with object : Name [" + _pickUp.name.ToString() + "] , tag[" + _pickUp.tag.ToString() + "] , GameObject [" + _pickUp.gameObject.ToString() + "]!");
            //Type objtype = _pickUp.GetType();
            //PropertyInfo[] properties = objtype.GetProperties();
            //foreach (PropertyInfo property in properties)
            //{
            //    Plugin.Log($"{property.Name}");
            //}

            var name = _pickUp.name.ToString();
            //Plugin.Log("Sending prop name" + name + "to Data Manager");
            DataManager.prop_list = DataManager.prop_list + "\n" + name;
            //Plugin.Log("Naming out prop list");
            Plugin.Log(DataManager.prop_list);

            return true;
        }
    }
}
