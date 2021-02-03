using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLib
{
    public sealed class Point : Shape
    {
        public Point() { }
        public Point(int size) : base(size) { }

        public override double CalculateArea()
        {
            return 1;
        }
    }
}
