using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonusarakOgren.Web.Data
{
    public class SqlClientBase
    {

        private KodDbContext context;
        protected KodDbContext Context
        {
            get {
                if (context == null)
                    context = new KodDbContext();
                return context;
            }
        }
    }
}