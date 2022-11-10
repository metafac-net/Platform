using System;

namespace MetaFac.Platform.Testing
{
    public class NormalAutoClock : ITimeOfDayClock
    {
        public DateTimeOffset GetDateTimeOffset()
        {
            return DateTimeOffset.Now;
        }
    }
}
