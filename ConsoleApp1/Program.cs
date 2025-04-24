using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/*****************/");
            Console.WriteLine("Vars");
            Console.Title = "Hi App";
            Console.WriteLine(Console.Title);
            //Console.WriteLine(Console.ReadLine());
            Console.WriteLine(89 + 89);
            //Variables
            string name = "Ahmed";
            Console.WriteLine("Name " + name);
            int age = 43;
            Console.WriteLine("Age " + age);
            int x = 10;
            int y = 15;
            int z;
            z = x + y;
            Console.WriteLine($"Z/2: {z / 2}");
            string sx = "10";
            string sy = "15";
            string sz = sx + sy;
            Console.WriteLine($"SZ {sz}");
            double dx = 10;
            double dy = 15;
            double dz = dx + dy;
            Console.WriteLine($"DZ/2 {dz / 2}");
            float fx = 10.0f;
            float fy = 15;
            float fz = fx + fy;
            Console.WriteLine($"FZ {fz}");
            Console.WriteLine($"FZ/2 {fz / 2}");
            //Console.WriteLine(Console.ReadLine());
            Console.WriteLine(89 + 89);
            //int ix = Convert.ToInt32(Console.ReadLine());
            int ix = Convert.ToInt32("21");
            Console.WriteLine($"IX {ix}");
            Console.WriteLine("/*****************/");
            Console.WriteLine("IF");
            int ifx = 15;
            int ify = 10;
            if (ifx < ify)
                Console.WriteLine("X is less than Y");
            if (ifx > ify)
                Console.WriteLine("X is larger than Y");
            if (ifx == ify)
                Console.WriteLine("X = Y");
            if (ifx != ify)
                Console.WriteLine("X != Y");
            if (ifx < ify)
                Console.WriteLine("X is less than Y");
            else
                Console.WriteLine("X is not less than Y");
            if (ifx < ify)
                Console.WriteLine("X is less than Y");
            else if (ifx == ify)
                Console.WriteLine("X = Y");
            else
                Console.WriteLine("X is larger than Y");
            Console.WriteLine("/*****************/");
            Console.WriteLine("Enter two integers fo IFs");
            int ix2 = Convert.ToInt32(Console.ReadLine());
            int iy2 = Convert.ToInt32(Console.ReadLine());
            if (ix2 > iy2)
                Console.WriteLine("ix2 > iy2");
            else if (ix2 < iy2)
                Console.WriteLine("ix2 < iy2");
            if (ix2 > iy2 && ix2 == iy2)
                Console.WriteLine("ix2>iy2 & ix2==iy2");
            Console.WriteLine("");
            //for while and do-while
            Console.WriteLine("/*****************/");
            Console.WriteLine("Loops");
            int i = 0;
            for (i = 0; i < 6; i++)
                Console.WriteLine($"for {i}");
            i = 0;
            while (i < 6)
            {
                Console.WriteLine($"While {i}");
                i++;
            }
            i = 0;
            do
            {
                Console.WriteLine($"Do-While {i}");
                i++;
            } while (i < 6);
            //switches
            Console.WriteLine("/*****************/");
            Console.WriteLine("Switches");
            Console.WriteLine("Enter an integer for switch");
            int switched = Convert.ToInt32(Console.ReadLine());
            switch (switched)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2"); ;
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            //arrays
            Console.WriteLine("/************/\nArrays");
            string[] strings = new string[5];
            strings[0] = "S1";
            strings[1] = "S2";
            strings[2] = "S3";
            strings[3] = "S4";
            strings[4] = "S5";
            Console.WriteLine($"Item 1: {strings[0]}");
        }
    }
}
