using System;

namespace Bcrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            String cleartext;
            String salt;
            int cost;
            String expected_hash;
            String actual_hash;

            //////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Test Case #1");
            cleartext = "<.S.2K(Zq'";
            salt = "VYAclAMpaXY/oqAo9yUpku";
            cost = 4;
            Bcrypt b1 = new Bcrypt(ref cleartext, ref salt, cost);
            expected_hash = "$2a$04$VYAclAMpaXY/oqAo9yUpkuWmoYywaPzyhu56HxXpVltnBIfmO9tgu";
            actual_hash = b1.Hash;
            Console.WriteLine("Expected -> " + expected_hash);
            Console.WriteLine("Actual   -> " + actual_hash);
            Console.WriteLine("========================================================================");

            //////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Test Case #2");
            cleartext = "5.rApO%5jA";
            salt = "kVNDrnYKvbNr5AIcxNzeIu";
            cost = 5;
            Bcrypt b2 = new Bcrypt(ref cleartext, ref salt, cost);
            expected_hash = "$2a$05$kVNDrnYKvbNr5AIcxNzeIuRcyIF5cZk6UrwHGxENbxP5dVv.WQM/G";
            actual_hash = b1.Hash;
            Console.WriteLine("Expected -> " + expected_hash);
            Console.WriteLine("Actual   -> " + actual_hash);
            Console.WriteLine("========================================================================");

            //////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Test Case #3");
            cleartext = "<.S.2K(Zq'";
            salt = "VYAclAMpaXY/oqAo9yUpku";
            cost = 4;
            Bcrypt b3 = new Bcrypt(ref cleartext, ref salt, cost);
            expected_hash = "$2a$04$VYAclAMpaXY/oqAo9yUpkuWmoYywaPzyhu56HxXpVltnBIfmO9tgu";
            actual_hash = b1.Hash;
            Console.WriteLine("Expected -> " + expected_hash);
            Console.WriteLine("Actual   -> " + actual_hash);
            Console.WriteLine("========================================================================");

            //////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Test Case #4");
            cleartext = "<.S.2K(Zq'";
            salt = "VYAclAMpaXY/oqAo9yUpku";
            cost = 4;
            Bcrypt b4 = new Bcrypt(ref cleartext, ref salt, cost);
            expected_hash = "$2a$04$VYAclAMpaXY/oqAo9yUpkuWmoYywaPzyhu56HxXpVltnBIfmO9tgu";
            actual_hash = b1.Hash;
            Console.WriteLine("Expected -> " + expected_hash);
            Console.WriteLine("Actual   -> " + actual_hash);
            Console.WriteLine("========================================================================");

            //////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Test Case #5");
            cleartext = "<.S.2K(Zq'";
            salt = "VYAclAMpaXY/oqAo9yUpku";
            cost = 4;
            Bcrypt b5 = new Bcrypt(ref cleartext, ref salt, cost);
            expected_hash = "$2a$04$VYAclAMpaXY/oqAo9yUpkuWmoYywaPzyhu56HxXpVltnBIfmO9tgu";
            actual_hash = b1.Hash;
            Console.WriteLine("Expected -> " + expected_hash);
            Console.WriteLine("Actual   -> " + actual_hash);
            Console.WriteLine("========================================================================");

            //////////////////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine("Test Case #6");
            cleartext = "<.S.2K(Zq'";
            salt = "$2a$21$VYAclAMpaXY/oqAo9yUpku";
            Bcrypt b6 = new Bcrypt(ref cleartext, ref salt);
            expected_hash = "$2a$04$VYAclAMpaXY/oqAo9yUpkuWmoYywaPzyhu56HxXpVltnBIfmO9tgu";
            actual_hash = b1.Hash;
            Console.WriteLine("Expected -> " + expected_hash);
            Console.WriteLine("Actual   -> " + actual_hash);
            Console.WriteLine("========================================================================");

        }
    }
}