using System;
using Classes.Event_Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Test.Unit.Stress
{
    [TestClass]
    public class Event
    {
        private Caffeine _uutCaffeine;
        private CaffeineAmountChangedEventArgs _receivedEventArgs;

        [SetUp]
        public void Setup()
        {
            _receivedEventArgs = null;

            _uutCaffeine = new Caffeine();

            //#region Maybe
            //_uutCaffeine.DrinkUp(160);
            ////Kun Hvis start værdi er vigtig
            //#endregion


            _uutCaffeine.CaffeineAmountChangedEvent +=
                (o, args) =>
                {
                    //Hvad skal der ske når evented bliver triggered
                    _receivedEventArgs = args;
                };

        }

        [Test]
        public void DrinkOneMore()
        {
            _uutCaffeine.DrinkUp(160);
            Assert.That(_receivedEventArgs, Is.Not.Null);
        }

        [Test]
        public void DrinkOneMore_TestOnEventField()
        {
            _uutCaffeine.DrinkUp(160);
            Assert.That(_receivedEventArgs.CaffeineAmount, Is.EqualTo(160));
        }

        /*Hvis Region Maybe bilver sat ind igen kan man se at de 2 nederste fejler.
         Grunden er at når der testes på klassens koffein variabel, så tager den
         den tidligere koffein værdi og lægger den nye til og gemmer summen.
         Når der der imod testes på på Evented har vi ikke specificeret at den skal lægge til.
         Af denne grund vil evented retunere 320 når du har drukket 2 selvom du i forvejen har drukket 1
         
            P.S. Det her er det samme eksempel som i Slides fra Timen. Kom til at slack a bit too much. 
        */

        [Test]
        public void DrinkTwoMore_TestOnEvent()
        {
            _uutCaffeine.DrinkUp(160 * 2);
            Assert.That(_receivedEventArgs.CaffeineAmount, Is.EqualTo(320));
        }

        [Test]
        public void DrinkTwoMore_TestOnField()
        {
            _uutCaffeine.DrinkUp(160*2);
            Assert.That(_uutCaffeine.CaffeineContentmg, Is.EqualTo(320));
        }

        [Test]
        public void DrinkTwoMore_TestOnField_vsEvent()
        {
            _uutCaffeine.DrinkUp(160 * 2);
            Assert.That(_uutCaffeine.CaffeineContentmg, Is.EqualTo(_receivedEventArgs.CaffeineAmount));
        }

    }
}
