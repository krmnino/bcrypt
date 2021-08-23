using System;

namespace Bcrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            String cleartext = "<.S.2K(Zq'";
            //Bcrypt b = new Bcrypt(ref cleartext, 4);
            //String ret = b.Hash;
            //Console.WriteLine(ret);

            //cleartext = "<.S.2K(Zq'";
            //Bcrypt custom_salt = new Bcrypt(ref cleartext, ref dec, 4);
            //ret = custom_salt.Hash;
            //Console.WriteLine(ret);

            //cleartext = "<.S.2K(Zq'";
            cleartext = "abc";
            //base64_salt = "VYAclAMpaXY/oqAo9yUpku";
            String base64_salt = "1kJyuho8MCVP3HHsjnRMkO";
            Bcrypt custom_b64salt = new Bcrypt(ref cleartext, ref base64_salt, 6);
            String ret = custom_b64salt.Hash;
            Console.WriteLine(ret);

            Base64 encdec = new Base64();
            String slt = "ACfku9dT6.H8VjdKb8nhlu";
            Byte[] ret_dec = encdec.Decoder(ref slt, 16);
            String ret_enc = encdec.Encoder(ref ret_dec, ret_dec.Length);
            Console.WriteLine(ret_enc);
        }
    }
}