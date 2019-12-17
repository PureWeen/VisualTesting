
using System.ComponentModel;

using VisualTesting.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(CustomVisualRenderer), new[] { typeof(VisualTesting.CustomVisual) })]
namespace VisualTesting.iOS
{
	public class CustomVisualRenderer : MaterialButtonRenderer
	{

		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);
			if(Element != null)
				Element.Text = "I am a Custom Visual Renderer";
		}
	}
}