using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Event_Testing
{
    public class Control
    {
        public double CurrentCaffeinemg { get; set; }
        public Control(ICaffeine caffeine)
        {
            caffeine.CaffeineAmountChangedEvent += HandleCaffeineAmountChangedEvent;
            
        }

        private void HandleCaffeineAmountChangedEvent(object sender, CaffeineAmountChangedEventArgs e)
        {
            CurrentCaffeinemg = e.CaffeineAmount;
            Console.WriteLine("Stuff happened in HandleCaffeineAmountChangedEvent");
            OnRecipientEventTrigger();
            
        }

        //New event to read

        public event EventHandler RecipientEventTrigger;

        protected virtual void OnRecipientEventTrigger()
        {
            RecipientEventTrigger?.Invoke(this, EventArgs.Empty);
            Console.WriteLine("Stuff happened in OnRecipientEventTrigger");
        }
    }
}
