using System;

namespace ECSWithEvents
{
    public class Control
    {
        public Control(ITempSensor tempSensor, int threshold)
        {
            tempSensor.TempChangedEvent += HandleTempChangedEvent;
            Threshold = threshold;
        }

        public event EventHandler IncreaseTempEvent;
        public event EventHandler DecreaseTempEvent;

        public int Threshold { get; set; }

        public void HandleTempChangedEvent(object source, TempChangedEventArgs args)
        {
            if(args.Temp < Threshold) OnIncreaseTempEvent();
            else OnDecreaseTempEvent();
        }

        protected virtual void OnIncreaseTempEvent()
        {
            IncreaseTempEvent?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnDecreaseTempEvent()
        {
            DecreaseTempEvent?.Invoke(this, EventArgs.Empty);
        }
    }

}
