using System.Web;
using System.Web.Mvc;

namespace WK.Orion.Applications.DPM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
