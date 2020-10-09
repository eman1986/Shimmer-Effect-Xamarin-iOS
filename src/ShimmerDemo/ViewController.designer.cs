// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ShimmerDemo
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAnimateBottomToTop { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAnimateLeftToRight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAnimateRightToLeft { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAnimateTopToBottom { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnStopAnimation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vHeader { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vLineOne { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vLineThree { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView vLineTwo { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnAnimateBottomToTop != null) {
                btnAnimateBottomToTop.Dispose ();
                btnAnimateBottomToTop = null;
            }

            if (btnAnimateLeftToRight != null) {
                btnAnimateLeftToRight.Dispose ();
                btnAnimateLeftToRight = null;
            }

            if (btnAnimateRightToLeft != null) {
                btnAnimateRightToLeft.Dispose ();
                btnAnimateRightToLeft = null;
            }

            if (btnAnimateTopToBottom != null) {
                btnAnimateTopToBottom.Dispose ();
                btnAnimateTopToBottom = null;
            }

            if (btnStopAnimation != null) {
                btnStopAnimation.Dispose ();
                btnStopAnimation = null;
            }

            if (vHeader != null) {
                vHeader.Dispose ();
                vHeader = null;
            }

            if (vLineOne != null) {
                vLineOne.Dispose ();
                vLineOne = null;
            }

            if (vLineThree != null) {
                vLineThree.Dispose ();
                vLineThree = null;
            }

            if (vLineTwo != null) {
                vLineTwo.Dispose ();
                vLineTwo = null;
            }
        }
    }
}