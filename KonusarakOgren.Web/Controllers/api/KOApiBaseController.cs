using AutoMapper;
using KonusarakOgren.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace KonusarakOgren.Web.Controllers.api
{
    public class KOApiBaseController : ApiController
    {
        protected SqlClient SqlClient { get; set; } = new SqlClient();

    }
}
