using PmTool.DAL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PmTool.DATA;


namespace PmTool.DAL.Interfaces
{
    public interface IProject
    {
        List<Projects> ListProjects();
        void AddProject(Projects projects);

        List<Projects> ListProjectsPerType(int idType);
    }
}
