using BBI.Unity.Game;
using HarmonyLib;

namespace NoSplashes
{
    public static class Patches
    {
        [HarmonyPatch(typeof(LaunchSplashScreenControlller), "Awake")]
        public static void Postfix() => SceneLoader.Instance.LoadFrontEndScene();
    }
}
