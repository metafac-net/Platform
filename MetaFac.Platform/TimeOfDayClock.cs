using System;

namespace MetaFac.Platform
{
    public class TimeOfDayClock : ITimeOfDayClock
    {
        public DateTimeOffset GetDateTimeOffset()
        {
            return DateTimeOffset.Now;
        }
    }
}