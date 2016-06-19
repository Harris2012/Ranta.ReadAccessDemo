using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAccess
{
    internal class ConnectionProvider
    {
        public static OleDbConnection GetConnection(string connString)
        {
            var odbcConn = new OleDbConnection(connString);

            odbcConn.Open();

            return odbcConn;
        }
    }
}
