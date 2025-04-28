using ConsoleApp1.Models;
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
            //Console.WriteLine("/*****************/");
            //Console.WriteLine("Vars");
            //Console.Title = "Hi App";
            //Console.WriteLine(Console.Title);
            ////Console.WriteLine(Console.ReadLine());
            //Console.WriteLine(89 + 89);
            ////Variables
            //string name = "Ahmed";
            //Console.WriteLine("Name " + name);
            //int age = 43;
            //Console.WriteLine("Age " + age);
            //int x = 10;
            //int y = 15;
            //int z;
            //z = x + y;
            //Console.WriteLine($"Z/2: {z / 2}");
            //string sx = "10";
            //string sy = "15";
            //string sz = sx + sy;
            //Console.WriteLine($"SZ {sz}");
            //double dx = 10;
            //double dy = 15;
            //double dz = dx + dy;
            //Console.WriteLine($"DZ/2 {dz / 2}");
            //float fx = 10.0f;
            //float fy = 15;
            //float fz = fx + fy;
            //Console.WriteLine($"FZ {fz}");
            //Console.WriteLine($"FZ/2 {fz / 2}");
            ////Console.WriteLine(Console.ReadLine());
            //Console.WriteLine(89 + 89);
            ////int ix = Convert.ToInt32(Console.ReadLine());
            //int ix = Convert.ToInt32("21");
            //Console.WriteLine($"IX {ix}");
            //Console.WriteLine("/*****************/");
            //Console.WriteLine("IF");
            //int ifx = 15;
            //int ify = 10;
            //if (ifx < ify)
            //    Console.WriteLine("X is less than Y");
            //if (ifx > ify)
            //    Console.WriteLine("X is larger than Y");
            //if (ifx == ify)
            //    Console.WriteLine("X = Y");
            //if (ifx != ify)
            //    Console.WriteLine("X != Y");
            //if (ifx < ify)
            //    Console.WriteLine("X is less than Y");
            //else
            //    Console.WriteLine("X is not less than Y");
            //if (ifx < ify)
            //    Console.WriteLine("X is less than Y");
            //else if (ifx == ify)
            //    Console.WriteLine("X = Y");
            //else
            //    Console.WriteLine("X is larger than Y");
            //Console.WriteLine("/*****************/");
            //Console.WriteLine("Enter two integers fo IFs");
            //int ix2 = Convert.ToInt32(Console.ReadLine());
            //int iy2 = Convert.ToInt32(Console.ReadLine());
            //if (ix2 > iy2)
            //    Console.WriteLine("ix2 > iy2");
            //else if (ix2 < iy2)
            //    Console.WriteLine("ix2 < iy2");
            //if (ix2 > iy2 && ix2 == iy2)
            //    Console.WriteLine("ix2>iy2 & ix2==iy2");
            //Console.WriteLine("");
            ////for while and do-while
            //Console.WriteLine("/*****************/");
            //Console.WriteLine("Loops");
            //int i = 0;
            //for (i = 0; i < 6; i++)
            //    Console.WriteLine($"for {i}");
            //i = 0;
            //while (i < 6)
            //{
            //    Console.WriteLine($"While {i}");
            //    i++;
            //}
            //i = 0;
            //do
            //{
            //    Console.WriteLine($"Do-While {i}");
            //    i++;
            //} while (i < 6);
            ////switches
            //Console.WriteLine("/*****************/");
            //Console.WriteLine("Switches");
            //Console.WriteLine("Enter an integer for switch");
            //int switched = Convert.ToInt32(Console.ReadLine());
            //switch (switched)
            //{
            //    case 1:
            //        Console.WriteLine("1");
            //        break;
            //    case 2:
            //        Console.WriteLine("2"); ;
            //        break;
            //    case 3:
            //        Console.WriteLine("3");
            //        break;
            //    default:
            //        Console.WriteLine("default");
            //        break;
            //}
            ////arrays
            //Console.WriteLine("/*****************/\nArrays");
            //string[] stringsarray = new string[5];
            //stringsarray[0] = "S1";
            //stringsarray[1] = "S2";
            //stringsarray[2] = "S3";
            //stringsarray[3] = "S4";
            //stringsarray[4] = "S5";
            //Console.WriteLine($"Item 1: {stringsarray[0]}");
            //int[] integers = new int[5];
            //integers[0] = 1;
            //integers[1] = 2;
            //integers[2] = 3;
            //integers[3] = 4;
            //integers[4] = 5;
            //Console.WriteLine($"Item 1: {integers[0]}");
            //Console.WriteLine("/*****************/\nFunctions");
            printDate();
            //Classes
            Console.WriteLine("/*****************/\nClasses");
            PersonModel person1 = new PersonModel();
            person1.ID = 1;
            person1.FirstName = "Ahmed";
            person1.LastName = "AlThmali";
            person1.Age = getAge(DateTime.ParseExact("1983/07/06", "yyyy/MM/dd", null));
            PersonModel person2 = new PersonModel()
            {
                ID = 2,
                FirstName = "Ahmed",
                LastName = "AlThmali",
                Age = getAge(DateTime.ParseExact("1983/07/06", "yyyy/MM/dd", null))
            };
            printPerson(person2);
            PersonModel person3 = personer("Ahmed", "AlThmali", getAge(DateTime.ParseExact("1983/07/06", "yyyy/MM/dd", null)));
            printPerson(person3);
            Console.WriteLine("/*****************/\nLists");
            List<PersonModel> persons1 = new List<PersonModel>()
            {
                new PersonModel
            {
                ID = 0,
                FirstName = "Ahmed",
                LastName = "AlThmali",
                Age = getAge(DateTime.ParseExact("1983/07/06", "yyyy/MM/dd", null))
            },
                new PersonModel
            {
                ID = 0,
                FirstName = "Nora",
                LastName = "AlNamlah",
                Age = getAge(DateTime.ParseExact("1989/03/07", "yyyy/MM/dd", null))
            }
            };
            Console.WriteLine("\nPeople in List 1");
            printList(persons1);
            string[] firstNames = new string[] { "Ahmed", "Nora" };
            string[] lastNames = new string[] { "AlThmali", "AlNamlah" };
            int[] ages = new int[] { 41, 36 };
            List<PersonModel> persons2 = Lister(firstNames, lastNames, ages);
            Console.WriteLine("\nPeople in List 2");
            printList(persons2);
        }
        private static void printDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
        private static int getAge(DateTime birthday)
        {
            int years = 0;
            DateTime today = DateTime.Today;
            years = today.Year - birthday.Year;
            if (birthday > today.AddYears(-years))
                years--;
            return years;
        }
        private static void printPerson(PersonModel person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
        }
        private static PersonModel personer(string firstName, string lastName, int age)
        {
            PersonModel person = new PersonModel()
            {
                ID = 2,
                FirstName = firstName,
                LastName = lastName,
                Age = age
            };
            return person;
        }
        private static List<PersonModel> Lister(string[] fNAmes, string[] lNames, int[] ages)
        {
            int counter = fNAmes.Length;
            List<PersonModel> persons = new List<PersonModel>();
            for (int i = 0; i < counter; i++)
            {
                PersonModel person = new PersonModel()
                {
                    ID = i,
                    FirstName = fNAmes[i],
                    LastName = lNames[i],
                    Age = ages[i]
                };
                persons.Add(person);
            }
            return persons;
        }
        private static void printList(List<PersonModel> persons)
        {
            foreach (PersonModel person in persons)
                printPerson(person);
        }
    }
}
