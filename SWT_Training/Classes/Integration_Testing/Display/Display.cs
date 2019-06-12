using Classes.Integration_Testing.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Integration_Testing.Display
{
    public class Display : IDisplay
    {
        private double temp;
        public void ShowItemPrice(IItem item)
        {
            Console.WriteLine($"The price of {item.Name} is {item.Price}");
        }

        public void ShowSumPrice(List<IItem> items)
        {
            foreach (var item in items)
            {
                temp += item.Price;
            }

            Console.WriteLine($"The price of all items is {temp}");
            
        }
    }
}
