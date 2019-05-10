using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using bikeHelper.Models;
using bikeHelper.ViewModels;

namespace bikeHelper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                BikeName = "Item 1",
                BikePrice = "$$$"
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}