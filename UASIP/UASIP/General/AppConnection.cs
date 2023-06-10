using System.Configuration;

namespace UASIP.General
{
    public class AppConnection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ums"].ConnectionString;
        }
    }
}