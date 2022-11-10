using System;

namespace MetaFac.Platform.Testing
{

    public class PsuedoRandomWithSeed : IRandomNumberSource
    {
        private readonly Random _rng;

        public PsuedoRandomWithSeed(int seed)
        {
            _rng = new Random(seed);
        }

        public int NextInt32()
        {
#if NET6_0
            return _rng.Next();
#elif NET5_0
            return _rng.Next();
#else
            return _rng.Next();
#endif
        }

        public long NextInt64()
        {
#if NET6_0
            return _rng.NextInt64();
#elif NET5_0
            return ((long)_rng.Next()) * _rng.Next();
#else
            return ((long)_rng.Next()) * _rng.Next();
#endif
        }

        public Guid NextGuid()
        {
#if NET6_0 || NET5_0
            Span<byte> span = stackalloc byte[16];
            _rng.NextBytes(span);
            return new Guid(span);
#else
            var bytes = new byte[16];
            _rng.NextBytes(bytes);
            return new Guid(bytes);
#endif
        }
    }
}
