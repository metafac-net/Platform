using System;
using System.Threading;

namespace MetaFac.Platform.Testing
{
    public class ManualStepClock : ITimeOfDayClock
    {
        private readonly long _start;
        private readonly TimeSpan _offset;

        // run state
        private long _duration = 0;

        public ManualStepClock()
        {
            var dtzNow = DateTimeOffset.Now;
            _start = dtzNow.Ticks;
            _offset = dtzNow.Offset;
        }

        public ManualStepClock(long start, TimeSpan offset)
        {
            _start = start;
            _offset = offset;
        }

        public ManualStepClock(DateTimeOffset startDtz)
        {
            _start = startDtz.Ticks;
            _offset = startDtz.Offset;
        }

        public ManualStepClock(DateTime startUtc)
        {
            if (startUtc.Kind != DateTimeKind.Utc)
                throw new ArgumentException("Kind is not Utc", nameof(startUtc));

            _start = startUtc.Ticks;
            _offset = TimeSpan.Zero;
        }

        public DateTimeOffset GetDateTimeOffset()
        {
            return new DateTimeOffset(_start + _duration, _offset);
        }

        public DateTimeOffset Advance(long ticks)
        {
            long duration = Interlocked.Add(ref _duration, ticks);
            return new DateTimeOffset(_start + duration, _offset);
        }

        public DateTimeOffset Advance(TimeSpan timespan)
        {
            long duration = Interlocked.Add(ref _duration, timespan.Ticks);
            return new DateTimeOffset(_start + duration, _offset);
        }
    }
}
