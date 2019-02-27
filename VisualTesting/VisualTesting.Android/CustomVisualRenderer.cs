using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using VisualTesting.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(CustomVisualRenderer), new[] { typeof(VisualTesting.CustomVisual) })]
namespace VisualTesting.Droid
{
	public class CustomVisualRenderer : MaterialButtonRenderer
	{
		public CustomVisualRenderer(Context context) : base(context)
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);
			Element.Text = "I am a Custom Visual Renderer";
		}
	}
}