using System.Web;
using System.Web.Mvc;

namespace HealthCareAppointment_ApiServices
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
