﻿using System.Web;
using System.Web.Optimization;

namespace WebApplicationAngularJS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/CRUDApp").IncludeDirectory(
                "~/Scripts/Controller", "*.js").Include(
                "~/Scripts/CRUDApp.js"));

            BundleTable.EnableOptimizations = false;
        }
    }
}
