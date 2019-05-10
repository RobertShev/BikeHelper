using System;
using System.Collections.Generic;
using System.Linq;

namespace Compare
{
    public class CalculationData
    {
        public List<Item> GetData()
        {
            List<Item> items = new List<Item>();
            var calculationData = new List<Item> {
            new Item { Id = Guid.NewGuid().ToString(), Name = "Name:", Distance = 5, Speed = 20 },
        };
            foreach (var item in calculationData)
            {
                items.Add(item);
            }
            return items;
        }
    }
}
