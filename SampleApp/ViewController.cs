using System;
using KBTimeLineControl;
using UIKit;
using Foundation;
using CoreGraphics;

namespace SampleApp
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var weeks = new NSObject[] {
				new NSString("Sunday"),
				new NSString("Monday"),
				new NSString("Tuesday"),
				new NSString("Wednesday"),
				new NSString("Thursday"),
				new NSString("Friday"),
				new NSString("Saturday"),
			};

			var descriptions = new NSObject[] {
				new NSString("Buy Groceries to Home"),
				new NSString("Need to Submit Bills"),
				new NSString("Pay Mobile Bill"),
				new NSString("Pay Electricity Bill"),
				new NSString("Book tickets for Vacation."),
				new NSString("Plan for weekend."),
				new NSString("Buy a gift for the party."),
			};

			TimeLineViewControl control = new TimeLineViewControl(weeks,
																  descriptions,
																  3,
																  new CGRect(30, 30,
																			 this.View.Frame.Width - 60, this.View.Frame.Height - 40));

			this.View.AddSubview(control);
		}
	}
}
