using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace KBTimeLineControl
{
	// @interface TimeLineViewControl : UIView
	[BaseType(typeof(UIView))]
	interface TimeLineViewControl
	{
		// @property (assign, nonatomic) CGFloat viewheight;
		[Export("viewheight")]
		nfloat Viewheight { get; set; }

		// -(id)initWithTimeArray:(NSArray *)time andTimeDescriptionArray:(NSArray *)timeDescriptions andCurrentStatus:(int)status andFrame:(CGRect)frame;
		[Export("initWithTimeArray:andTimeDescriptionArray:andCurrentStatus:andFrame:")]
		IntPtr Constructor(NSObject[] time, NSObject[] timeDescriptions, int status, CGRect frame);
	}
}
