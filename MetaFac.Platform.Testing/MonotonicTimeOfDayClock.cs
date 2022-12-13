using System;
using System.Threading;

namespace MetaFac.Platform.Testing
{
    public class MonotonicTimeOfDayClock : IMonotonicClock, ITimeOfDayClock
    {
        private readonly ITimeOfDayClock _timeOfDayClock;

        public MonotonicTimeOfDayClock(ITimeOfDayClock timeOfDayClock)
        {
            _timeOfDayClock = timeOfDayClock;
        }

        private long _lastUniqueTicks = 0;
        public long GetUniqueTicks()
        {
            long newValue;
            long original;
            long replaced;
            do
            {
                original = _lastUniqueTicks;
                newValue = _timeOfDayClock.GetDateTimeOffset().Ticks;
                while (newValue <= original)
                    newValue++;
                replaced = Interlocked.CompareExchange(ref _lastUniqueTicks, newValue, original);
            } while (replaced != original);
            return newValue;
        }

        public DateTimeOffset GetDateTimeOffset()
        {
            long ticks = GetUniqueTicks();
            return new DateTimeOffset(ticks, TimeSpan.Zero);
        }
    }
}
