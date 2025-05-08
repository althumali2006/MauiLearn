using MauiApplvl2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApplvl2.Data
{
    class SqlService
    {
        private static SqlHelper sql = new SqlHelper();
        private static SQLiteConnection SqlConn = sql.conn;
        //To Add Data
        internal int insert(Student student)
        {
            var res=SqlConn.Insert(student);
            return res;
        }
        //To Get Data
        internal List<Student> GetAll()
        {
            return SqlConn.Table<Student>().ToList();
        }
        //To Find by Id
        internal Student GetStudent(long id)
        {
            return SqlConn.Find<Student>(id);
        }
        //To Update Student
        internal int UpdateStudent(Student student)
        {
            return SqlConn.Update(student);
        }
        //To Delete Student
        internal int DeleteStudent(Student student)
        {
            return SqlConn.Delete(student);
        }
    }
}
