using Autofac;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Registar
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //autofac dependencies
            var builder = new ContainerBuilder();
            //builder.RegisterType<DefaultRepositoryFactory>().As<IRepositoryFactory>();
            //builder.RegisterType<BikeRepository>().As<IBikeRepository>();
           // builder.RegisterType<UserRepository>().As<IUserRepository>();
            // builder.RegisterType<BikeSearchCommand>().As<Command>();
            //builder.RegisterType<BikeSearchResult>().As<CommandResult>();
            //container = builder.Build();


            log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/web.config")));

            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

          

        }
    }
}