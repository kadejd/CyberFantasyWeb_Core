using System.Web;
using System.Web.Mvc;

namespace CyberFantasyWeb_Core
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
