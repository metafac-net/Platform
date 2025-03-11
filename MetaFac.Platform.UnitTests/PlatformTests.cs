using MetaFac.Platform.Testing;
using Shouldly;
using Xunit;

namespace MetaFac.Platform.UnitTests
{
    public class PlatformTests
    {
        [Fact]
        public void T0_CreateDefaultTestPlatform()
        {
            IPlatform platform = new TestPlatform();
            platform.TimeOfDayClock.GetDateTimeOffset().UtcDateTime.ToString("O").ShouldBe("0001-01-01T00:00:00.0000000Z");
            platform.RandomNumberSource.NextGuid().ToString("N").ShouldBe("6f460c1a755dd8e4ad6765d5f519dbc8");

            platform.MonotonicClock.GetUniqueTicks().ShouldBe(1L);
            platform.MonotonicClock.GetUniqueTicks().ShouldBe(2L);
        }
    }
}
