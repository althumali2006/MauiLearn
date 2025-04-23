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
        }
    }
}
