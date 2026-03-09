using UnityEngine;
using BepInEx;

namespace Nyxpiri.ULTRAKILL.HeckPuppets
{
    [BepInPlugin("com.nyxpiri.bepinex.plugins.ultrakill.heck-puppets", "Heck Puppets", "0.0.0.1")]
    [BepInProcess("ULTRAKILL.exe")]
    public class HeckPuppetsPlugin : BaseUnityPlugin
    {
        protected void Awake()
        {
            Log.Initialize(Logger);
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
