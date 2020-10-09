using System;
using UIKit;

namespace ShimmerDemo
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            btnAnimateTopToBottom.TouchUpInside += BtnAnimateTopToBottomOnTouchUpInside;
            btnAnimateBottomToTop.TouchUpInside += BtnAnimateBottomToTopOnTouchUpInside;
            btnAnimateLeftToRight.TouchUpInside += BtnAnimateLeftToRightOnTouchUpInside;
            btnAnimateRightToLeft.TouchUpInside += BtnAnimateRightToLeftOnTouchUpInside;
            btnStopAnimation.TouchUpInside += BtnStopAnimationOnTouchUpInside;
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            btnAnimateTopToBottom.TouchUpInside -= BtnAnimateTopToBottomOnTouchUpInside;
            btnAnimateBottomToTop.TouchUpInside -= BtnAnimateBottomToTopOnTouchUpInside;
            btnAnimateLeftToRight.TouchUpInside -= BtnAnimateLeftToRightOnTouchUpInside;
            btnAnimateRightToLeft.TouchUpInside -= BtnAnimateRightToLeftOnTouchUpInside;
            btnStopAnimation.TouchUpInside -= BtnStopAnimationOnTouchUpInside;
        }

        private void StopAnimation()
        {
            vHeader.StopShimmeringAnimation();
            vLineOne.StopShimmeringAnimation();
            vLineTwo.StopShimmeringAnimation();
            vLineThree.StopShimmeringAnimation();
        }

        #region Events
        private void BtnAnimateTopToBottomOnTouchUpInside(object sender, EventArgs e)
        {
            StopAnimation();

            vHeader.StartShimmeringAnimation(ShimmerDirection.TopToBottom);
            vLineOne.StartShimmeringAnimation(ShimmerDirection.TopToBottom);
            vLineTwo.StartShimmeringAnimation(ShimmerDirection.TopToBottom);
            vLineThree.StartShimmeringAnimation(ShimmerDirection.TopToBottom);
        }

        private void BtnAnimateBottomToTopOnTouchUpInside(object sender, EventArgs e)
        {
            StopAnimation();

            vHeader.StartShimmeringAnimation(ShimmerDirection.BottomToTop);
            vLineOne.StartShimmeringAnimation(ShimmerDirection.BottomToTop);
            vLineTwo.StartShimmeringAnimation(ShimmerDirection.BottomToTop);
            vLineThree.StartShimmeringAnimation(ShimmerDirection.BottomToTop);
        }

        private void BtnAnimateLeftToRightOnTouchUpInside(object sender, EventArgs e)
        {
            StopAnimation();

            vHeader.StartShimmeringAnimation();
            vLineOne.StartShimmeringAnimation();
            vLineTwo.StartShimmeringAnimation();
            vLineThree.StartShimmeringAnimation();
        }

        private void BtnAnimateRightToLeftOnTouchUpInside(object sender, EventArgs e)
        {
            StopAnimation();

            vHeader.StartShimmeringAnimation(ShimmerDirection.RightToLeft);
            vLineOne.StartShimmeringAnimation(ShimmerDirection.RightToLeft);
            vLineTwo.StartShimmeringAnimation(ShimmerDirection.RightToLeft);
            vLineThree.StartShimmeringAnimation(ShimmerDirection.RightToLeft);
        }

        private void BtnStopAnimationOnTouchUpInside(object sender, EventArgs e)
        {
            StopAnimation();
        }
        #endregion
    }
}