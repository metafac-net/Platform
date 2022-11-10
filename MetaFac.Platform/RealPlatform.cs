namespace MetaFac.Platform
{
    public class RealPlatform : IPlatform
    {
        public ITimeOfDayClock TimeOfDayClock { get; }
        public IMonotonicClock MonotonicClock { get; }
        public IRandomNumberSource RandomNumberSource { get; }

        public RealPlatform()
        {
            TimeOfDayClock = new TimeOfDayClock();
            MonotonicClock = new MonotonicClock(TimeOfDayClock);
            RandomNumberSource = new PsuedoRandom();
        }
    }
}