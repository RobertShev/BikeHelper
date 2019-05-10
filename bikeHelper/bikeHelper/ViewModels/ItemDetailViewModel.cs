using System;

using bikeHelper.Models;

namespace bikeHelper.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.BikeName;
            Item = item;
        }
    }
}
