using System.Web;
using System.Web.Mvc;

namespace NguyenDuyThoi_2122110066
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
