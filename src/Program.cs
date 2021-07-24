using System;

namespace Bcrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Bcrypt b = new Bcrypt("Password123", 10);
            b.Blowfish_f(0x12345678);
            UInt32 x = 0x12345678;
            UInt32 y = 0x87654321;
            b.Swap(ref x, ref y);
        }
    }
}
