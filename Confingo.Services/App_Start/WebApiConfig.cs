using System.Web.Http;
using System.Web.Http.Cors;

namespace Confingo.Services
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Enable Cross domain requests for all origins. We may want to limit this to a finite set.
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
