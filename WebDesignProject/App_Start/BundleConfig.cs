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
            bundles.Add(new ScriptBundle("~/content/main.bundle.js")
               .IncludeDirectory("~/content", "main.*")
               );
            bundles.Add(new StyleBundle("~/content/style.css")
                .IncludeDirectory("~/content", "*.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}