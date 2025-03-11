using MetaFac.Platform.Testing;
using Shouldly;
using Xunit;

namespace MetaFac.Platform.UnitTests
{
    public class RandomNumberSourceTests
    {
        [Fact]
        public void PsuedoRandomWithSeed_NextInt32()
        {
            var random = new PsuedoRandomWithSeed(0);
            int result = random.NextInt32();
#if NET6_0
            result.ShouldBe(1559595546);
#else
            result.ShouldBe(1559595546);
#endif
        }

        [Fact]
        public void PsuedoRandomWithSeed_NextInt64()
        {
            var random = new PsuedoRandomWithSeed(0);
            long result = random.NextInt64();
#if NET6_0
            result.ShouldBe(7083764782846131554L);
#else
            result.ShouldBe(2737390941873472824L);
#endif
        }

        [Fact]
        public void PsuedoRandomWithSeed_NextGuid()
        {
            var random = new PsuedoRandomWithSeed(0);
            var result = random.NextGuid();
            result.ToString("N").ShouldBe("6f460c1a755dd8e4ad6765d5f519dbc8");
        }

        [Fact]
        public void SequentialNumberSource_NextInt32()
        {
            var random = new SequentialNumberSource(0);
            int result = random.NextInt32();
            result.ShouldBe(1);
        }

        [Fact]
        public void SequentialNumberSource_NextInt64()
        {
            var random = new SequentialNumberSource(0);
            long result = random.NextInt64();
            result.ShouldBe(1L);
        }

        [Fact]
        public void SequentialNumberSource_NextGuid()
        {
            var random = new SequentialNumberSource(0);
            var result = random.NextGuid();
            result.ToString("N").ShouldBe("00000001000000000200000000000000");
        }
    }
}
