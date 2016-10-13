using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Animation
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)


        {
            await MainGrid.TranslateTo(200, 300, 2000, Easing.Linear);

            await MainGrid.RotateTo(90, 600, Easing.SinInOut);

            await MainGrid.FadeTo(0.5, 400, Easing.CubicInOut);

            await MainGrid.LayoutTo(new Rectangle(-200, -200, 300, 100 ));

            await MainGrid.ScaleTo(0.6, 600, Easing.CubicIn);

            await MainLabel.TranslateTo(200, 300, 2000, Easing.Linear);

            await MainLabel.RotateTo(90, 600, Easing.SinInOut);

            await MainLabel.FadeTo(0.5, 400, Easing.CubicInOut);

            await MainLabel.LayoutTo(new Rectangle(-200, -200, 300, 100));

            await MainLabel.ScaleTo(0.6, 600, Easing.CubicIn);
        }
    }
}
