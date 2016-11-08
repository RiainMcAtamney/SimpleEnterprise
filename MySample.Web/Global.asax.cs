using MySample.Data;
using MySample.Web.App_Start;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MySample.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            MySampleContext context = new MySampleContext();
            context.Database.Initialize(true);
            System.Data.Entity.Database.SetInitializer(new MySampleInitialiseDatabase());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Autofac and automapper
            Bootstrapper.Run();
        }
    }
}
