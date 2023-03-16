using System.Web;
using System.Web.Mvc;

namespace BigSchool_LuuNguyenTrungTin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
