// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Samples.iOS.Views.Controls.Guidance
{
	[Register ("CheckBoxControl")]
	partial class CheckBoxControl
	{
		[Outlet]
		UIKit.UIImageView CheckBoxImageView { get; set; }

		[Outlet]
		UIKit.UIView TapView { get; set; }

		[Outlet]
		UIKit.UILabel TitleLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CheckBoxImageView != null) {
				CheckBoxImageView.Dispose ();
				CheckBoxImageView = null;
			}

			if (TitleLabel != null) {
				TitleLabel.Dispose ();
				TitleLabel = null;
			}

			if (TapView != null) {
				TapView.Dispose ();
				TapView = null;
			}
		}
	}
}
