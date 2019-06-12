using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Event_Testing
{
    public class Caffeine : ICaffeine
    {        
        public event EventHandler<CaffeineAmountChangedEventArgs> CaffeineAmountChangedEvent;
        private double _caffeineContentmg;
        private double _numberOfEnergydrinks;
 
        public double NumberOfEnergydrinks
        {
            get { return _numberOfEnergydrinks; }
            set { _numberOfEnergydrinks = value; }
        }


        public double CaffeineContentmg
        {
            get { return _caffeineContentmg; }
            set { _caffeineContentmg = value; }
        }

        protected virtual void OnCaffeineAdded(CaffeineAmountChangedEventArgs e)
        {
            CaffeineAmountChangedEvent?.Invoke(this, e);
        }

        public void DrinkUp(double caffeineContentmg)
        {
            OnCaffeineAdded(new CaffeineAmountChangedEventArgs { CaffeineAmount = caffeineContentmg });
            _caffeineContentmg += caffeineContentmg;
            _numberOfEnergydrinks = _caffeineContentmg / 160;

            Console.WriteLine($"You have drunk {caffeineContentmg} mg worth of caffeine, and {_caffeineContentmg} in total, which is {_numberOfEnergydrinks} cans worth of half-liter energydrinks" );

        }
    }
}
