using System;

namespace Bcrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            //String cleartext = "<.S.2K(Zq'";
            //Bcrypt b = new Bcrypt(ref cleartext, 4);
            //String ret = b.Hash;
            //Console.WriteLine(ret);
            //
            //Bcrypt empty = new Bcrypt();
            //String base64_salt = "VYAclAMpaXY/oqAo9yUpku";
            //UInt32[] dec;
            //String enc;
            //dec = empty.DecodeBase64(ref base64_salt, 0);
            //enc = empty.EncodeBase64(ref dec, 0);
            //Console.WriteLine(enc);
            //
            //cleartext = "<.S.2K(Zq'";
            //Bcrypt custom_salt = new Bcrypt(ref cleartext, ref dec, 4);
            //ret = custom_salt.Hash;
            //Console.WriteLine(ret);

            String cleartext = "<.S.2K(Zq'";
            String base64_salt = "VYAclAMpaXY/oqAo9yUpku";
            Bcrypt custom_b64salt = new Bcrypt(ref cleartext, ref base64_salt, 4);
            String ret = custom_b64salt.Hash;
            Console.WriteLine(ret);
        }
    }
}