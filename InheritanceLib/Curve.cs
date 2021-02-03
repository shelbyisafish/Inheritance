using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLib
{
    public class Curve : Line
    {
        public Curve() { }
        public Curve(int size) : base(size) { }

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
