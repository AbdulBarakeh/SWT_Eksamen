using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Person : IPerson
    {
        public string Name { get; set; }

        private double _numberOfHeartBeatsPerMin;
        public double NumberOfHeartBeatsPerMin
        {
            get { return _numberOfHeartBeatsPerMin; }
            set { _numberOfHeartBeatsPerMin = value; }
        }
    }
}
