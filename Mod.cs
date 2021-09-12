using BepInEx;
using HarmonyLib;

namespace NoSplashes
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class Mod : BaseUnityPlugin
    {
        private const string PluginGUID = "ca.gnivler.shipbreaker.NoSplashes";
        private const string PluginName = "NoSplashes";
        private const string PluginVersion = "1.0.0";

        private void Awake()
        {
            Harmony harmony = new("ca.gnivler.shipbreaker.NoSplashes");
            harmony.PatchAll(typeof(Patches));
            Log("NoSplashes Startup");
        }

        internal static void Log(object input)
        {
            //File.AppendAllText("log.txt",$"{input ?? "null"}\n");
        }
    }
}
