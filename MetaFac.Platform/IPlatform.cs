namespace MetaFac.Platform
{
    public interface IPlatform
    {
        ITimeOfDayClock TimeOfDayClock { get; }
        IMonotonicClock MonotonicClock { get; }
        IRandomNumberSource RandomNumberSource { get; }
    }
}