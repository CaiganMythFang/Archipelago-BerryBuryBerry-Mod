using BepInEx;
using BepInEx.Logging;
using BerryAP.Patches;
using HarmonyLib;

namespace BerryAP;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInProcess("BerryBerryBerryBerryBerryBerryBerryBerryBerry.exe")]
public class Plugin : BaseUnityPlugin
{
    private const string MOD_GUID = "BerryBuryBerryAP.Caigan.Tokucade";
    private const string MOD_Name = "Caigan.BerryBuryBerryAP";
    private const string MOD_Version = "0.0.1";
    private readonly Harmony _harmony = new Harmony(MOD_GUID);
    internal static new ManualLogSource Logger;
        
    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        _harmony.PatchAll();
        var game_manager_new_field = new Harmony("BerryAP.Patches.AddFieldPatch");
    }
    public static void Log(string s)
    {
        Logger.LogInfo(s);
    }
}
