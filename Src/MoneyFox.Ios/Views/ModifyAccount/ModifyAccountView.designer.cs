// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//

using System.CodeDom.Compiler;
using Foundation;

namespace MoneyFox.Ios.Views.ModifyAccount
{
    [Register ("ModifyAccountView")]
    partial class ModifyAccountView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldAccountName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (textFieldAccountName != null) {
                textFieldAccountName.Dispose ();
                textFieldAccountName = null;
            }
        }
    }
}