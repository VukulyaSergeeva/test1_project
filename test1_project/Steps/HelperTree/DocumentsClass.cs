using System;
namespace test1_project.Steps.HelperTree
{
	public class DocumentsClass:HomeClass
	{
		public WorkSpaceClass workspace = new WorkSpaceClass();
        public OfficeClass office = new OfficeClass();
        
        public new string GetPath()
        {
            return base.GetPath() + "documents";
        }
        
    }
}

