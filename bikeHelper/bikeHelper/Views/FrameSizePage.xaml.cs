using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bikeHelper.Views
{
    public partial class FrameSizePage : ContentPage
    {
        public FrameSizePage()
        {
            InitializeComponent();
        }
        private void BtnCalc_Clicked(object sender, EventArgs e)
        {
            if (Height.Text != null)
            {
                double height = Double.Parse(Height.Text);
                double cavallo = height * 0.47;
                double tronco = cavallo * 0.76;
                double braccio = cavallo * 0.87;

                resSaddleHeight.Text = (cavallo * 0.885).ToString("N2");
                resSeatTube.Text = (cavallo * 0.65 + 0.6).ToString("N2");
                resTopTube.Text = ((tronco + braccio) / 2.35).ToString("N2");
                resStemLength.Text = ((tronco + braccio) / 10.65).ToString("N2");
            }
            else
            {
                resSaddleHeight.Text = "error";
                resSeatTube.Text = "error";
                resTopTube.Text = "error";
                resStemLength.Text = "error";
            }
                
        }
    }
}