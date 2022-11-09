using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRG2782Project
{

    internal class DataHandler
    {

        //might need to change settings in Sql Configuration Manager. 'SQL Server' must be running. Enable TCP/IP.
        string connect = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=;Integrated Security=sspi";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;




        List<Module> modules = new List<Module>();
        List<Student> students = new List<Student>();
        List<Login> logins = new List<Login>();


        //shouldn't these go in file handler class? There are 6 here.
        public void WriteStudent(string studentNumber, string studentName, string studentSurname,string studentImage,string studentGender,string studentPhone,string studentAddress,string moduleCodes, DateTime studentDOB)
        {
            string queryinsert = @"Insert into students  Values('" + studentNumber + "','" + studentName + "','" + studentSurname + "','" + studentImage + "','" + studentGender + 
                "','" + studentPhone + "','" + studentAddress + "','" + moduleCodes + "','" + studentDOB + "')";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(queryinsert, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student details saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not saved: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Module> ReadModule()
        {
            return modules;
        }



        public void WriteModule(string moduleCode,string moduleName,string moduleDescription, string moduleLink)
        {
            string queryinsert = @"Insert into modules Values('" + moduleCode + "','" + moduleName + "','" + moduleDescription + "','" + moduleLink + "')";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(queryinsert, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Module details saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not saved: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Student> ReadStudent()
        {
            return students;
        }



        

        //4 DataHandler Methods Added:
        public void studentDelete(string studentID)
        {
            string queryinsert = @"Delete from students Where StudentID=('" + studentID + "')";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(queryinsert, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student details deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not saved: " + ex);
            }
            finally
            {
                conn.Close();
            }

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

        public void moduleDelete(string moduleID)
        {
            string queryinsert = @"Delete from modules Where StudentID=('" + moduleID + "')";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(queryinsert, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student details deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not saved: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void studentUpdate()
        {

        }
    }
}
