using System;
using System.Collections.Generic;
using UIKit;
using Foundation;

namespace Samples.iOS.Views.Controls.Challenge
{
	[Register("HeartProgressControl")]
	public partial class HeartProgressControl : UIStackView
	{
		private const string ViewNibName = "HeartProgressControl";
		private const int MaxCount = 3;
		private const float Interval = 4f;
		private int remainingLives;
		private UIImage emptyHeart;
		private UIImage filledHeart;
		private List<UIImageView> images = new List<UIImageView>();

		public HeartProgressControl(IntPtr handle) : base(handle)
		{
			DefaultInitialization();
		}

		public int RemainingLives
		{
			get
			{
				return remainingLives;
			}

			set
			{
				remainingLives = value;
				SetHeartImages();
			}
		}

		private void DefaultInitialization()
		{
			this.Spacing = Interval;
			DoSetResources();

			for (int i = 0; i < MaxCount; i++)
			{
				var image = new UIImageView { Image = emptyHeart };
				images.Add(image);
				this.AddArrangedSubview(image);
			}
		}

		private void DoSetResources()
		{
			emptyHeart = UIImage.FromFile(ImageNames.HeartWhiteIcon);
			filledHeart = UIImage.FromFile(ImageNames.HeartBlackIcon);
		}

		private void SetHeartImages()
		{
			for (int i = 1; i <= remainingLives; i++)
			{
				images[MaxCount-i].Image = filledHeart;
			}

			var j = 0;
			for (int i = remainingLives; i < MaxCount; i++)
			{
				images[j].Image = emptyHeart;
				j++;
			}
		}
	}
}

