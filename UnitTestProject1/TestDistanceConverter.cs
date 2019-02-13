using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CO453_ConsoleApp.Unit4;

namespace UnitTestProject
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            double miles = 1;
            double feet = converter.MilesToFeet(miles);

            Assert.AreEqual(feet, 5280);
        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            double feet = 5280;
            double miles = converter.FeetToMiles(feet);

            Assert.AreEqual(miles, 1.00);
        }

    }
}
