using System;

namespace MetaFac.Platform
{
    public interface IRandomNumberSource
    {
        int NextInt32();
        long NextInt64();
        Guid NextGuid();
    }
}