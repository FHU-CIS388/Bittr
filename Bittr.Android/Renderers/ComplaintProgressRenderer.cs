using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Bittr.Controls;
using Bittr.Droid.Renderers;

[assembly: ExportRenderer(typeof(ComplaintProgress), typeof(ComplaintProgressRenderer))]
namespace Bittr.Droid.Renderers
{
    [System.Obsolete]
    public class ComplaintProgressRenderer : ProgressBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ProgressBar> e)
        {
            /*base.OnElementChanged(e);

            Control.ScaleY = 4;*/
        }
    }
}
