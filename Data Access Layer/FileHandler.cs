using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2782Project.Data_Access_Layer
{
    internal class FileHandler
    {
        public void WriteLogin(Login login)
        {
            string path = Directory.GetCurrentDirectory();
            path += @"..\..\..\LoginDetails\LoginDetials.txt";

            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);

                bool Contains1 = login.Username.Contains(",");
                bool Contains2 = login.Password.Contains(",");

                if (!string.IsNullOrEmpty(login.Username) && !string.IsNullOrEmpty(login.Password))
                {
                    if ((Contains1 == false) && (Contains2 == false))
                    {
                        string encoded = Base64Encode($"{login.Username};{login.Password}");

                        using (streamWriter)
                        {
                            streamWriter.WriteLine(encoded);
                        }

                        streamWriter.Close();
                        fileStream.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login Details contains comma");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            MessageBox.Show("Student Details Captured");
        }

        public List<Login> ReadLogin()
        {
            List<Login> logins = new List<Login>();

            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);

                string fileData = string.Empty;
                while ((fileData = streamReader.ReadLine()) != null)
                {
                    logins.Add(new Login((fileData.Split(';'))[0], (fileData.Split(';'))[1]));
                }

                streamReader.Close();
                fileStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return logins;
        }


        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
