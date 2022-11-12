using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2782Project
{
    internal class Student
    {
        private string studentNumber, studentName, studentSurname, studentImage, studentGender, studentPhone, studentAddress, moduleCodes;
        private DateTime studentDOB;

        public Student()
        {

        }
        public Student(string studentNumber, string studentName, string studentSurname, string studentImage, string studentGender, string studentPhone, string studentAddress, string moduleCodes, DateTime studentDOB)
        {
            this.StudentNumber = studentNumber;
            this.StudentName = studentName;
            this.StudentSurname = studentSurname;
            this.StudentImage = studentImage;
            this.StudentGender = studentGender;
            this.StudentPhone = studentPhone;
            this.StudentAddress = studentAddress;
            this.ModuleCodes = moduleCodes;
            this.StudentDOB = studentDOB;
        }

        public string StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentSurname { get => studentSurname; set => studentSurname = value; }
        public string StudentImage { get => studentImage; set => studentImage = value; }
        public string StudentGender { get => studentGender; set => studentGender = value; }
        public string StudentPhone { get => studentPhone; set => studentPhone = value; }
        public string StudentAddress { get => studentAddress; set => studentAddress = value; }
        public string ModuleCodes { get => moduleCodes; set => moduleCodes = value; }
        public DateTime StudentDOB { get => studentDOB; set => studentDOB = value; }
    }
}
