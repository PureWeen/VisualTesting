using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VisualTesting
{
    public partial class VisualPage : ContentPage
    {
        public VisualPage()
        {
            InitializeComponent();

            BackgroundColor = Color.White;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                var progress = progressBar.Progress + 0.1;
                if (progress > 1)
                    progress = 0;

                progressBar.Progress = progress;
                return true;
            });
        }
    }
}
