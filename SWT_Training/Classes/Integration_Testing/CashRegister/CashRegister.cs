using System;
using System.Collections.Generic;
using System.Text;
using Classes.Integration_Testing.Display;
using Classes.Integration_Testing.Item;
using Classes.Integration_Testing.Scanner;

namespace Classes.Integration_Testing.CashRegister
{
    public class CashRegister : ICashRegister
    {
        private List<IItem> _items = new List<IItem>();
        private IScanner _scanner = new Scanner.Scanner();
        private IDisplay _display = new Display.Display();
        private IItem _item = new Item.Item();

        public CashRegister(IItem item, IScanner scanner, IDisplay display)
        {
            
            _item = item;
            
            _scanner = scanner;
            
            _display = display;
        }
        public void BeepItem(IItem item, IScanner scan, IDisplay output)
        {
            _scanner.FindItem(item);
            _items.Add(item);
            _display.ShowItemPrice(item);
            
        }

        public void GetSum(List<IItem> items)
        {
            _display.ShowSumPrice(items);
        }
    }
}
