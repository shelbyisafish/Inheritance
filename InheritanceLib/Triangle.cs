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

        // Even though these constructors do not explicitly call : base(), the 
        // parent's default constructor will be called automatically, even if Shape() is not
        // explicitly declared.
        //
        // In other words,
        //      public Triangle()
        // is equivalent to
        //      public Triangle() : base()

        public Triangle()
        {
            Console.WriteLine($"Creating a Triangle()");
        }

        public Triangle(int baseLength, int height)
        {
            Console.WriteLine($"Creating a Triangle(int {baseLength}, int {height})");
            this.baseLength = baseLength;
            this.height = height;
        }

        public string publicField_Triangle = "Public_Triangle";
        protected string protectedField_Triangle = "Protected_Triangle";
        private string privateField_Triangle = "Private_Triangle";

        public string publicProperty_Triangle { get; set; }
        protected string protectedProperty_Triangle { get; set; }
        private string privateProperty_Triangle { get; set; }

        /// <summary>
        /// Override Shape's CalculateArea() with a new calculation.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return baseLength*height*0.5;
        }

        /// <summary>
        /// Shape's protected and public fields/properties are accesible to all subclasses.
        /// </summary>
        private void PropertyVisibilityFromBase()
        {
            protectedField = "triangle test";
            protectedProperty = "triangle test";
            publicField = "triangle test";
            publicProperty = "triangle test";
            return;
        }
    }
}
