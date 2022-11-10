using System.Threading;

namespace MetaFac.Platform
{
    public class MonotonicClock : IMonotonicClock
    {
        private readonly ITimeOfDayClock _timeOfDayClock;

        public MonotonicClock(ITimeOfDayClock timeOfDayClock)
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
                newValue = _timeOfDayClock.GetDateTimeOffset().Ticks;
                while (newValue <= _lastUniqueTicks)
                    newValue++;
                original = _lastUniqueTicks;
                replaced = Interlocked.CompareExchange(ref _lastUniqueTicks, newValue, original);
            } while (replaced != original);
            return newValue;
        }
    }
}