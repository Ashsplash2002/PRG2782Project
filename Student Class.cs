using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2782Project
{
    internal class StudentClass
    {
        private string stdNum, stdName, stdSurname, stdImage,gender,phoneNum,address,moduleCode;
        private DateTime dateObirth;

        public StudentClass(string stdNum, string stdName, string stdSurname, string stdImage, string gender, string phoneNum, string address, string moduleCode, DateTime dateObirth)
        {
            this.stdNum = stdNum;
            this.stdName = stdName;
            this.stdSurname = stdSurname;
            this.stdImage = stdImage;
            this.gender = gender;
            this.phoneNum = phoneNum;
            this.address = address;
            this.moduleCode = moduleCode;
            this.dateObirth = dateObirth;
        }

        public string StdNum { get => stdNum; set => stdNum = value; }
        public string StdName { get => stdName; set => stdName = value; }
        public string StdSurname { get => stdSurname; set => stdSurname = value; }
        public string StdImage { get => stdImage; set => stdImage = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Address { get => address; set => address = value; }
        public string ModuleCode { get => moduleCode; set => moduleCode = value; }
        public DateTime DateObirth { get => dateObirth; set => dateObirth = value; }
    }
}
