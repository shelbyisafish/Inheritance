using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLib
{
    public class Line : Shape
    {
        public Line()
        {
            Console.WriteLine($"Creating a Line()");
        }

        public Line(int size) : base(size)
        {
            Console.WriteLine($"Creating a Line(int {size})");
        }

        /// <summary>
        /// A sealed method.
        /// Sealed = no subclasses of Line may override/be derived from Line.CalculateArea().
        /// </summary>
        /// <returns></returns>
        public sealed override double CalculateArea()
        {
            // Just call base method
            return base.CalculateArea();
        }
    }
}
