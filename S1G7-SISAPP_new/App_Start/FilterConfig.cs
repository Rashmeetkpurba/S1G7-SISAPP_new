using System.Web;
using System.Web.Mvc;

namespace S1G7_SISAPP_new
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
