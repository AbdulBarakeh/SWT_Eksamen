using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Event_Testing
{
    public interface ICaffeine 
    {
        double NumberOfEnergydrinks { get; set; }

        double CaffeineContentmg { get; set; }

        void DrinkUp(double caffeineContentmg);

        event EventHandler<CaffeineAmountChangedEventArgs> CaffeineAmountChangedEvent;
    }
}
