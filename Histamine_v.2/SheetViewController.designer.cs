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
    [Register ("SheetViewController")]
    partial class SheetViewController
    {
        [Outlet]
        AppKit.NSTextField _password { get; set; }

        [Outlet]
        AppKit.NSTextField _username { get; set; }

        [Action ("AcceptSheet:")]
        partial void AcceptSheet (Foundation.NSObject sender);

        [Action ("CancelSheet:")]
        partial void CancelSheet (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (_username != null) {
                _username.Dispose ();
                _username = null;
            }

            if (_password != null) {
                _password.Dispose ();
                _password = null;
            }
        }
    }
}
