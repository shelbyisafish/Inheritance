using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLib
{
    public class Line : Shape
    {
        public Line() { }
        public Line(int size) : base(size) { }

        public sealed override double CalculateArea()
        {
            // Call base method
            return base.CalculateArea();
        }
    }
}
