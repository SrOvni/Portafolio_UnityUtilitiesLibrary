using UnityEngine;
using UnityEngine.LowLevel;
using UtilitiesLibrary.LowLevel;

namespace UtilitiesLibrary
{
    internal static class TimerBootstrapper
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        internal static void Initialize()
        {
            PlayerLoopSystem currentPlayerLoop = PlayerLoop.GetCurrentPlayerLoop();

            //To do Print player loop

            PlayerLoopUtils.PrintPlayerLoop(currentPlayerLoop);
        }
    }
}
