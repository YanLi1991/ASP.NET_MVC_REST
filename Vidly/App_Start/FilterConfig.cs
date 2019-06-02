using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            // login to the index page
            filters.Add(new AuthorizeAttribute());

            // add ssl
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
