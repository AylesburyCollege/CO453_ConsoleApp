using System;


namespace CO453_ConsoleApp.Unit4
{
    /// <summary>
    ///  This class demonstrates the use of multiple constructors
    ///  to initialise two attributes
    /// </summary>
    public class SomeClass
    {
        int value1;
        int value2;

        public SomeClass()
        {
            value1 = 0;
            value2 = 0;
        }

        public SomeClass(int value1)
        {
            this.value1 = value1;
            value2 = 0;
        }

        public SomeClass(int value1, int value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }
        public void OutputValues()
        {
            Console.WriteLine("The value of value1 is " + value1);
            Console.WriteLine("The value of value2 is " + value2);
        }
    }
}
