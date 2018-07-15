using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PmTool.DATA;
using PmTool.DAL.Interfaces;
using ServiceStack.OrmLite;


namespace PmTool.DAL.Metodos
{
    public class MProject : MBase, IProject
    {
        public List<Projects> ListProjects()
        {
            try
            {
                return _db.Select<Projects>();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void AddProject(Projects projects)
        {
            try
            {
                _db.Insert(projects);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Projects> ListProjectsPerType(int idType)
        {
            return _db.Select<Projects>(x => x.Project_type == idType);
        }

        public List<ProjectView> ListProjectView()
        {
            return _db.SqlList<ProjectView>("EXEC sp_ListProjects");
        }
    }
}
