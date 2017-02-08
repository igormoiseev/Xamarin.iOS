// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Samples.iOS.Views.Controls
{
	[Register ("TabsControl")]
	partial class TabsControl
	{
		[Outlet]
		UIKit.UIView FirstTabLine { get; set; }

		[Outlet]
		UIKit.UILabel FirstTabTitleLabel { get; set; }

		[Outlet]
		UIKit.UIView FirstTabView { get; set; }

		[Outlet]
		UIKit.UIView SecondTabLine { get; set; }

		[Outlet]
		UIKit.UILabel SecondTabTitleLabel { get; set; }

		[Outlet]
		UIKit.UIView SecondTabView { get; set; }

		[Outlet]
		UIKit.UIView SeparatorLine { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FirstTabLine != null) {
				FirstTabLine.Dispose ();
				FirstTabLine = null;
			}

			if (FirstTabView != null) {
				FirstTabView.Dispose ();
				FirstTabView = null;
			}

			if (SecondTabLine != null) {
				SecondTabLine.Dispose ();
				SecondTabLine = null;
			}

			if (SecondTabView != null) {
				SecondTabView.Dispose ();
				SecondTabView = null;
			}

			if (SeparatorLine != null) {
				SeparatorLine.Dispose ();
				SeparatorLine = null;
			}

			if (FirstTabTitleLabel != null) {
				FirstTabTitleLabel.Dispose ();
				FirstTabTitleLabel = null;
			}

			if (SecondTabTitleLabel != null) {
				SecondTabTitleLabel.Dispose ();
				SecondTabTitleLabel = null;
			}
		}
	}
}
