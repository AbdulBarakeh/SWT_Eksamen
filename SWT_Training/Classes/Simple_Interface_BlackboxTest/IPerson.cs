using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public interface IPerson
    {
        string Name { get; set; }

        double NumberOfHeartBeatsPerMin { get; set; }
    }
}
