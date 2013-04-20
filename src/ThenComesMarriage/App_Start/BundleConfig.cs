using System.Web.Optimization;

namespace ThenComesMarriage.App_Start
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));
			
			bundles.Add(new ScriptBundle("~/bundles/kube").Include(
				 "~/Scripts/kube.buttons.js",
				 "~/Scripts/kube.tabs.js")
			);

			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new StyleBundle("~/kube").Include("~/Style/kube.css"));
			bundles.Add(new StyleBundle("~/css").Include("~/Style/master.css"));

		}
	}
}