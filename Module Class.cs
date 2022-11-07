using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2782Project
{
    internal class Module_Class
    {
        private string modCode, modName, modDesc, link;

        public Module_Class(string modCode, string modName, string modDesc, string link)
        {
            this.modCode = modCode;
            this.modName = modName;
            this.modDesc = modDesc;
            this.link = link;
        }

        public string ModCode { get => modCode; set => modCode = value; }
        public string ModName { get => modName; set => modName = value; }
        public string ModDesc { get => modDesc; set => modDesc = value; }
        public string Link { get => link; set => link = value; }
    }
}
