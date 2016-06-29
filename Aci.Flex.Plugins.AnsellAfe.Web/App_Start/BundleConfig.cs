using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Aci.Flex.Plugins.AnsellAfe.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
#if DEBUG
            BundleTable.EnableOptimizations = false;

            bundles.Add(new ScriptBundle("~/bundles/knockout")
                .Include("~/Scripts/_debug/knockout-{version}.debug.js")
                .Include("~/Scripts/_debug/knockout.mapping-latest.debug.js")
                .Include("~/Scripts/_debug/kobindings.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/_debug/jquery-{version}.js")
                .Include("~/Scripts/_debug/jquery-ui-{version}.js")
                .Include("~/Scripts/_debug/jquery.cookie.js")
                .Include("~/Scripts/_debug/jquery.inputmask/jquery.inputmask.js")
                .Include("~/Scripts/_debug/jquery.inputmask/jquery.inputmask.numeric.extensions.js")
                .Include("~/Scripts/_debug/jquery.inputmask/jquery.inputmask.regex.extensions.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/plugins")
                .Include("~/Scripts/_debug/modernizr-*")
                .Include("~/Scripts/_debug/sweetalert2.min.js")
                .Include("~/Scripts/_debug/q.min.js")
                .Include("~/Scripts/_debug/tinymce/tinymce.min.js")
                .Include("~/Scripts/_debug/tinymce/jquery.tinymce.min.js")
                .Include("~/Scripts/_debug/wysiwyg.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Scripts/_debug/bootstrap.min.js")
                .Include("~/Scripts/_debug/bootstrap-modal.js")
                .Include("~/Scripts/_debug/bootstrap-modalmanager.js")                
                .Include("~/Scripts/_debug/bootstrap-select.min.js")
                .Include("~/Scripts/_debug/jquery.bootstrap.wizard.js")
                .Include("~/Scripts/_debug/moment.min.js")
                .Include("~/Scripts/_debug/bootstrap-datetimepicker.min.js")
                .Include("~/Scripts/_debug/bootstrapValidator.min.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/flex")
                .Include("~/Scripts/_debug/system.js")
                .Include("~/Scripts/_debug/ServiceHelper.js")
                .Include("~/Scripts/_debug/afe-debug-variables.js")
                .Include("~/Scripts/_debug/flex-core.js")
                .Include("~/Scripts/_debug/deformifier.js")
                .Include("~/Scripts/_debug/flex-attachments.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/jqueryupload")
                .Include("~/Scripts/_debug/jQuery.FileUpload/load-image.all.min.js")
                .Include("~/Scripts/_debug/jQuery.FileUpload/canvas-to-blob.min.js")
                .Include("~/Scripts/_debug/jQuery.FileUpload/jquery.iframe-transport.js")
                .Include("~/Scripts/_debug/jQuery.FileUpload/jquery.fileupload.js")
                .Include("~/Scripts/_debug/jQuery.FileUpload/jquery.fileupload-process.js")
                .Include("~/Scripts/_debug/jQuery.FileUpload/jquery.fileupload-image.js")
                .Include("~/Scripts/_debug/jQuery.FileUpload/jquery.fileupload-validate.js")
                );

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/_debug/bootstrap.css",
                     "~/Content/_debug/bootstrap-theme.css",
                     "~/Styles/_debug/bootstrap/bootstrap-modal.css",
                     "~/Content/_debug/bootstrap-modal-bs3patch.css",
                     "~/Styles/_debug/Source/base.css",
                     "~/Styles/_debug/Source/box.css",
                     "~/Styles/_debug/Source/dropdowns.css",
                     "~/Styles/_debug/font-awesome.css",
                     "~/Styles/_debug/Source/font-awesome-mixins.css",
                     "~/Styles/_debug/Source/mixin_helpers.css",
                     "~/Styles/_debug/Source/form_elements.css",
                     "~/Styles/_debug/Source/navigation.css",
                     "~/Styles/_debug/Source/sidebar.css",
                     "~/Styles/_debug/Source/breadcrumbs.css",
                     "~/Styles/_debug/Source/select2.css",
                     "~/Styles/_debug/Source/ui_custom.css",
                     "~/Styles/_debug/bootstrap-select.css",
                     "~/Styles/_debug/Source/gritter.css",
                     "~/Styles/_debug/xcharts.css",
                     "~/Styles/_debug/Source/charts.css",
                     "~/Styles/_debug/Source/stats.css",
                     "~/Styles/_debug/Source/badges.css",
                     "~/Styles/_debug/Source/dataTables.css",
                     "~/Styles/_debug/bootstrap-modal-bs3patch.css",
                     "~/Styles/_debug/bootstrap-modal.css",
                     "~/Styles/_debug/jquery.datetimepicker.css",
                     "~/Styles/_debug/Source/action_nav.css",
                     "~/Styles/_debug/Source/news.css",
                     "~/Styles/_debug/Source/content_progress.css",
                     "~/script/_debugs/jsTree3/themes/default/style.min.css",
                     "~/script/_debugs/jsTree3/themes/apple/style.css",
                     "~/Styles/_debug/boostrapValidator.min.css",
                     "~/Styles/_debug/flex.css",
                     "~/Styles/_debug/bootstrap-select.css",
                     "~/Styles/_debug/sweetalert2.css",
                     "~/Styles/_debug/bootstrap/awesome-bootstrap-checkbox.css",
                     "~/Styles/_debug/bootstrap/bootstrap-select.css",
                     "~/Styles/_debug/bootstrap/bootstrap-datetimepicker.min.css",
                     "~/Styles/_debug/jquery.fileupload.css"
                      ));

#else
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}