using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_ConsoleApp.Unit4
{
    /// <summary>
    /// This class will 
    /// </summary>
    public class DistanceConverter
    {
        public const double NO_FEET_PER_MILE = 1760 * 3;

        public double MilesToFeet(double miles)
        {
            return miles * NO_FEET_PER_MILE;
        }

        public double FeetToMiles(double feet)
        {
            return feet / NO_FEET_PER_MILE;
        }


    }
}
