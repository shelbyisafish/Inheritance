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

        public Rectangle() 
        {
            Console.WriteLine($"Creating a Rectangle()");
        }

        // Intentionally not calling the constructor for Shape.
        //protected Rectangle(int size) : base(size) { }

        public Rectangle(int length, int width)
        {
            Console.WriteLine($"Creating a Rectangle(int {length}, int {width})");
            this.length = length;
            this.width = width;
        }

        /// <summary>
        /// Override Shape's CalculateArea() with a new calculation.
        /// This hides Shape's CalculateArea() for all subclasses of Rectangle and replaces it with this one.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return length*width;
        }

        /// <summary>
        /// Shape's protected and public fields/properties are accesible to all subclasses.
        /// </summary>
        private void PropertyVisibilityFromBase()
        {
            protectedField = "rectangle test";
            protectedProperty = "rectangle test";
            publicField = "rectangle test";
            publicProperty = "rectangle test";
            return;
        }
    }
}
