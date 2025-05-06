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
    }
}
