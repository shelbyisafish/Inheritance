using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLib
{
    public class Rectangle : Shape
    {
        private int length;
        private int width;

        // Don't call base instructor
        public Rectangle() { }

        // Call base constructor.
        public Rectangle(string someDiff) : base() { }

        /// <summary>
        /// Call base constructor
        /// </summary>
        /// <param name="size"></param>
        protected Rectangle(int size) : base(size) { }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public string publicField_Rectangle = "Public_Rectangle";
        protected string protectedField_Rectangle = "Protected_Rectangle";
        private string privateField_Rectangle = "Private_Rectangle";

        public string publicProperty_Rectangle { get; set; }
        protected string protectedProperty_Rectangle { get; set; }
        private string privateProperty_Rectangle { get; set; }

        public override double CalculateArea()
        {
            return length*width;
        }

    }
}
