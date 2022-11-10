using System;

namespace MetaFac.Platform
{
    public class PsuedoRandom : IRandomNumberSource
    {
#if NET6_0_OR_GREATER
#else
        private readonly Random _rng;
#endif

        public PsuedoRandom()
        {
#if NET6_0_OR_GREATER
#else
            _rng = new Random(Environment.TickCount);
#endif
        }

        public int NextInt32()
        {
#if NET6_0_OR_GREATER
            return Random.Shared.Next();
#else
            return _rng.Next();
#endif
        }

        public long NextInt64()
        {
#if NET6_0_OR_GREATER
            return Random.Shared.NextInt64();
#else
            return ((long)_rng.Next()) * _rng.Next();
#endif
        }

        public Guid NextGuid()
        {
#if NET6_0_OR_GREATER
            Span<byte> span = stackalloc byte[16];
            Random.Shared.NextBytes(span);
            return new Guid(span);
#else
            var bytes = new byte[16];
            _rng.NextBytes(bytes);
            return new Guid(bytes);
#endif
        }
    }
}