using System;

namespace MetaFac.Platform.Testing
{
    public class TestPlatform : IPlatform
    {
        public ITimeOfDayClock TimeOfDayClock { get; }
        public IMonotonicClock MonotonicClock { get; }
        public IRandomNumberSource RandomNumberSource { get; }

        public TestPlatform(ITimeOfDayClock? timeOfDayClock = null, IRandomNumberSource? randomNumberSource = null)
        {
            TimeOfDayClock = timeOfDayClock ?? new ManualStepClock(0L, TimeSpan.Zero);
            MonotonicClock = new MonotonicTimeOfDayClock(TimeOfDayClock);
            RandomNumberSource = randomNumberSource ?? new PsuedoRandomWithSeed(0);
        }
    }
}
