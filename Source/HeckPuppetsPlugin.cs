using UnityEngine;
using BepInEx;
using Nyxpiri.ULTRAKILL.NyxLib;
using System;

namespace Nyxpiri.ULTRAKILL.HeckPuppets
{
    public static class Cheats
    {
        public const string HeckPuppets = "nyxpiri.heck-puppets";
    }

    [BepInPlugin("com.nyxpiri.bepinex.plugins.ultrakill.heck-puppets", "Heck Puppets", "0.0.0.1")]
    [BepInProcess("ULTRAKILL.exe")]
    public class HeckPuppetsPlugin : BaseUnityPlugin
    {
        protected void Awake()
        {
            Log.Initialize(Logger);
            HeckPuppetLeader.Initialize();
            HeckPuppetObserver.Initialize();
            NyxLib.Cheats.ReadyForCheatRegistration += RegisterCheats;

            Options.Config = Config;
        }

        private void RegisterCheats(CheatsManager cheatsManager)
        {
            cheatsManager.RegisterCheat(new ToggleCheat(
                "Heck Puppets", 
                Cheats.HeckPuppets,
                onDisable: (cheat) =>
                {
                },
                onEnable: (cheat, manager) =>
                {
                }
            ), "HELL'S IMPACT");        

        }

        protected void OnApplicationFocus(bool hasFocus)
        {
            if (hasFocus)
            {
                Config.Reload();
            }
        }

        protected void Start()
        {
        }

        protected void Update()
        {

        }

        protected void LateUpdate()
        {

        }
    }
}
