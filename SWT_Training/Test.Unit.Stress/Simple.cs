using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Classes;
using Assert = NUnit.Framework.Assert;

namespace Test.Unit.Stress
{
    [TestFixture]
    public class Simple
    {
        [SetUp]

        public void Setup()
        {
            //If Needed insert something here
            
        }

        [Test]
        public void StressLevelTested_True()
        {
            
          IPerson obj = new Person() {Name = "Kurt", NumberOfHeartBeatsPerMin = 105};

          IStress objStress = new Classes.Stress();

          var Result_Expected_True = objStress.Stresslevel(obj);


          Assert.That(Result_Expected_True, Is.True);


        }

        [Test]
        public void StressLevelTested_False()
        {
            IPerson obj1 = new Person() { Name = "Vestergaard", NumberOfHeartBeatsPerMin = 90 };

            IStress objStress = new Classes.Stress();

            var Result_Expected_False = objStress.Stresslevel(obj1);

            Assert.That(Result_Expected_False, Is.False);
        }
    }
}
