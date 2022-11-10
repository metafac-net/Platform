using System;
using System.Runtime.InteropServices;

namespace MetaFac.Platform.Testing
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    internal readonly struct Int64Map
    {
        // 1 * 64-bit fields
        [FieldOffset(0)]
        public readonly Int64 Value;

        // 2 * 32-bit fields
        [FieldOffset(0)]
        public readonly Int32Map A;
        [FieldOffset(4)]
        public readonly Int32Map B;

        public Int64Map(long value)
        {
            A = new Int32Map(0);
            B = new Int32Map(0);
            Value = value;
        }
    }
}
