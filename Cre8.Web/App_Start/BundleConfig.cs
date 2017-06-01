using System.Web;
using System.Web.Optimization;

namespace Cre8.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css/main/bundle")
                .Include("~/Content/css/main/main.css",
                "~/Content/css/main/reset.css"));

            
        }


    }
}