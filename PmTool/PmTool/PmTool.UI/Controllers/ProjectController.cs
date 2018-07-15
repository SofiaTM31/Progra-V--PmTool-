using PmTool.DAL.Interfaces;
using PmTool.DAL.Metodos;
using PmTool.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;


namespace PmTool.UI.Controllers
{
    public class ProjectController : Controller
    {
        IProject pro;
        IProjectType ptype;
        // GET: Project

        public ProjectController()
        {
            pro = new MProject();
            ptype = new MProjectType();
        }
        public ActionResult Index()
        {
            //var listProjects = pro.ListProjects();
            //var theListProjects = Mapper.Map<List<Models.Projects>>(listProjects);
            //return View(theListProjects);
            var listProjects = pro.ListProjects();
            var theListProjects = Mapper.Map<List<Models.ProjectView>>(listProjects);
            return View(theListProjects);
        }

        public ActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(Projects project)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var projectToAdd = Mapper.Map<DATA.Projects>(project);
                pro.AddProject(projectToAdd);
                return RedirectToAction("Index");

            }
            catch (Exception)
            {

                return View();
            }
        }

        [HttpPost]
        public ActionResult ChangeProjectCategory()
        {
            try
            {
                var projectTypes = Request.Form["dllProjectTypes"];
                ViewBag.dllProjectTypes = new SelectList(ptype.ListProjectTypes(), "Project_type_id", "Project_type_name");
                if (projectTypes == string.Empty)
                {
                    var listProjectsypes = pro.ListProjects();
                    var projectToList = Mapper.Map<List<Models.ProjectTypes>>(listProjectsypes);
                    return View("CreateProject", projectToList);
                }
                var idType = Convert.ToInt32(projectTypes);
                var secondProjecTypeList = pro.ListProjectsPerType(idType);
                var projectTypeToList = Mapper.Map<List<Models.ProjectTypes>>(secondProjecTypeList);

                return View("CreateProject", projectTypeToList);
            }
            catch (Exception ex)
            {

                throw ex;
            }
       


        }

    }
}