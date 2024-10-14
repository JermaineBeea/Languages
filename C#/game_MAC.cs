using System;
using AppKit;
using Foundation;

namespace MoveIconMac
{
    public partial class ViewController : NSViewController
    {
        private int moveStep = 10; // Number of pixels to move the icon

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Capture key presses
            this.View.Window.KeyDown += OnKeyDown;

            // Set initial position of the ImageView (icon)
            iconImageView.Frame = new CoreGraphics.CGRect(100, 100, iconImageView.Frame.Width, iconImageView.Frame.Height);
        }

        // Handle key presses
        public override void KeyDown(NSEvent theEvent)
        {
            base.KeyDown(theEvent);
            var keyCode = theEvent.KeyCode;

            // Detect arrow keys and move the icon accordingly
            switch (keyCode)
            {
                case 123: // Left arrow key
                    iconImageView.Frame = new CoreGraphics.CGRect(iconImageView.Frame.X - moveStep, iconImageView.Frame.Y, iconImageView.Frame.Width, iconImageView.Frame.Height);
                    break;
                case 124: // Right arrow key
                    iconImageView.Frame = new CoreGraphics.CGRect(iconImageView.Frame.X + moveStep, iconImageView.Frame.Y, iconImageView.Frame.Width, iconImageView.Frame.Height);
                    break;
                case 126: // Up arrow key
                    iconImageView.Frame = new CoreGraphics.CGRect(iconImageView.Frame.X, iconImageView.Frame.Y + moveStep, iconImageView.Frame.Width, iconImageView.Frame.Height);
                    break;
                case 125: // Down arrow key
                    iconImageView.Frame = new CoreGraphics.CGRect(iconImageView.Frame.X, iconImageView.Frame.Y - moveStep, iconImageView.Frame.Width, iconImageView.Frame.Height);
                    break;
                default:
                    break;
            }
        }
    }
}
