using System.Diagnostics;

//c Add UptimeService.cs in Infrastructure folder.

namespace ConfiguringApps.Infrastructure
{
    public class UptimeService
    {
        private Stopwatch timer;
        public UptimeService()
        {
            timer = Stopwatch.StartNew();
        }
        public long Uptime => timer.ElapsedMilliseconds;
    }
}