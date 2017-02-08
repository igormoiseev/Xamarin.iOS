using System;
using UIKit;
using CoreGraphics;

namespace Samples.iOS.Views.Controls
{
	public partial class TabsControl : UIView
	{
		private enum Tab
		{
			FirstTab,
			SecondTab
		}

		private SingleTapBehaviour firstTabTapBehaviour;
		private SingleTapBehaviour secondTabTapBehaviour;
		public event EventHandler OnTabSwitched;

		public TabsControl(IntPtr handle): base(handle)
		{
		}

		public bool IsFirstTabHidden { get; set; }

		public string FirstTabTitle
		{
			get { return FirstTabTitleLabel.Text; }
			set { FirstTabTitleLabel.Text = value; }
		}

		public string SecondTabTitle
		{
			get { return SecondTabTitleLabel.Text; }
			set { SecondTabTitleLabel.Text = value; }
		}

		public static TabsControl Create(CGRect frame)
		{
			var tabsControl = UIViewExtensions.CreateViewFromNib<TabsControl>("TabsControl");
			tabsControl.Frame = frame;
			return tabsControl;
		}

		public override void AwakeFromNib()
		{
			base.AwakeFromNib();
			DefaultInitialization();
		}

		private void DefaultInitialization()
		{
			MakeTabActive(Tab.FirstTab);

			firstTabTapBehaviour = new SingleTapBehaviour(FirstTabView);
			secondTabTapBehaviour = new SingleTapBehaviour(SecondTabView);

			firstTabTapBehaviour.Action = () => MakeTabActive(Tab.FirstTab);
			secondTabTapBehaviour.Action = () => MakeTabActive(Tab.SecondTab);

			ApplyStyles();
		}

		private void ApplyStyles()
		{
			Styles.ApplyBarHeaderLabelStyle(FirstTabTitleLabel);
			Styles.ApplyBarHeaderLabelStyle(SecondTabTitleLabel);
			Styles.ApplySplitLineStyle(SeparatorLine);

			Styles.ApplyBarLineViewStyle(FirstTabLine);
			Styles.ApplyBarLineViewStyle(SecondTabLine);
		}

		private void MakeTabActive(Tab tab)
		{
			IsFirstTabHidden = tab != Tab.FirstTab;
			FirstTabTitleLabel.TextColor = !IsFirstTabHidden
				? UIColor.Black
				: Colors.Raven;
			FirstTabLine.Hidden = IsFirstTabHidden;

			SecondTabTitleLabel.TextColor = IsFirstTabHidden
				? UIColor.Black
				: Colors.Raven;
			SecondTabLine.Hidden = !IsFirstTabHidden;

			FireOnTabSwitched();
		}

		private void FireOnTabSwitched()
		{
			var ev = OnTabSwitched;
			ev?.Invoke(this, EventArgs.Empty);
		}
	}
}

