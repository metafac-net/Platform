using System;

namespace MetaFac.Platform
{
    public interface ITimeOfDayClock
    {
        DateTimeOffset GetDateTimeOffset();
    }
}