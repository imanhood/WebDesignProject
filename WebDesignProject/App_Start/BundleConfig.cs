using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebDesignProject
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts/main")
               .Include("~/scripts/main.js")
               );
            bundles.Add(new ScriptBundle("~/bundles/jquery")
               .Include("~/scripts/jquery-3.6.0.min.js")
            );
            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs")
               .Include("~/scripts/bootstrap.min.js")
            );
            bundles.Add(new StyleBundle("~/bundles/bootstrap")
               .Include("~/content/bootstrap.min.css")
               //.Include("~/content/bootstrap.rtl.min.css")
            );
            bundles.Add(new StyleBundle("~/content/main")
                .Include("~/content/main.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}