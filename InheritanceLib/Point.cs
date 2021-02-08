using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLib
{
    /// <summary>
    /// A sealed, derived class.
    /// Sealed = no classes can be derived from Point.
    /// </summary>
    public sealed class Point : Shape
    {
        public Point()
        {
            Console.WriteLine($"Creating a Point()");
        }

        public Point(int size) : base(size)
        {
            Console.WriteLine($"Creating a Point(int {size})");
        }

        public override double CalculateArea()
        {
            return 1;
        }
    }
}
