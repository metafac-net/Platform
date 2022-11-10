using System;
using System.Runtime.InteropServices;

namespace MetaFac.Platform.Testing
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    internal readonly struct Int32Map
    {
        // 1 * 32-bit fields
        [FieldOffset(0)]
        public readonly Int32 Value;

        // 2 * 16-bit fields
        [FieldOffset(0)]
        public readonly Int16Map A;
        [FieldOffset(2)]
        public readonly Int16Map B;

        public Int32Map(int value)
        {
            A = new Int16Map(0);
            B = new Int16Map(0);
            Value = value;
        }
    }
}
