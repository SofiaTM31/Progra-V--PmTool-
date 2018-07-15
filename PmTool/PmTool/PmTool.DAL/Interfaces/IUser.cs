﻿using PmTool.DAL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PmTool.DATA;

namespace PmTool.DAL.Interfaces
{
    public interface IUser 
    {
        List<Users> ListUsers();
        void AddUser(Users user);
        Users BuscarUsuario(string usuario, string ontraseña);
        List<Users> ConfirmarContraseña(string usuario);
    }

   
}
