using System;
using System.Collections.Generic;

namespace Classes
{
    public class Stress : IStress
    {

        private List<IPerson> _stressedPeople = new List<IPerson>();
        private List<IPerson> _notStressedPeople = new List<IPerson>();


        public List<IPerson> StressedPeople
        {
            get { return _stressedPeople; }
            set { _stressedPeople = value; }
        }

        public List<IPerson> NotStressedPeople
        {
            get { return _notStressedPeople; }
            set { _notStressedPeople = value; }
        }

         //If heart beat is over 100 you are stressed! if not you are not stressed      
        public bool Stresslevel(IPerson person)
        {
            var BPM = person.NumberOfHeartBeatsPerMin;
            var result = BPM / 60;
            if (result < 1.7)
            {
                _notStressedPeople.Add(person);
                Console.WriteLine("Not stressed people will be listed below");
                foreach (var item in _notStressedPeople)
                {
                    Console.Write($"{item.Name}, ");
                }

                return false;
            }
            else
            {
                _stressedPeople.Add(person);
                Console.WriteLine("Stressed people will be listed below");
                foreach (var item in _stressedPeople)
                {
                    Console.Write($"{item.Name}, ");
                }

                return true;
            }

        }
    }
}
