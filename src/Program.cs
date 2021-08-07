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
            String base64_salt = "VYAclAMpaXY/oqAo9yUpku";
            UInt32[] dec = b.DecodeBase64(ref base64_salt, 0);
            String enc = b.EncodeBase64(ref dec, 0);
            dec = b.DecodeBase64(ref enc, 0);
            enc = b.EncodeBase64(ref dec, 0);
            Console.Write(enc);
        }
    }
}
