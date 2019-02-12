using System;
using CO453_ConsoleApp.Unit4;
using CO453_ConsoleApp.SPS;

namespace CO453_ConsoleApp
{
    /// <summary>
    /// Author: Derek Peacock
    /// 
    /// This class will run all the console app examples
    /// required for module CO453 Applications Programming
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            GameInterface.RunGame();
            Console.ReadKey();
        }

        public void Archive()
        {
            // Task 4.1
            //TestDistanceConverter.TestMilesToFeet();
            //TestDistanceConverter.TestFeetToMiles();

            //TestBook.Test();
            //TestDistanceConverter.TestChoices();
        }
    }
}
