using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_ConsoleApp.Unit5
{
    public class Car
    {
        // attribue
        private string make = "Honda";

        // property
        public string Model { get; set; }

        public Car()
        {
            Model = "Jazz";
        }

        public Car(string make, string model)
        {
            this.make = make;
            this.Model = model;
        }

        // Method
        public void Drive()
        {

        }

    }
}
