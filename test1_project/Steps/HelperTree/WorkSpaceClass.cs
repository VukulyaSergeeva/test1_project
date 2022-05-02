using System;
using System.Collections.Generic;

namespace test1_project.Steps.HelperTree
{
	public class WorkSpaceClass:DocumentsClass
	{
		//public List<string> WorkSpace = new List<string> { "React", "Angular", "Veu" };


        public string react
        {
            get
            {
                return GetPath() + "react";
            }
            private set { }
        }
        public string angular
        {
            get
            {
                return GetPath() + "angular";
            }
            private set { }
        }
        public string Veu
        {
            get
            {
                return GetPath() + "veu";
            }
            set { }
        }

        public new string GetPath()
        {
            return base.GetPath() + "workspace";
        }
    }
}

