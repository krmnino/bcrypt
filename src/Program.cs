using System;

namespace Bcrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Bcrypt b = new Bcrypt("<.S.2K(Zq'", 4);
            String ret = b.Hash;
            Console.WriteLine(ret);

            Bcrypt empty = new Bcrypt();
            String base64_salt = "VYAclAMpaXY/oqAo9yUpku";
            UInt32[] dec;
            String enc;
            dec = empty.DecodeBase64(ref base64_salt, 0);
            enc = empty.EncodeBase64(ref dec, 0);
            Console.WriteLine(enc);

            Bcrypt custom_salt = new Bcrypt("<.S.2K(Zq'", ref dec, 8);
            ret = custom_salt.Hash;
            Console.WriteLine(ret);
        }
    }
}