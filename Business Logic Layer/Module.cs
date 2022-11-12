using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2782Project
{
    internal class Module
    {
        private string moduleCode, moduleName, moduleDescription, moduleLink;

        public Module() { }

        public Module(string moduleCode, string moduleName, string moduleDescription, string moduleLink)
        {
            this.moduleCode = moduleLink;
            this.moduleName = moduleName;
            this.moduleDescription = moduleDescription;
            this.moduleLink = moduleLink;
        }

        public string ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string ModuleName { get => moduleName; set => moduleName = value; }
        public string ModuleDescription { get => moduleDescription; set => moduleDescription = value; }
        public string ModuleLink { get => moduleLink; set => moduleLink = value; }
    }
}
