using System;
using System.Collections.Generic;
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
        public void SearchModule(string moduleCode)
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
        }


        // Read Module
        public List<Module> ReadModule()
        {
            string viewquery = @"SELECT * FROM modules";
            connection.Open();
            command = new SqlCommand(viewquery, connection);

            try
            {
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    modules.Add(new Module(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
            finally
            {
                connection.Close();
            }
            return modules;
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
            string queryUpdate = $@"UPDATE modules SET modCode='{moduleCode}', modName='{moduleName}', modDesc='{moduleDescription}', link='{moduleLink}' WHERE StudentID='{moduleCode}'";
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


        // Search Student
        public void SearchStudent(string studentID)
        {
            dataReader = null;

            string querySearch = $@"SELECT * FROM students WHERE stdNum='{studentID}'";
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
        }


        // Read Student
        public List<Student> ReadStudent()
        {
            string viewquery = @"SELECT * FROM students";
            connection.Open();
            command = new SqlCommand(viewquery, connection);

            try
            {
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    students.Add(new Student(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString(), dataReader[0].ToString(), DateTime.Parse(dataReader[0].ToString())));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
            finally
            {
                connection.Close();
            }
            return students;
        }


        // Create Student
        public void CreateStudent(string studentNumber, string studentName, string studentSurname, string studentImage, string studentGender, string studentPhone, string studentAddress, string moduleCodes, DateTime studentDOB)
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
        public void UpdateStudent(string studentID, string studentName, string studentSurname, DateTime studentDOB, string studentGender, string studentPhone, string studentAddress, string moduleCode, string studentImage)
        {
            string queryUpdate = $@"UPDATE students SET stdNum='{studentID}', stdName='{studentName}', stdSurname='{studentSurname}', stdImage='{studentImage}', dateObirth='{studentDOB}' ,gender='{studentGender}', phoneNum='{studentPhone}', address='{studentAddress}', moduleCode='{moduleCode}' WHERE StudentID='{studentID}'";
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
            string queryDelete = $@"DELETE FROM students WHERE stdNum='{studentID}')";
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