using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_ConsoleApp.Unit4
{
    /// <summary>
    /// 
    /// </summary>
    class TestDistanceConverter
    {
        private static double miles;
        private static double feet;

        private DistanceConverter converter = new DistanceConverter();

        /// <summary>
        /// This method will ask the user to enter the number of miles
        /// and it will convert that value to feet and display the
        /// result to the user
        /// </summary>
        public void TestMilesToFeet()
        {

            UserLib.WriteTitle("Task 4.1 Miles -> Feet");

            miles = UserLib.GetDouble("Please enter the number of miles > ");
            feet = converter.MilesToFeet(miles);
            Console.WriteLine("The number of feet = " + feet);
        }

        /// <summary>
        /// 
        /// </summary>
        public void TestFeetToMiles()
        {
            UserLib.WriteTitle("Task 4.1 Feet -> Miles");

            feet = UserLib.GetDouble("Please enter the number of feet > ");
            miles = converter.FeetToMiles(feet);
            Console.WriteLine("The number of miles = " + miles.ToString("#.##"));
        }

        public static void TestChoices()
        {
            string [] choices = new string [] {"Miles to Feet", "Feet to Miles", "Quit"};
            UserLib.GetChoice(choices);
        }
    }
}
