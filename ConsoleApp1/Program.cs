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
                    Age = AgeFrom("1983/07/06"),
                    Gender="Male"
                },
                new PersonModel
                {
                    ID = 1,
                    FirstName = "Nora",
                    LastName = "AlNamlah",
                    Age = AgeFrom("1989/03/07"),
                    Gender="Female"
                }
            };

            // Note: Using AddRange to add multiple items after initial creation
            persons1.AddRange(new List<PersonModel>
            {
                new PersonModel
                {
                    ID = 2,
                    FirstName = "Abdullah",
                    LastName = "AlThmali",
                    Age = getAge(DateTime.ParseExact("1986/05/12", "yyyy/MM/dd", null)),
                    Gender="Male"
                },
                new PersonModel
                {
                    ID = 3,
                    FirstName = "Amal",
                    LastName = "AlThmali",
                    Age = getAge(DateTime.ParseExact("1992/08/22", "yyyy/MM/dd", null)),
                    Gender="Female"
                },
                new PersonModel
                {
                    ID = 4,
                    FirstName = "Fahad",
                    LastName = "AlThmali",
                    Age = getAge(DateTime.ParseExact("1990/11/30", "yyyy/MM/dd", null)),
                    Gender="Male"
                },
                new PersonModel
                {
                    ID = 5,
                    FirstName = "Iman",
                    LastName = "AlThmali",
                    Age = getAge(DateTime.ParseExact("1987/01/15", "yyyy/MM/dd", null)),
                    Gender="Female"
                },
                new PersonModel
                {
                    ID = 6,
                    FirstName = "Sahar",
                    LastName = "AlThmali",
                    Age = getAge(DateTime.ParseExact("1984/09/10", "yyyy/MM/dd", null)),
                    Gender="Male"
                },
                new PersonModel
                {
                    ID = 7,
                    FirstName = "Aisha",
                    LastName = "AlThmali",
                    Age = getAge(DateTime.ParseExact("1995/04/19", "yyyy/MM/dd", null)),
                    Gender="Female"
                },
                new PersonModel
                {
                    ID = 8,
                    FirstName = "Mohammed",
                    LastName = "Saleh",
                    Age = getAge(DateTime.ParseExact("1979/02/27", "yyyy/MM/dd", null)),
                    Gender="Male"
                },
                new PersonModel
                {
                    ID = 9,
                    FirstName = "Fatimah",
                    LastName = "AlHarthy",
                    Age = getAge(DateTime.ParseExact("1993/06/03", "yyyy/MM/dd", null)),
                    Gender="Female"
                }
            });

            Console.WriteLine("\nPeople in List 1");
            printList(persons1);

            string[] firstNames = new string[] { "Ahmed", "Nora" };
            string[] lastNames = new string[] { "AlThmali", "AlNamlah" };
            int[] ages = new int[] { 41, 36 };
            List<PersonModel> persons2 = Lister(firstNames, lastNames, ages);

            Console.WriteLine("\nPeople in List 2");
            printList(persons2);

            Console.WriteLine("\nClear List 2");
            persons2.Clear();
            printList(persons2);

            Console.WriteLine("\n***********Linq************");
            Console.WriteLine("***********Linq************");
            Console.WriteLine("***********Linq************\n");

            string startSearchWord = "ah";
            string endSearchWord = "ra"; // Declared but not used in active LINQ below
            string containSearchWord = "nam"; // Declared but not used in active LINQ below

            // LINQ Method Syntax Example
            Console.WriteLine($"\nFind V0 by {startSearchWord}\n");
            var res = persons1.Where(item => item.FirstName.ToUpper().StartsWith(startSearchWord.ToUpper()));
            foreach (PersonModel person in res)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
            }

            // Using helper method wrapping LINQ Method Syntax
            Console.WriteLine($"\nFind V1 by {startSearchWord}\n");
            IEnumerable<PersonModel> found = startFinder(persons1, startSearchWord);
            printList(found);

            // Using helper method wrapping LINQ Query Syntax
            Console.WriteLine($"\nFind V2 by {startSearchWord}\n");
            IEnumerable<PersonModel> found2 = startFinderV2(persons1, startSearchWord);
            printList(found2);

            Console.WriteLine($"\nOderBy FirstName V1\n");
            printList(orderByFirstName(persons1));

            Console.WriteLine($"\nOderBy FirstName Desc V1\n");
            printList(orderByFirstNameDesc(persons1));

            Console.WriteLine($"\nOderBy FirstName V2\n");
            printList(orderByFirstNameV2(persons1));

            Console.WriteLine($"\nOderBy FirstName Desc V2\n");
            printList(orderByFirstNameDescV2(persons1));

            Console.WriteLine($"\nGrouping by Gender V0\n");
            GroupByGenderV0(persons1);

            Console.WriteLine($"\nGrouping by Gender V1\n");
            GroupByGenderV1(persons1);

            Console.WriteLine($"\nFirst\n");
            printPerson(returnFirst(persons1));

            Console.WriteLine($"\nFirst Empty List ,error must be handled return System.InvalidOperationException: Sequence contains no elements\n");
            try
            {
                printPerson(returnFirst(persons2));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.WriteLine($"\nFirst or Default Empty List returns null string\n");
            printPerson(returnFirstorDefault(persons2));
            Console.WriteLine($"\nCount non empty\n");
            Console.WriteLine($"Count of persons1 {countList(persons1)}");
            Console.WriteLine($"\nCount empty\n");
            Console.WriteLine($"Count of persons2 {countList(persons2)}");
            Console.WriteLine("\nStats: Average, Sum, Max, Min for Non Empty List\n");
            printStats(GetStats(persons1));
            Console.WriteLine("\nStats: Average, Sum, Max, Min for Empty List will cause System.InvalidOperationException: Sequence contains no elements\n");
            //printStats(GetStats(persons2));
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
            try
            {
                // Assuming person is not null here. Add check if necessary.
                Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age} {person.Gender}");
            }
            catch (Exception ex)
            {
                // Basic exception handling
                Console.WriteLine(ex.Message);
            }
        }

        private static PersonModel personer(string firstName, string lastName, int age)
        {
            // Creates a PersonModel instance. Note the hardcoded ID.
            PersonModel person = new PersonModel()
            {
                ID = 2, // Consider implications of static ID
                FirstName = firstName,
                LastName = lastName,
                Age = age
            };
            return person;
        }

        private static List<PersonModel> Lister(string[] fNAmes, string[] lNames, int[] ages)
        {
            // Assumes arrays are non-null and have matching lengths.
            int counter = fNAmes.Length;
            List<PersonModel> persons = new List<PersonModel>();
            for (int i = 0; i < counter; i++)
            {
                PersonModel person = new PersonModel()
                {
                    ID = i, // Uses loop index for ID
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
            if (persons == null || persons.Count < 1) // Check for null added for safety
                Console.WriteLine($"List is empty or null");
            else
                foreach (PersonModel person in persons)
                    printPerson(person); // Reuse single person print method
        }

        private static void printList(IEnumerable<PersonModel> persons)
        {
            // Using Count() can be inefficient for some IEnumerables, Any() is often preferred.
            // Sticking to original Count() == 0 as requested to not assume changes.
            if (persons == null || persons.Count() == 0) // Check for null added for safety
                Console.WriteLine($"List/Sequence is empty or null");
            else
                foreach (PersonModel person in persons)
                    printPerson(person); // Reuse single person print method
        }

        private static IEnumerable<PersonModel> startFinder(List<PersonModel> persons, string startSearchWord)
        {
            // Assumes 'persons' and 'startSearchWord' are not null, and FirstName on items is not null.
            try
            {
                var res = persons.Where(item => item.FirstName.ToUpper().StartsWith(startSearchWord.ToUpper()));
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; // Original behavior on exception
            }
        }

        private static IEnumerable<PersonModel> startFinderV2(List<PersonModel> persons, string startSearchWord)
        {
            // Assumes 'persons' and 'startSearchWord' are not null, and FirstName on items is not null.
            try
            {
                var res = from person in persons
                          where person.FirstName.ToUpper().StartsWith(startSearchWord.ToUpper())
                          select person;
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; // Original behavior on exception
            }
        }
        private static int AgeFrom(string date) =>
    getAge(DateTime.ParseExact(date, "yyyy/MM/dd", null));
        private static int AgeFrom2(string date)
        {
            return getAge(DateTime.ParseExact(date, "yyyy/MM/dd", null));
        }
        private static IEnumerable<PersonModel> orderByFirstName(List<PersonModel> persons)
        {
            var res = persons.OrderBy(x => x.FirstName);
            return res;
        }
        private static IEnumerable<PersonModel> orderByFirstNameDesc(List<PersonModel> persons)
        {
            var res = persons.OrderByDescending(x => x.FirstName);
            return res;
        }
        private static IEnumerable<PersonModel> orderByFirstNameV2(List<PersonModel> persons)
        {
            var res = from p in persons orderby p.FirstName select p;
            return res;
        }
        private static IEnumerable<PersonModel> orderByFirstNameDescV2(List<PersonModel> persons)
        {
            var res = from p in persons orderby p.FirstName descending select p;
            return res;
        }
        private static void GroupByGenderV0(List<PersonModel> persons)
        {
            var tmpres = persons.GroupBy(x => x.Gender);
            foreach (var item in tmpres)
            {
                Console.WriteLine($"GroupByGenderV0");
                Console.WriteLine(item.Key);
                Console.WriteLine($"---------");
                foreach (var i in item)
                {
                    Console.WriteLine($"{i.ID} {i.FirstName} {i.LastName} {i.Age} {i.Gender}");
                }
                Console.WriteLine();
            }
        }
        private static void GroupByGenderV1(List<PersonModel> persons)
        {
            var tmpres = from p in persons group p by p.Gender;
            foreach (var item in tmpres)
            {
                Console.WriteLine($"GroupByGenderV1");
                Console.WriteLine(item.Key);
                Console.WriteLine($"---------");
                foreach (var i in item)
                {
                    Console.WriteLine($"{i.ID} {i.FirstName} {i.LastName} {i.Age} {i.Gender}");
                }
                Console.WriteLine();
            }
        }
        private static PersonModel returnFirst(List<PersonModel> persons)
        {
            return persons.First();
        }
        private static PersonModel returnFirstorDefault(List<PersonModel> persons)
        {
            return persons.FirstOrDefault();
        }
        private static int countList(List<PersonModel> persons)
        {
            return persons.Count();
        }
        private static StatsModel GetStats(List<PersonModel> persons)
        {
            List<int> AgesList = new List<int>();
            foreach (var i in persons)
            {
                AgesList.Add(i.Age);
            }
            return new StatsModel()
            {
                Sum = AgesList.Sum(),
                Average = AgesList.Average(),
                Max = AgesList.Max(),
                Min = AgesList.Min()
            };
        }
        private static void printStats(StatsModel stats)
        {
            Console.WriteLine($"Sum: {stats.Sum}, Average: {stats.Average}, Max: {stats.Max}, Min: {stats.Min}");
        }
    }
}