using System;
using CO453_ConsoleApp.Unit4;
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

            //TestBook.Test();
            TestDistanceConverter.TestChoices();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public void Archive()
        {
            // Task 4.1
            TestDistanceConverter.TestMilesToFeet();
            TestDistanceConverter.TestFeetToMiles();
        }
    }
}
