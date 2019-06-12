using NSubstitute;
using NUnit.Framework;

namespace ECSWithEvents.Test.Unit
{
    [TestFixture]
    public class ECSWithEventsUnitTests
    {
        private int _increaseTempEventsReceived;
        private int _decreaseTempEventsreceived;
        private ITempSensor _tempSensor;
        private Control _uut;

        [SetUp]
        public void Setup()
        {
            // Initialize event counters
            _increaseTempEventsReceived = 0;
            _decreaseTempEventsreceived = 0;

            _tempSensor = Substitute.For<ITempSensor>();
            _uut = new Control(_tempSensor, 25);    // Control should hook up to our temperature source 

            // Initialize anonymous event listeners that listen to events from Control
            // When an event occurs, increase the associated event counter.
            // See e.g. http://nsubstitute.github.io/help/raising-events/
            _uut.IncreaseTempEvent += (sender, args) => { ++_increaseTempEventsReceived; };
            _uut.DecreaseTempEvent += (sender, args) => { ++_decreaseTempEventsreceived; };

        }

        [TestCase(26, 1)]
        [TestCase(25, 1)]
        [TestCase(24, 0)]
        public void RegulateTemp_VariousTemps_DecreaseTempEventsRaisedAsExpected(int temp, int nTimesDecreaseEventExpected)
        {
            _tempSensor.TempChangedEvent += Raise.EventWith(new TempChangedEventArgs {Temp = temp});    // Raise TempChangedEvent through fake
            Assert.That(_decreaseTempEventsreceived, Is.EqualTo(nTimesDecreaseEventExpected));          // Asert that event from UUT was received
        }


        [TestCase(26, 0)]
        [TestCase(25, 0)]
        [TestCase(24, 1)]
        public void RegulateTemp_VariousTemps_IncreaseTempEventsRaisedAsExpected(int temp, int nTimesIncreaseEventExpected)
        {
            _tempSensor.TempChangedEvent += Raise.EventWith(new TempChangedEventArgs { Temp = temp });
            Assert.That(_increaseTempEventsReceived, Is.EqualTo(nTimesIncreaseEventExpected));
        }
    }
}
