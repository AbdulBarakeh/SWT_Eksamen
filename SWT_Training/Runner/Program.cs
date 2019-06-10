using System;
using Classes;
using Classes.Event_Testing;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stress Test
            Person obj = new Person();
            Console.WriteLine("Insert your name: ");
            obj.Name = Console.ReadLine();
            Console.WriteLine("Insert your Heartbeats Per Minute: ");
            var tempBPM = Console.ReadLine();
            obj.NumberOfHeartBeatsPerMin = Convert.ToInt64(tempBPM);

            Stress objStress = new Stress();
            objStress.Stresslevel(obj);

            //Caffeine Test
            Console.WriteLine();
            Console.WriteLine();
            Caffeine Cobj = new Caffeine();
            Cobj.DrinkUp(500);
            Cobj.DrinkUp(160);
        }
    }
}
