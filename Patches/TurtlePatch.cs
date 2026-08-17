using HarmonyLib;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using BepInEx;
using BepInEx.Logging;

namespace BerryAP.Patches
{
    [HarmonyPatch(typeof(TurtleEatAoe), "SpawnCoin")]
    public class SpawnCoinPatch
    {
        
        public static bool Prefix(TurtleEatAoe __instance, GameObject _coinPrefab, float ___coinEject_Force, float ___coinEject_Torque)
        {
            //Testing harmony patch code, replacing the Coin Spawning from the hole with modifiable copy
            GameObject coinEjectTarget = Traverse.Create(__instance).Field("coinEjectTarget").GetValue<GameObject>();
            GameObject coinSpawnPoint = Traverse.Create(__instance).Field("coinSpawnPoint").GetValue<GameObject>();

            Vector3 vector = coinEjectTarget.transform.position - coinSpawnPoint.transform.position;
            Vector3 one = Vector3.one;
            Rigidbody component = Object.Instantiate(_coinPrefab, coinSpawnPoint.transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            component.AddForce(vector * ___coinEject_Force, ForceMode.VelocityChange);
            one = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            component.AddTorque(one * ___coinEject_Torque, ForceMode.VelocityChange);
            AudioManager.Singleton.PlayCoinSpawnSFX(GameManager.Singleton.GetYardObject().transform.position);
            return false;
        }
    }
}
