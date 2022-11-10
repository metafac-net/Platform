using System;
using System.Runtime.InteropServices;

namespace MetaFac.Platform.Testing
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    internal readonly struct Int16Map
    {
        [FieldOffset(0)]
        public readonly Int16 Value;
        [FieldOffset(0)]
        public readonly Byte A;
        [FieldOffset(1)]
        public readonly Byte B;

        public Int16Map(short value)
        {
            A = 0;
            B = 0;
            Value = value;
        }
    }
}
