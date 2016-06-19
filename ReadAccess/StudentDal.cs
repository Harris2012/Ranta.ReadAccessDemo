using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAccess
{
    public class StudentDal
    {
        public List<Student> GetStudent(OleDbConnection oleConn)
        {
            List<Student> list = new List<Student>();

            var oleCmd = new OleDbCommand();
            oleCmd.Connection = oleConn;
            oleCmd.CommandText = "SELECT ID, StudentName, Age FROM Student";

            var reader = oleCmd.ExecuteReader();
            while (reader.Read())
            {
                var student = new Student();

                student.ID = Convert.ToInt64(reader["ID"]);
                student.StudentName = reader["StudentName"].ToString();
                student.Age = Convert.ToInt32(reader["Age"]);

                list.Add(student);
            }

            return list;
        }

        public void InsertStudent(Student student, OleDbConnection oleConn)
        {
            List<Student> list = new List<Student>();

            var oleCmd = new OleDbCommand();
            oleCmd.Connection = oleConn;

            oleCmd.CommandText =
"INSERT INTO LogTable"
+ "("
    + "StudentName,"
    + "Age,"
+ ")"
+ "VALUES"
+ "("
+ "'" + student.StudentName
+ "','" + student.Age
+ "')";

            var count = oleCmd.ExecuteNonQuery();
        }
    }
}
