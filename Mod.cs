using System.IO;
using BepInEx;
using HarmonyLib;

namespace SkipSplashes
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class Mod : BaseUnityPlugin
    {
        private const string PluginGUID = "ca.gnivler.sheltered2.SkipSplashes";
        private const string PluginName = "NoSplashes";
        private const string PluginVersion = "1.0.0";
         
        private void Awake()
        {
            Harmony harmony = new("ca.gnivler.sheltered2.SkipSplashes");
            Log("SkipSplashes Startup");
            harmony.PatchAll(typeof(Patches));
        }

        internal static void Log(object input)
        {
            //File.AppendAllText("log.txt",$"{input ?? "null"}\n");
        }
    }
}
