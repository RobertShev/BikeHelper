using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Compare
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            CalculationData items = new CalculationData();
            BindingContext = items.GetData();
            InitializeComponent();
        }
    }
}
   
            /*         // BindingContext = CompareResults;
            int LastDistance = 20;
            int LastSpeed = 25;
            String LastName = "Compare";
            //var items = new List
            // {
        Item it1 = new Item { Id = Guid.NewGuid().ToString(), Name = "First", Distance = 15, Speed = 7 };
          Item it2 = new Item { Id = Guid.NewGuid().ToString(), Name = "Second", Distance = 7, Speed = 16 };
            //};
            // ItemsSource = items;

            List<Item> items;
                items = new List<Item>();

                var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Name = "First", Distance= 5, Speed=20 },
                new Item { Id = Guid.NewGuid().ToString(), Name = "Second", Distance=7, Speed=16 },
                new Item { Id = Guid.NewGuid().ToString(), Name = "Third ", Distance=4, Speed=14 }
            };
            
        public string CompareResults()
        {

            if (LastDistance != 0 && LastSpeed != 0)
            {
                String LastData = LastName + LastDistance.ToString() + LastSpeed.ToString();

            }

            //var CompareInfo = Name + Distance + Speed;

            return LastData;
        }*/
  //  }
  //  }
//}



 