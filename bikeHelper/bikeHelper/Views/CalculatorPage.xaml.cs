using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bikeHelper.Views
{
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage()
        {
            InitializeComponent();
        }

        private void BtnSpeed_Clicked(object sender, EventArgs e)
        {
            Double Cadence = Double.Parse(RPM.Text);
            Double RimSize = Double.Parse(Inches.Text) * 2.54;
            Double FrontGear = Double.Parse(BigGear.Text);
            Double RearGear = Double.Parse(SmallGear.Text);

            double ratio = FrontGear / RearGear;
            double speed = ((ratio * RimSize * 0.0314)/1000) * Cadence * 60;

            MaxSpeed.Text = speed.ToString("N2") + " KM/H";
            GearRatio.Text = "Ratio of " + ratio.ToString("N2");
        }
    }
}
