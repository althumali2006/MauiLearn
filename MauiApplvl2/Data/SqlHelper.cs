using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApplvl2.Models;
using SQLite;

namespace MauiApplvl2.Data
{
    class SqlHelper
    {
        private static string DbName = "Students.db";
        private static string DbPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string DbFullName = Path.Combine(DbName, DbPath);
        public SQLiteConnection conn = new SQLiteConnection(DbFullName);
        internal void GenerateSql()
        {
            conn = new SQLiteConnection(DbFullName, SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite);
            conn.CreateTable<Student>(CreateFlags.None);
        }
    }
}
