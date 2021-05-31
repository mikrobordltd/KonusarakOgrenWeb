using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(KonusarakOgren.Web.Startup))]

namespace KonusarakOgren.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
