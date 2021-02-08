using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLib
{
    public class Curve : Line
    {
        public Curve()
        {
            Console.WriteLine($"Creating a Curve()");
        }
        public Curve(int size) : base(size)
        {
            Console.WriteLine($"Creating a Curve(int {size})");
        }

        /// <summary>
        /// Cannot override a sealed method.
        /// </summary>
        /// <returns></returns>
        //public override double CalculateArea()
        //{
        //    return dictatingMeasurement;
        //}
    }
}
