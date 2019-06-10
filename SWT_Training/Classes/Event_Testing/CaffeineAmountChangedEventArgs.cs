using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Event_Testing
{
    public class CaffeineAmountChangedEventArgs : EventArgs
    {
        public double CaffeineAmount { get; set; }

    }
}
