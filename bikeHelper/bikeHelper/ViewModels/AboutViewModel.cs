using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace bikeHelper.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://github.com/RobertShev/BikeHelper")));
        }

        public ICommand OpenWebCommand { get; }
    }
}