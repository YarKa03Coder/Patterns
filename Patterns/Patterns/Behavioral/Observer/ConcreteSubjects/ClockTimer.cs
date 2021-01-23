using System;
using System.Threading;

namespace Patterns.Behavioral.Observer.ConcreteSubjects
{
    public class ClockTimer : Subject
    {
        private readonly Timer _timer;
        private TimeSpan _currentTime;

        private static void TimerProcedure(object obj)
        {
            ((ClockTimer) obj).Tick();
        }

        public ClockTimer()
        {
            _timer = new Timer(TimerProcedure, this, 1000, 1000);
        }

        public void Tick()
        {
            _currentTime = DateTime.Now.TimeOfDay;
            Notify();
        }

        public TimeSpan GetTime() => _currentTime;
    }
}