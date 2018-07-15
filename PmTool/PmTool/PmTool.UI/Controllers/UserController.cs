using PmTool.DAL.Interfaces;
using PmTool.DAL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using PmTool.UI.Models;

namespace PmTool.UI.Controllers
{
    public class UserController : Controller
    {
        IUser use;
        // GET: User

        public UserController()
        {
            use = new MUser();
     
        }
        public ActionResult Index()
        {
            var userList = use.ListUsers();
            var theUserList = Mapper.Map<List<Models.Users>>(userList);
            return View(theUserList);
        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Confirmar_Login()
        {
            /*if (ModelState.IsValid)
            {
                string usuario = Convert.ToString(Request.Form["Usuario"]);
                string contraseña = Convert.ToString(Request.Form["Contraseña"]);
                var obj = use.BuscarUsuario(usuario, contraseña);
                if (obj != null)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {*/
                return RedirectToAction("Index");
            //} 
        }
        public ActionResult Resete_Password1()
        {
            return View();
        }
        public ActionResult Reset_Password2()
        {
            ViewBag.R = "ÑEEEE";
            return View();
        }
        [HttpPost]
        public ActionResult ResetPassword2()
        {
            try
            {
               int longitud = 10;
               Guid miGuid = Guid.NewGuid();
               string token = Convert.ToBase64String(miGuid.ToByteArray());
               token = token.Replace("=", "").Replace("+", "");
                ViewBag.R = (token.Substring(0, longitud));
                return View("Reset_Password2", ViewBag.R = (token.Substring(0, longitud)));
            }
            catch
            {
                return View("Reset_Password2", ViewBag.R = "WOOOW");
            }
        }


        public ActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAccount(Users users)
        {
            ViewBag.TestValue = 1;
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                users.User_type = 1;
                var userToAdd = Mapper.Map<DATA.Users>(users);
                use.AddUser(userToAdd);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}