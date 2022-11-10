using FluentAssertions;
using MetaFac.Platform.Testing;
using System;
using Xunit;

namespace MetaFac.Platform.UnitTests
{
    public class MonotonicClockTests
    {
        [Fact]
        public void T0_GetUniqueTicks()
        {
            var timeOfDayClock = new ManualStepClock(0, TimeSpan.Zero);
            var monotonicClock = new MonotonicTimeOfDayClock(timeOfDayClock);

            var t0 = monotonicClock.GetUniqueTicks();
            t0.Should().Be(1L);

            var t1 = monotonicClock.GetUniqueTicks();
            t1.Should().Be(2L);
        }

        [Fact]
        public void T1_GetUniqueTicks()
        {
            var timeOfDayClock = new TimeOfDayClock();
            var monotonicClock = new MonotonicTimeOfDayClock(timeOfDayClock);

            var t0 = monotonicClock.GetUniqueTicks();

            var t1 = monotonicClock.GetUniqueTicks();
            t1.Should().BeGreaterThan(t0);
        }
    }
}
