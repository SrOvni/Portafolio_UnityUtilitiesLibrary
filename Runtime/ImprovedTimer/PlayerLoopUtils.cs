using System.Text;
using log4net.Core;
using UnityEngine;
using UnityEngine.LowLevel;

namespace UtilitiesLibrary.LowLevel
{
    public static class PlayerLoopUtils
    {
        public static void PrintPlayerLoop(PlayerLoopSystem loop)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Unity Player Loop");
            foreach (PlayerLoopSystem subSystem in loop.subSystemList)
            {
                PrintSubsytem(subSystem, sb, 0);
            }
            Debug.Log(sb.ToString());
        }

        static void PrintSubsytem(PlayerLoopSystem system, StringBuilder sb, int level)
        {
            sb.Append(' ', level * 2).AppendLine(system.type.ToString());
            if (system.subSystemList == null || system.subSystemList.Length == 0) return;
            
            foreach (PlayerLoopSystem subsystem in system.subSystemList)
            {
                PrintSubsytem(subsystem, sb, level + 1);
            }
        }
    }
}