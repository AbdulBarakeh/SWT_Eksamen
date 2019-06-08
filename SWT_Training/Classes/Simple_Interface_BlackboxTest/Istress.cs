using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
     public interface IStress
     {
        bool Stresslevel( IPerson person);

        //int NumberOfHeartBeatsPerMin { get; set; }

        List<IPerson> StressedPeople { get; set; }

        List<IPerson> NotStressedPeople { get; set; }



     }
}
