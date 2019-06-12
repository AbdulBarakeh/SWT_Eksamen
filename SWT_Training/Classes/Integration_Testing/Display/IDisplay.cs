using System.Collections.Generic;
using Classes.Integration_Testing.Item;

namespace Classes.Integration_Testing.Display
{
    public interface IDisplay
    {
        void ShowItemPrice(IItem itemname);
        void ShowSumPrice(List<IItem> items);
    }
}