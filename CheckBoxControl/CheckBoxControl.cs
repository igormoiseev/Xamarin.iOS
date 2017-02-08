using System;
using UIKit;
using Foundation;
using MvvmCross.Binding.iOS.Views;

namespace Samples.iOS.Views.Controls.Guidance
{
	public partial class CheckBoxControl : MvxView
	{
		private const string Name = "CheckBoxControl";
		private static readonly UIImage CheckBoxCheckedImage = UIImage.FromFile(ImageNames.CheckBoxChecked);
		private static readonly UIImage CheckBoxUncheckedImage = UIImage.FromFile(ImageNames.CheckBoxUnchecked);

		private bool isChecked;
		private UITapGestureRecognizer placeholderTap;
		public event EventHandler CheckedChanged; // need to make two way binding works
		public static readonly NSString Key = new NSString(Name);
		public static readonly UINib Nib = UINib.FromName(Name, NSBundle.MainBundle);

		protected CheckBoxControl(IntPtr handle)
			: base(handle)
		{
		}

		public static CheckBoxControl Create(string title)
		{
			var view = (CheckBoxControl)Nib.Instantiate(null, null)[0];
			view.SetTitle(title);

			return view;
		}

		public UIView TapAreaView
		{
			get { return TapView; }
		}

		public bool IsChecked
		{
			get { return isChecked; }
			set
			{
				isChecked = value;
				var image = isChecked ? CheckBoxCheckedImage : CheckBoxUncheckedImage;
				CheckBoxImageView.SetImageAnimated(image);
				RaiseIsCheckedChanged();
			}
		}

		private void SetTitle(string title)
		{
			TitleLabel.Text = title;
			ApplyDefaultFont();
		}

		private void ApplyDefaultFont()
		{
			Styles.ApplyCheckboxTitleLabelStyle(TitleLabel);
		}

		public override void AwakeFromNib()
		{
			base.AwakeFromNib();
			SetControl();
		}

		private void SetControl()
		{
			IsChecked = false;

			placeholderTap =
				new UITapGestureRecognizer(() =>
				{
					IsChecked = !IsChecked;
				});

			TapView.AddGestureRecognizer(placeholderTap);
		}

		private void RaiseIsCheckedChanged()
		{
			var ev = CheckedChanged;
			if (ev != null)
			{
				ev(this, EventArgs.Empty);
			}
		}
	}
}
