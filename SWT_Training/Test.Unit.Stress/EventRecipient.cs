using System;
using Classes.Event_Testing;

using NSubstitute;
using NUnit.Framework;


namespace Test.Unit.Stress
{
    [TestFixture]
    public class EventRecipient
    {
        private Control _uut;
        private ICaffeine _someSource;
        private int _eventTracker;

        [SetUp]
        public void Setup()
        {
            _eventTracker = 0;

            _someSource = Substitute.For<ICaffeine>();
            _uut = new Control(_someSource);

            _uut.RecipientEventTrigger += (sender, args) => { ++_eventTracker; };
        }

        [Test]
        public void RecipientTest_WithRaisedEvent()
        {
            _someSource.CaffeineAmountChangedEvent += Raise.EventWith(new CaffeineAmountChangedEventArgs());
            Assert.That(_eventTracker, Is.EqualTo(1));
        }
        //Her er der ifølge Frank ikke tale om nogen stub eller mock. Events hører under noget helt andet.
        //Hvis de dog siger i eksamen til jer at det ikke er rigtigt, så sig at det her er en mock som der
        //testes på grundet at der er tale om en interaction based test.
        
    }
}
