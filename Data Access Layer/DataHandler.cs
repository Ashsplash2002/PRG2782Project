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

    //    //might need to change settings in Sql Configuration Manager. 'SQL Server' must be running. Enable TCP/IP.
    //    string connect = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=;Integrated Security=sspi";
    //    SqlConnection conn;
    //    SqlCommand cmd;
    //    SqlDataReader rdr;




    //    List<Module> modules = new List<Module>();
    //    List<Student> students = new List<Student>();
    //    List<Login> logins = new List<Login>();


    //    //shouldn't these go in file handler class? There are 6 here.
    //    public void WriteStudent(string studentNumber, string studentName, string studentSurname, string studentImage, string studentGender, string studentPhone, string studentAddress, string moduleCodes, DateTime studentDOB)
    //    {
    //        string queryinsert = @"Insert into students  Values('" + studentNumber + "','" + studentName + "','" + studentSurname + "','" + studentImage + "','" + studentGender +
    //            "','" + studentPhone + "','" + studentAddress + "','" + moduleCodes + "','" + studentDOB + "')";
    //        conn = new SqlConnection(connect);
    //        conn.Open();
    //        cmd = new SqlCommand(queryinsert, conn);
    //        try
    //        {
    //            cmd.ExecuteNonQuery();
    //            MessageBox.Show("Student details saved successfully");
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Details not saved: " + ex);
    //        }
    //        finally
    //        {
    //            conn.Close();
    //        }
    //    }

    //    public List<Module> ReadModule()
    //    {
    //        string viewquery = @"Select * from tblStudents";
    //        conn = new SqlConnection(connect);
    //        conn.Open();
    //        cmd = new SqlCommand(searchquery, conn);

    //        List<Student> list = new List<Student>();
    //        Student obj = new Student();
    //        try
    //        {
    //            rdr = cmd.ExecuteReader();

    //            while (rdr.Read())
    //            {
    //                obj.StudentID = rdr[0].ToString();
    //                obj.Name = rdr[1].ToString();
    //                obj.Surname = rdr[2].ToString();
    //                obj.CourseID = rdr[3].ToString();

    //                list.Add(new Student(obj.StudentID, obj.Name, obj.Surname, obj.CourseID));
    //            }

    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Something went wrong: " + ex);
    //        }
    //        finally
    //        {
    //            conn.Close();
    //        }
    //        return list;
    //    }



    //    public void WriteModule(string moduleCode, string moduleName, string moduleDescription, string moduleLink)
    //    {
    //        string queryinsert = @"Insert into modules Values('" + moduleCode + "','" + moduleName + "','" + moduleDescription + "','" + moduleLink + "')";
    //        conn = new SqlConnection(connect);
    //        conn.Open();
    //        cmd = new SqlCommand(queryinsert, conn);
    //        try
    //        {
    //            cmd.ExecuteNonQuery();
    //            MessageBox.Show("Module details saved successfully");
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Details not saved: " + ex);
    //        }
    //        finally
    //        {
    //            conn.Close();
    //        }
    //    }

    //    public List<Student> ReadStudent()
    //    {
    //        string viewquery = @"Select * from tblStudents";
    //        conn = new SqlConnection(connect);
    //        conn.Open();
    //        cmd = new SqlCommand(searchquery, conn);

    //        List<Student> list = new List<Student>();
    //        Student obj = new Student();
    //        try
    //        {
    //            rdr = cmd.ExecuteReader();

    //            while (rdr.Read())
    //            {
    //                obj.StudentID = rdr[0].ToString();
    //                obj.Name = rdr[1].ToString();
    //                obj.Surname = rdr[2].ToString();
    //                obj.CourseID = rdr[3].ToString();

    //                list.Add(new Student(obj.StudentID, obj.Name, obj.Surname, obj.CourseID));
    //            }

    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Something went wrong: " + ex);
    //        }
    //        finally
    //        {
    //            conn.Close();
    //        }
    //        return list;
    //    }





    //    //4 DataHandler Methods Added:
    //    public void studentDelete(string studentID)
    //    {
    //        string queryDelete = @"Delete from students Where StudentID=('" + studentID + "')";
    //        conn = new SqlConnection(connect);
    //        conn.Open();
    //        cmd = new SqlCommand(queryinsert, conn);
    //        try
    //        {
    //            cmd.ExecuteNonQuery();
    //            MessageBox.Show("Student details deleted successfully");
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Details not saved: " + ex);
    //        }
    //        finally
    //        {
    //            conn.Close();
    //        }

    //    }

    //    public void studentSearch(string studentID)
    //    {
    //        SqlDataReader rdr = null;

    //        string querySearch = @"Select * from students Where id=('" + studentID + "')";

    //        conn.Open();

    //        SqlCommand cmd = new SqlCommand(querySearch, conn);

    //        try
    //        {
    //            rdr = cmd.ExecuteReader();
    //            MessageBox.Show("Search successful");
    //        }
    //        catch (Exception)
    //        {
    //            MessageBox.Show("Search failed");
    //        }
    //        finally
    //        {
    //            conn.Close();
    //        }
    //    }

    //    public void moduleDelete(string moduleID)
    //    {
    //        string queryDelete = @"Delete from modules Where StudentID=('" + moduleID + "')";
    //        conn = new SqlConnection(connect);
    //        conn.Open();
    //        cmd = new SqlCommand(queryinsert, conn);
    //        try
    //        {
    //            cmd.ExecuteNonQuery();
    //            MessageBox.Show("Student details deleted successfully");
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Details not saved: " + ex);
    //        }
    //        finally
    //        {
    //            conn.Close();
    //        }
    //    }

    //    public void studentUpdate(string studentID, string studentName, string studentSurname, string studentDOB, string studentGender, string studentPhone, string studentAddress, string moduleCode)
    //    {
    //        string queryUpdate = @"Update tblStudents Set StudentID=('" + studentID + "'), StudentName=('" + name + "'), LastName=('" + surname + "'), CourseID=('" + courseID + "') Where StudentID=('" + studentID + "')";
    //        conn = new SqlConnection(connect);
    //        conn.Open();
    //        cmd = new SqlCommand(queryUpdate, conn);
    //        try
    //        {
    //            cmd.ExecuteNonQuery();
    //            MessageBox.Show("Student details update successfully");
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Details not updated: " + ex);
    //        }
    //        finally
    //        {
    //            conn.Close();
    //        }
    //    }
    //    public void moduleUpdate()
    //    {
    //        string queryUpdate = @"Update tblStudents Set StudentID=('" + studentID + "'), StudentName=('" + name + "'), LastName=('" + surname + "'), CourseID=('" + courseID + "') Where StudentID=('" + studentID + "')";
    //        conn = new SqlConnection(connect);
    //        conn.Open();
    //        cmd = new SqlCommand(queryUpdate, conn);
    //        try
    //        {
    //            cmd.ExecuteNonQuery();
    //            MessageBox.Show("Student details update successfully");
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Details not updated: " + ex);
    //        }
    //        finally
    //        {
    //            conn.Close();
    //        }
    //    }

    //    public void moduleSearch(string studentID)
    //    {
    //        SqlDataReader rdr = null;

    //        string querySearch = @"Select * from students Where id=('" + studentID + "')";

    //        conn.Open();

    //        SqlCommand cmd = new SqlCommand(querySearch, conn);

    //        try
    //        {
    //            rdr = cmd.ExecuteReader();
    //            MessageBox.Show("Search successful");
    //        }
    //        catch (Exception)
    //        {
    //            MessageBox.Show("Search failed");
    //        }
    //        finally
    //        {
    //            conn.Close();
    //        }
    //    }
    }
}