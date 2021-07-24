using System;

namespace Bcrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Bcrypt b = new Bcrypt("Password123", 10);
            String ret = b.Hash;
            Console.WriteLine(ret);
        }
    }
}
