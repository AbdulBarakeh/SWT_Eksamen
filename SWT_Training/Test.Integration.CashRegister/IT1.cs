using System;
using System.Collections.Generic;
using Classes.Integration_Testing.CashRegister;
using Classes.Integration_Testing.Display;
using Classes.Integration_Testing.Item;
using Classes.Integration_Testing.Scanner;
using NSubstitute;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;


namespace Test.Integration.CashRegisterTest
{
    [TestFixture]
    public class IT1
    {
        private IDisplay _display;
        private CashRegister _uut;
        private List<IItem> _items;
        private IScanner _scanner;
        private IItem _item;

        [SetUp]
        public void Setup()
        {
            _display = Substitute.For<IDisplay>();
            _item = Substitute.For<IItem>();
            _items = Substitute.For<List<IItem>>();
            _scanner = Substitute.For<IScanner>();
            _uut = new CashRegister(_item,_scanner,_display);

        }

        [Test]
        public void T1()
        {
            
            _uut.BeepItem(_item,_scanner,_display);
            _display.Received().ShowItemPrice(_item);
        }

        [Test]
        public void T2()
        {

            _uut.BeepItem(_item, _scanner, _display);
            _scanner.Received().FindItem(_item);
        }

        //[Test]
        //public void T3()
        //{

        //    _uut.BeepItem(_item, _scanner, _display);
        //    _scanner.Received().FindItem(
        //        (Arg.Is<string>(s => s.Contains("Don't know man I'm not creative enough"))););
        //
        // //Not possible cause the value which is passed through as barcode is not a string
        // //And it would corrupt the test above if changed
        //}

        [Test]
        public void T4()
        {

            _uut.GetSum(_items);
            _display.Received().ShowSumPrice(_items);
        }
    }
}
