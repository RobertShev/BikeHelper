using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HeightCalculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCalc_Clicked(object sender, EventArgs e)
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
    }
}
