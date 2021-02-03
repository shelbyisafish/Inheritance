using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLib
{
    public class Triangle : Shape
    {
        private int baseLength;
        private int height;

        public Triangle() { }
        public Triangle(int baseLength, int height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }
        // Don't need to call base Shape constructor if don't need to.

        public string publicField_Triangle = "Public_Triangle";
        protected string protectedField_Triangle = "Protected_Triangle";
        private string privateField_Triangle = "Private_Triangle";

        public string publicProperty_Triangle { get; set; }
        protected string protectedProperty_Triangle { get; set; }
        private string privateProperty_Triangle { get; set; }

        public override double CalculateArea()
        {
            return baseLength*height*0.5;
        }
    }
}
