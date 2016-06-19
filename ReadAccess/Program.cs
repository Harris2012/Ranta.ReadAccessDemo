using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            var connString = ConfigurationManager.ConnectionStrings["RantaMasterAccess"].ConnectionString;

            StudentDal studentDal = new StudentDal();

            using (var oleConn = ConnectionProvider.GetConnection(connString))
            {
                var student = new Student();

                studentDal.InsertStudent(student, oleConn);
            }
        }
    }
}
