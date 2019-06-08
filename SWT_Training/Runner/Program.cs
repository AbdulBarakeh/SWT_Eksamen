using System;
using Classes;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person();
            Console.WriteLine("Insert your name: ");
            obj.Name = Console.ReadLine();
            Console.WriteLine("Insert your Heartbeats Per Minute: ");
            var tempBPM = Console.ReadLine();
            obj.NumberOfHeartBeatsPerMin = Convert.ToInt64(tempBPM);

            Stress objStress = new Stress();
            objStress.Stresslevel(obj);
        }
    }
}
