using System.Diagnostics;
using UnityEngine;
namespace Assets.Minifly.Scripts.Helpers
{
    public static class PerformanceCounter
    {
        private static Stopwatch watch;
        private static StackTrace stackTrace = new StackTrace();
        public static void Start()
        {
            watch = System.Diagnostics.Stopwatch.StartNew();
        }

        public static float Stop()
        {

            watch.Stop();
            var milis = watch.ElapsedMilliseconds;
            UnityEngine.Debug.Log(stackTrace.GetFrame(1).GetMethod().Name);
            return milis;
        }
    }
}
