using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftStatsViewer_.Helpers
{
    public static class Logger
    {
        public static void Debug(string msg)
        {
            System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToShortTimeString()}|Debug|{msg}");
        }
    }
}
