using AutoMapper;
using KonusarakOgren.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace KonusarakOgren.Web.Controllers
{
    public class KOBaseController : Controller
    {
        protected SqlClient SqlClient { get; set; } = new SqlClient();
        
        protected Mapper Mapper { get; set; } = new Mapper(new MapperConfiguration((cfg) =>
        {
            cfg.AddMaps(Assembly.GetExecutingAssembly());

        }));
    }
}