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
    public class MUser : MBase, IUser
    {

        public List<Users> ListUsers()
        {
            return _db.Select<Users>();

        }

        public void AddUser(Users user)
        {
            try
            {
                _db.Insert(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public Users BuscarUsuario(string usuario, string contraseña)
        {

            //b.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
            return _db.Where<Users>(x => x.User_name.Equals(usuario) && x.User_password.Equals(contraseña)).FirstOrDefault();

            //return _db.Select<Users>(x => x.User_name == usuario).FirstOrDefault();
        }

        
    }
}
