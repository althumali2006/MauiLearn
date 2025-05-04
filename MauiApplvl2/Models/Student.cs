using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiApplvl2.Models
{
    class Student
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
