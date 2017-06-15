// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Histamine_v
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField scan_rate_no { get; set; }

        [Outlet]
        AppKit.NSTextField Vmax_no { get; set; }

        [Outlet]
        AppKit.NSTextField Vmin_no { get; set; }

        [Action ("Start_volt_button:")]
        partial void Start_volt_button (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (scan_rate_no != null) {
                scan_rate_no.Dispose ();
                scan_rate_no = null;
            }

            if (Vmin_no != null) {
                Vmin_no.Dispose ();
                Vmin_no = null;
            }

            if (Vmax_no != null) {
                Vmax_no.Dispose ();
                Vmax_no = null;
            }
        }
    }
}
