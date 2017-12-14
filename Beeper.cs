using System;
using System.Threading;

namespace pKami.SimpleTimer
{
    public class Beeper
    {
        private static readonly Lazy<Beeper> _instance = new Lazy<Beeper>(() => new Beeper());
        public static Beeper Instance { get { return _instance.Value; } }

        private volatile bool _shouldStop;

        public void RequestStop()
        {
            _shouldStop = true;
        }

        public void Enable()
        {
            _shouldStop = false;
        }

        public void PlayAlarm()
        {
            while (!_shouldStop)
            {
                AlarmBeep();
                Thread.Sleep(600);
            }
        }

        private static void AlarmBeep()
        {
            uint tone1 = 3500, tone2 = 2000;
            uint dur1 = 80, dur2 = 200;
            WinApi.Beep(tone2, dur1);
            WinApi.Beep(tone1, dur2);
            WinApi.Beep(tone2, dur1);
            WinApi.Beep(tone1, dur2);
            WinApi.Beep(tone2, dur1);
            WinApi.Beep(tone1, dur2);
        }
    }
}
