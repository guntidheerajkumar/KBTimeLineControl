# KBTimeLineControl

Awesome way of representing the time line and the current status.

This is a binding project based on https://github.com/romaHerman/timeLineiOS.

###Usage

```
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
```
