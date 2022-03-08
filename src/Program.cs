using System;

namespace Bcrypt
{
    class Program
    {
        static void assert(bool expr, int testcase)
        {
            if (!expr)
            {
                Console.WriteLine("Error: Assertion failed at testcase " + testcase + ".");
                System.Environment.Exit(1);
            }
        }
        static void test1()
        {
            String cleartext = "<.S.2K(Zq'";
            String salt = "VYAclAMpaXY/oqAo9yUpku";
            int cost = 4;
            Bcrypt b1 = new Bcrypt(ref cleartext, ref salt, cost);
            String expected_hash = "$2b$04$VYAclAMpaXY/oqAo9yUpkuWmoYywaPzyhu56HxXpVltnBIfmO9tgu";
            String actual_hash = b1.Hash;
            assert(String.Equals(expected_hash, actual_hash), 1);
            Console.WriteLine(">> Test 1 successful");
        }

        static void test2()
        {
            String cleartext = "5.rApO%5jA";
            String salt = "kVNDrnYKvbNr5AIcxNzeIu";
            int cost = 5;
            Bcrypt b = new Bcrypt(ref cleartext, ref salt, cost);
            String expected_hash = "$2b$05$kVNDrnYKvbNr5AIcxNzeIuRcyIF5cZk6UrwHGxENbxP5dVv.WQM/G";
            String actual_hash = b.Hash;
            assert(String.Equals(expected_hash, actual_hash), 1);
            Console.WriteLine(">> Test 2 successful");
        }
        static void Main(string[] args)
        {
            String cleartext;
            String salt;
            int cost;
            String expected_hash;
            String actual_hash;

            //////////////////////////////////////////////////////////////////////////////////////////////

            test1();

            //////////////////////////////////////////////////////////////////////////////////////////////

            test2();

            //////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Test Case #3");
            cleartext = "<.S.2K(Zq'";
            salt = "VYAclAMpaXY/oqAo9yUpku";
            cost = 4;
            Bcrypt b3 = new Bcrypt(ref cleartext, ref salt, cost);
            expected_hash = "$2a$04$VYAclAMpaXY/oqAo9yUpkuWmoYywaPzyhu56HxXpVltnBIfmO9tgu";
            actual_hash = b3.Hash;
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
            actual_hash = b4.Hash;
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
            actual_hash = b5.Hash;
            Console.WriteLine("Expected -> " + expected_hash);
            Console.WriteLine("Actual   -> " + actual_hash);
            Console.WriteLine("========================================================================");

            //////////////////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine("Test Case #6");
            cleartext = "ggJ\\KbTnDG";
            salt = "$2a$07$4H896R09bzjhapgCPS/LYu";
            Bcrypt b6 = new Bcrypt(ref cleartext, ref salt);
            expected_hash = "$2a$07$4H896R09bzjhapgCPS/LYuMzAQluVgR5iu/ALF8L8Aln6lzzYXwbq";
            actual_hash = b6.Hash;
            Console.WriteLine("Expected -> " + expected_hash);
            Console.WriteLine("Actual   -> " + actual_hash);
            Console.WriteLine("========================================================================");

        }
    }
}