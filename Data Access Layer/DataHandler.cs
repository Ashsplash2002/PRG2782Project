using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2782Project
{

    internal class DataHandler
    {

        //might need to change settings in Sql Configuration Manager. 'SQL Server' must be running. Enable TCP/IP.
        public SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=databasename;Integrated Security=SSPI");



        
        List<Module> modules = new List<Module>();
        List<Student> students = new List<Student>();
        List<Login> logins = new List<Login>();


        //shouldn't these go in file handler class? There are 6 here.
        public void WriteModule()
        {

        }

        public List<Module> ReadModule()
        {
            return modules;
        }



        public void WriteStudent()
        {

        }

        public List<Student> ReadStudent()
        {
            return students;
        }



        public void WriteLogin()
        {

        }

        public List<Login> ReadLogin()
        {
            return logins;
        }


        //4 DataHandler Methods Added:
        public void studentDelete()
        {


        }

        public void studentSearch()
        {
            //uses console at the moment; can change later

            SqlDataReader rdr = null;

            conn.Open();

            //input Sql commmand here:
            SqlCommand cmd = new SqlCommand("", conn);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //it stores it's information in index format.
                Console.WriteLine(rdr[1] + " " + rdr[2]);
            }

            conn.Close();

            Console.ReadLine();
        }

        public void studentRead()
        {

        }

        public void studentUpdate()
        {

        }
    }
}
