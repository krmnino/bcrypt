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
            assert(String.Equals(expected_hash, actual_hash), 2);
            Console.WriteLine(">> Test 2 successful");
        }

        static void test3()
        {
            String cleartext = "<.S.2K(Zq'";
            String salt = "VYAclAMpaXY/oqAo9yUpku";
            int cost = 4;
            Bcrypt b = new Bcrypt(ref cleartext, ref salt, cost);
            String expected_hash = "$2b$04$VYAclAMpaXY/oqAo9yUpkuWmoYywaPzyhu56HxXpVltnBIfmO9tgu";
            String actual_hash = b.Hash;
            assert(String.Equals(expected_hash, actual_hash), 3);
            Console.WriteLine(">> Test 3 successful");
        }

        static void test4()
        {
            String cleartext = "<.S.2K(Zq'";
            String salt = "VYAclAMpaXY/oqAo9yUpku";
            int cost = 4;
            Bcrypt b = new Bcrypt(ref cleartext, ref salt, cost);
            String expected_hash = "$2b$04$VYAclAMpaXY/oqAo9yUpkuWmoYywaPzyhu56HxXpVltnBIfmO9tgu";
            String actual_hash = b.Hash;
            assert(String.Equals(expected_hash, actual_hash), 4);
            Console.WriteLine(">> Test 4 successful");
        }

        static void test5()
        {
            String cleartext = "<.S.2K(Zq'";
            String salt = "VYAclAMpaXY/oqAo9yUpku";
            int cost = 4;
            Bcrypt b = new Bcrypt(ref cleartext, ref salt, cost);
            String expected_hash = "$2b$04$VYAclAMpaXY/oqAo9yUpkuWmoYywaPzyhu56HxXpVltnBIfmO9tgu";
            String actual_hash = b.Hash;
            assert(String.Equals(expected_hash, actual_hash), 5);
            Console.WriteLine(">> Test 5 successful");
        }

        static void test6()
        {
            String cleartext = "ggJ\\KbTnDG";
            String salt = "$2b$07$4H896R09bzjhapgCPS/LYu";
            Bcrypt b = new Bcrypt(ref cleartext, ref salt);
            String expected_hash = "$2b$07$4H896R09bzjhapgCPS/LYuMzAQluVgR5iu/ALF8L8Aln6lzzYXwbq";
            String actual_hash = b.Hash;
            assert(String.Equals(expected_hash, actual_hash), 6);
            Console.WriteLine(">> Test 6 successful");
        }
        static void Main(string[] args)
        { 
            bool all = true;
            bool t1  = true;
            bool t2  = true;
            bool t3  = true;
            bool t4  = true;
            bool t5  = true;
            bool t6  = true;

            if (t1 || all)
            {
                test1();
            }
            if (t2 || all)
            {
                test2();
            }
            if (t3 || all)
            {
                test3();
            }
            if (t4 || all)
            {
                test4();
            }
            if (t5 || all)
            {
                test5();
            }
            if (t6 || all)
            {
                test6();
            }
        }
    }
}