using System.Configuration;

namespace Storemey
{
    public class StoremeyConsts
    {
        public const string LocalizationSourceName = "Storemey";

        public static string tenantName = string.Empty;

        public static string tenantPassword = string.Empty;

        public static string StoreName = string.Empty;

        public const bool MultiTenancyEnabled = true;

        public static string DomainName = ConfigurationManager.AppSettings["DomainName"].ToString();

        public static bool redirectToLogin = true;
    }
}