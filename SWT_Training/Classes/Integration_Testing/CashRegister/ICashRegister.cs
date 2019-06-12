using System.Collections.Generic;
using Classes.Integration_Testing.Display;
using Classes.Integration_Testing.Item;
using Classes.Integration_Testing.Scanner;

namespace Classes.Integration_Testing.CashRegister
{
    public interface ICashRegister
    {

        void BeepItem(IItem item, IScanner scan, IDisplay output);
        void GetSum(List<IItem> items);


    }
}