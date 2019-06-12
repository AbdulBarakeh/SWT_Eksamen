using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Integration_Testing.Item
{
    class Item : IItem
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _barcode;

        public int Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }


    }
}
