using System;

namespace CO453_ConsoleApp.Unit4
{
    class TestSomeClass
    {
        public static void TestConstructors()
        {
            Console.WriteLine("\n\n=============================================================");
            Console.WriteLine("DEFAULT and NON-DEFAULT Constructors");
            Console.WriteLine("=============================================================");

            // remember that the constructor is the method which has the same name as the class

            Console.WriteLine("\nDefault:");
            SomeClass object1 = new SomeClass(); //default constructor
            object1.OutputValues();

            Console.WriteLine("\nNon-default (1 parameter):");
            SomeClass object2 = new SomeClass(55); //non-default constructor
            object2.OutputValues();

            Console.WriteLine("\nNon-default (2 parameters):");
            SomeClass object3 = new SomeClass(66, 77); //non-default constructor
            object3.OutputValues();

            Console.ReadKey();
        }
    }
}
