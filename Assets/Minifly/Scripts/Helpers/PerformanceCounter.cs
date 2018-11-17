using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Minifly.Scripts.Helpers
{
    public static class PerformanceCounter
    {
        private static Stopwatch watch;

        public static void Start()
        {
            watch = System.Diagnostics.Stopwatch.StartNew();
        }

        public static float Stop()
        {
            watch.Stop();
            var milis = watch.ElapsedMilliseconds;
            return milis;
        }
    }
}
