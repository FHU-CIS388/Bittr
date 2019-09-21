using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Bittr.Controls;
using Bittr.iOS.Renderers;
using CoreGraphics;

[assembly: ExportRenderer(typeof(ComplaintProgress), typeof(ComplaintProgressRenderer))]
namespace Bittr.iOS.Renderers
{
    public class ComplaintProgressRenderer : ProgressBarRenderer
    {
        public override void LayoutSubviews()
        {
            /*var X = 1.0f;
            var Y = 4.0f;

            CGAffineTransform transform = CGAffineTransform.MakeScale(X, Y);
            this.Transform = transform;*/
        }
    }
}
