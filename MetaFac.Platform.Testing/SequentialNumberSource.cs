using System;
using System.Threading;

namespace MetaFac.Platform.Testing
{
    public class SequentialNumberSource : IRandomNumberSource, IMonotonicClock
    {
        private long _last = 0;

        public SequentialNumberSource(long last)
        {
            _last = last;
        }

        public long GetUniqueTicks()
        {
            return Interlocked.Increment(ref _last);
        }

        public int NextInt32()
        {
            return (int)Interlocked.Increment(ref _last);
        }

        public long NextInt64()
        {
            return Interlocked.Increment(ref _last);
        }

        public Guid NextGuid()
        {
            Int64Map a = new Int64Map(Interlocked.Increment(ref _last));
            Int64Map b = new Int64Map(Interlocked.Increment(ref _last));
            return new Guid
            (
                a.A.Value,
                a.B.A.Value, a.B.B.Value,
                b.A.A.A, b.A.A.B, b.A.B.A, b.A.B.B,
                b.B.A.A, b.B.A.B, b.B.B.A, b.B.B.B
            );
        }
    }
}
