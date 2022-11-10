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
        public void WriteStudent(string studentNumber, string studentName, string studentSurname, string studentImage, string studentGender, string studentPhone, string studentAddress, string moduleCodes, DateTime studentDOB)
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



        public void WriteModule(string moduleCode, string moduleName, string moduleDescription, string moduleLink)
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

        public void studentSearch(string studentID)
        {
            SqlDataReader rdr = null;

            string querySearch = @"Select * from students Where id=('" + studentID + "')";

            conn.Open();

            SqlCommand cmd = new SqlCommand(querySearch, conn);

            try
            {
                rdr = cmd.ExecuteReader();
                MessageBox.Show("Search successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Search failed");
            }
            finally
            {
                conn.Close();
            }
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

        public void studentUpdate(string studentID, string studentName, string studentSurname, string studentDOB, string studentGender, string studentPhone, string studentAddress, string moduleCode)
        {
            string queryUpdate = @"Update students Set stdName = @studentName, stdSurname = @studentSurname " + "Where id = @studentID";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(queryUpdate, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student name updated successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Student name not updated");
            }
            finally
            {
                conn.Close();
            }
        }
        public void moduleUpdate()
        {

        }
    }
}