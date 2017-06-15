using System;
using System.Diagnostics;
using AppKit;
using Foundation;

namespace Histamine_v
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        partial void Start_volt_button(Foundation.NSObject sender)
        {
            Debug.WriteLine(scan_rate_no.StringValue);
            Debug.WriteLine(Vmin_no.StringValue);
            Debug.WriteLine(Vmax_no.StringValue);

        }

        public override void PrepareForSegue(NSStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            // Take action based on the segue name
            switch (segue.Identifier)
            {
                
                case "SheetSegue":
                    var sheet = segue.DestinationController as PasswordDialogController;
                    sheet.SheetAccepted += (s, e) =>
                    {
                        Console.WriteLine("User Name: {0} Password: {1}", sheet.UserName, sheet.Password);
                    };
                    sheet.Presentor = this;
                    break;
            }
        }

    }
}