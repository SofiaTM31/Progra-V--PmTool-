using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PmTool.UI
{
    public static class AutomapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                // Solo hay un Initialize
                cfg.CreateMap<Models.Users, DATA.Users>();
                cfg.CreateMap<DATA.Users, Models.Users>();
                cfg.CreateMap<Models.Projects, DATA.Projects>();
                cfg.CreateMap<DATA.Projects, DATA.Projects>();
                // Por cada objeto que tenga
            });
        }
    }
}