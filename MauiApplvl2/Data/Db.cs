using MauiApplvl2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApplvl2.Data
{
    class Db
    {
        List<Person> People = new List<Person>
        {
            new Person()
            {
                Name="Ahmed",
                Age=21
            },
            new Person()
            {
                Name="Saad",
                Age=20
            },
            new Person()
            {
                Name="Saeed",
                Age=19
            },
            new Person()
            {
                Name="Rashid",
                Age=18
            }
        };
        public List<Person> GetAll()
        {
            return People;
        }
    }
}
