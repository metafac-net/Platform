using FluentAssertions;
using MetaFac.Platform.Testing;
using System;
using Xunit;

namespace MetaFac.Platform.UnitTests
{
    public class ManualStepClockTests
    {
        [Fact]
        public void T0_CreateManualClockFromUtcDateTime()
        {
            var inp0 = DateTime.UtcNow;
            var clock = new ManualStepClock(inp0);

            var out0 = clock.GetDateTimeOffset();
            out0.UtcDateTime.Should().Be(inp0);
            out0.Should().Be(new DateTimeOffset(inp0, TimeSpan.Zero));
        }

        [Fact]
        public void T1_CreateManualClockFromDateTimeOffset()
        {
            var inp0 = DateTimeOffset.Now;
            var clock = new ManualStepClock(inp0);

            var out0 = clock.GetDateTimeOffset();
            out0.Should().Be(inp0);
        }

        [Fact]
        public void T2_AdvanceClockA()
        {
            var inp0 = DateTimeOffset.Now;
            var clock = new ManualStepClock(inp0);

            long interval = TimeSpan.FromHours(1).Ticks;
            var out1 = clock.Advance(interval);

            out1.Should().Be(inp0.AddTicks(interval));
        }

        [Fact]
        public void T2_AdvanceClockB()
        {
            var inp0 = DateTimeOffset.Now;
            var clock = new ManualStepClock(inp0);

            var interval = TimeSpan.FromHours(1);
            var out1 = clock.Advance(interval);

            out1.Should().Be(inp0.AddTicks(interval.Ticks));
        }
    }
}
