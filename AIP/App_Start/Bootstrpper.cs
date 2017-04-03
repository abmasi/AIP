using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Util;
using Autofac.Builder;
using Autofac.Core;
using AutoMapper;
using System.Reflection;

using AIP.DATA.Infrastructure;
using AIP.DATA.Repositories;
using AIP.Service;
using System.Web.Mvc;
using AIP.Controllers;

namespace AIP
{
   public static  class Bootstrpper
    {
        public static void Run()
        {
            Mappings.AutoMapperConfiguration.Configure();
            SetAutofacContainer();
        }

        private static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();
            IDbFactory dbfacory = new DbFactory();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterInstance(new NewsRepository(dbfacory))
                .As<INewsRepository>();
            //builder.RegisterInstance(new PersonRepository(dbfacory))
                //.As<IPersonRepository>();

            builder.RegisterInstance(new PersonMongoRepository())
                .As<IPersonMongoRepository>();

            //builder.RegisterType<NewsService>().As<INewsService>().InstancePerRequest();

	    //builder.Register(c => new NewsService(c.Resolve<ILogger<ValuesService>>()))
            //    .As<INewsService>()
            //    .InstancePerLifetimeScope();
            

            builder.RegisterAssemblyTypes(typeof(NewsRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(NewsService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerRequest();

            IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
                
        }


    }
}
