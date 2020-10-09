using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;

namespace ShimmerDemo
{
    /// <summary>
    /// Translated from: https://www.swiftdevcenter.com/uiview-shimmer-effect-swift-5/
    /// </summary>
    public static class ShimmerHelper
    {
        public static void StartShimmeringAnimation(this UIView view, ShimmerDirection direction = ShimmerDirection.LeftToRight)
        {
            var lightColor = new UIColor(1.0f, 1.0f, 1.0f, 0.1f).CGColor;
            var blackColor = UIColor.Black.CGColor;
            var gradient = new CAGradientLayer
            {
                Colors = new CGColor[] { blackColor, lightColor, blackColor },
                Frame = new CGRect(-view.Bounds.Size.Width, -view.Bounds.Size.Height, 3 * view.Bounds.Size.Width, 3 * view.Bounds.Size.Height)
            };

            switch (direction)
            {
                case ShimmerDirection.TopToBottom:
                    gradient.StartPoint = new CGPoint(0.5f, 0.0f);
                    gradient.EndPoint = new CGPoint(0.5f, 1.0f);
                    break;
                case ShimmerDirection.BottomToTop:
                    gradient.StartPoint = new CGPoint(0.5f, 1.0f);
                    gradient.EndPoint = new CGPoint(0.5f, 0.0f);
                    break;
                case ShimmerDirection.LeftToRight:
                    gradient.StartPoint = new CGPoint(0.0f, 0.5f);
                    gradient.EndPoint = new CGPoint(1.0f, 0.5f);
                    break;
                case ShimmerDirection.RightToLeft:
                    gradient.StartPoint = new CGPoint(1.0f, 0.5f);
                    gradient.EndPoint = new CGPoint(0.0f, 0.5f);
                    break;
            }

            gradient.Locations = new NSNumber[] { 0.35, 0.50, 0.65 };

            view.Layer.Mask = gradient;

            var animation = CABasicAnimation.FromKeyPath("locations");

            animation.From = NSArray.FromObjects(new NSNumber[] { 0.0, 0.1, 0.2 });
            animation.To = NSArray.FromObjects(new NSNumber[] { 0.8, 0.9, 1.0 });
            animation.Duration = 2.0f;
            animation.RepeatCount = 1000;

            gradient.AddAnimation(animation, "shimmerAnimation");
        }

        public static void StopShimmeringAnimation(this UIView view)
        {
            view.Layer.Mask = null;
        }
    }
}
