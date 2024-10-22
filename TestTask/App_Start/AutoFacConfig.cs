using System.Configuration;
using System.Web.Configuration;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using TestTask.Repository;

namespace TestTask
{
    public class AutoFacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            
            builder.RegisterType<UserRepository>().As<IUserRepository>().WithParameter("connectionString", WebConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);

            var container = builder.Build();
            
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}