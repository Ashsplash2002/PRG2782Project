using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PRG2782Project
{

    internal class DataHandler
    {
        // Might need to change settings in Sql Configuration Manager. 'SQL Server' must be running. Enable TCP/IP.

        SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS; Initial Catalog=PRG2782Project;Integrated Security=sspi");
        SqlCommand command;
        SqlDataReader dataReader;


        List<Module> modules = new List<Module>();
        List<Student> students = new List<Student>();


        // Search Module
        public List<Module> SearchModule(string moduleCode)
        {
            dataReader = null;

            string querySearch = $@"SELECT * FROM modules WHERE modCode='{moduleCode}'";
            connection.Open();
            command = new SqlCommand(querySearch, connection);

            try
            {
                dataReader = command.ExecuteReader();
                MessageBox.Show("Search successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Search failed");
            }
            finally
            {
                connection.Close();
            }
            return modules;
        }


        
        public DataTable ReadModule()
        {
            string query = @"Select * from modules";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            //dgvshow.DataSource = dt;
        }


        // Create Module
        public void CreateModule(string moduleCode, string moduleName, string moduleDescription, string moduleLink)
        {
            string queryinsert = @"INSERT INTO modules VALUES('" + moduleCode + "','" + moduleName + "','" + moduleDescription + "','" + moduleLink + "')";
            connection.Open();
            command = new SqlCommand(queryinsert, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Module details saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not saved: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }


        // Update Module
        public void UpdateModule(string moduleCode, string moduleName, string moduleDescription, string moduleLink)
        {
            string queryUpdate = $@"UPDATE modules SET modCode='{moduleCode}', modName='{moduleName}', modDesc='{moduleDescription}', link='{moduleLink}' WHERE modCode='{moduleCode}'";
            connection.Open();
            command = new SqlCommand(queryUpdate, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Student details update successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not updated: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }


        // Delete Module
        public void DeleteModule(string moduleID)
        {
            string queryDelete = $@"DELETE FROM modules WHERE modCode='{moduleID}'";
            connection.Open();
            command = new SqlCommand(queryDelete, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Module details deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not deleted: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }


        
        public List<Student> SearchStudent(string studentID)
        {
            string querySearch = $@"SELECT * FROM students WHERE stdNum='{studentID}'";
            connection.Open();
            command = new SqlCommand(querySearch, connection);

            List<Student> mystudent = new List<Student>();

            Student objstudent = new Student();

            try
            {
                dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    objstudent.StudentNumber = int.Parse(dataReader[0].ToString());
                    objstudent.StudentName = dataReader[1].ToString();
                    objstudent.StudentSurname = dataReader[2].ToString();
                    objstudent.StudentImage = dataReader[3].ToString();
                    objstudent.StudentGender = dataReader[4].ToString();
                    objstudent.StudentPhone = dataReader[5].ToString();
                    objstudent.StudentAddress = dataReader[6].ToString();
                    objstudent.ModuleCodes = dataReader[7].ToString();
                    objstudent.StudentDOB = Convert.ToDateTime(dataReader[8].ToString());

                    mystudent.Add(new Student(objstudent.StudentNumber, objstudent.StudentName, objstudent.StudentSurname, objstudent.StudentImage, objstudent.StudentGender, objstudent.StudentPhone, objstudent.StudentAddress, objstudent.ModuleCodes, objstudent.StudentDOB));
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error " + er);
            }
            finally
            {
                connection.Close();
            }
            return mystudent;
        }

        //Used for see all button
        public DataTable ReadStudent()
        {
     
            string seeallquery = @"SELECT * FROM students";
            SqlDataAdapter da = new SqlDataAdapter(seeallquery, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
     
        }

        // Read Student
        //public List<Student> ReadStudent()
        //{
        //    string viewquery = @"SELECT * FROM students";
        //    connection.Open();
        //    command = new SqlCommand(viewquery, connection);

        //    try
        //    {
        //        dataReader = command.ExecuteReader();

        //        while (dataReader.Read())
        //        {
        //            students.Add(new Student(int.Parse(dataReader[0].ToString()), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), DateTime.Parse(dataReader[8].ToString())));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Something went wrong: " + ex);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return students;
        //}


        // Create Student
        public void CreateStudent(int studentNumber, string studentName, string studentSurname, string studentImage, string studentGender, string studentPhone, string studentAddress, string moduleCodes, DateTime studentDOB)
        {
            string queryinsert = $@"INSERT INTO students  VALUES('{studentNumber}','{studentName}','{studentSurname}','{studentImage}','{studentGender}','{studentPhone}','{studentAddress}','{moduleCodes}','{studentDOB}')";
            connection.Open();
            command = new SqlCommand(queryinsert, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Student details saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not saved: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }


        // Update Student
        //took out modulecode: string moduleCode; moduleCode='{moduleCode}'
        public void UpdateStudent(string studentID, string studentName, string studentSurname, DateTime studentDOB, string studentGender, string studentPhone, string studentAddress, string studentImage)
        {
            string queryUpdate = $@"UPDATE students SET stdNum='{studentID}', stdName='{studentName}', stdSurname='{studentSurname}', stdImage='{studentImage}', dateObirth='{studentDOB}' ,gender='{studentGender}', phoneNum='{studentPhone}', address='{studentAddress}'  WHERE stdNum='{studentID}'";
            connection.Open();
            command = new SqlCommand(queryUpdate, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Student details update successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not updated: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }


        // Delete Student
        public void DeleteStudent(string studentID)
        {
            string queryDelete = @"DELETE FROM students WHERE stdNum='" + studentID + "'";
            connection.Open();
            command = new SqlCommand(queryDelete, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Student details deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not saved: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}