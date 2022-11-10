using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace PRG2782Project
{

    internal class DataHandler
    {

        //might need to change settings in Sql Configuration Manager. 'SQL Server' must be running. Enable TCP/IP.
        string connect = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=PRG2782Project;Integrated Security=sspi";
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
            string viewquery = @"Select * from modules";
            conn = new SqlConnection(connect);
           conn.Open();
            cmd = new SqlCommand(viewquery, conn);

            List<Module> module = new List<Module>();
            Module obj = new Module();
            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    obj.ModuleCode = rdr[0].ToString();
                    obj.ModuleName = rdr[1].ToString();
                    obj.ModuleDescription = rdr[2].ToString();
                    obj.ModuleLink = rdr[3].ToString();

                   module.Add(new Module(obj.ModuleCode, obj.ModuleName, obj.ModuleDescription, obj.ModuleLink));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
            finally
            {
                conn.Close();
            }
            return module;
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
            string viewquery = @"Select * from students";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(viewquery, conn);

            List<Student> list = new List<Student>();
            Student obj = new Student();
            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
               {
                    obj.StudentNumber = rdr[0].ToString();
                    obj.StudentName = rdr[1].ToString();
                    obj.StudentSurname = rdr[2].ToString();
                    obj.StudentImage = rdr[3].ToString();
                    obj.StudentDOB = DateTime.Parse(rdr[4].ToString());
                    obj.StudentGender = rdr[5].ToString();
                    obj.StudentPhone = rdr[6].ToString();
                    obj.StudentAddress = rdr[7].ToString();
                    obj.ModuleCodes = rdr[8].ToString();

                    list.Add(new Student(obj.StudentNumber, obj.StudentName, obj.StudentSurname, obj.StudentImage,  obj.StudentGender, obj.StudentPhone, obj.StudentAddress, obj.ModuleCodes,obj.StudentDOB));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }





        //4 DataHandler Methods Added:
        public void studentDelete(string studentID)
        {
            string queryDelete = @"Delete from students Where stdNum=('" + studentID + "')";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(queryDelete, conn);
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

            string querySearch = @"Select * from students Where stdNum=('" + studentID + "')";

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
            string queryDelete = @"Delete from modules Where modCode=('" + moduleID + "')";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(queryDelete, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Module details deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not deleted: " + ex);
           }
            finally
            {
                conn.Close();
            }
        }

        public void studentUpdate(string studentID, string studentName, string studentSurname, DateTime studentDOB, string studentGender, string studentPhone, string studentAddress, string moduleCode,string studentImage)
        {
            string queryUpdate = @"Update students Set stdNum=('" + studentID + "'), stdName=('" + studentName + "'), stdSurname=('" + studentSurname + "'), stdImage=('" + studentImage + "'),dateObirth=('" + studentDOB + "') " +
                ",gender=('" + studentGender + "'),phoneNum=('" + studentPhone + "'),address=('" + studentAddress + "'),moduleCode=('" + moduleCode + "') Where StudentID=('" + studentID + "')";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(queryUpdate, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student details update successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not updated: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void moduleUpdate(string moduleCode, string moduleName, string moduleDescription, string moduleLink)
       {
            string queryUpdate = @"Update modules Set modCode=('" + moduleCode + "'), modName=('" + moduleName + "'), modDesc=('" + moduleDescription + "'), link=('" + moduleLink + "') Where StudentID=('" + moduleCode + "')";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(queryUpdate, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student details update successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not updated: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void moduleSearch(string moduleCode)
        {
            SqlDataReader rdr = null;

            string querySearch = @"Select * from modules Where modCode=('" + moduleCode + "')";

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
    }
}