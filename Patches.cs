using HarmonyLib;

namespace SkipSplashes
{
    public static class Patches
    {
        [HarmonyPatch(typeof(IntroSplashPanel), "Start")]
        // ReSharper disable once RedundantAssignment
        public static void Prefix() => IntroSplashPanel.skipIntro = true;
        
        [HarmonyPatch(typeof(LegalSplashPanel), "Start")]
        public static void Postfix() => IntroSplashPanel.skipIntro = false;
    }
}
