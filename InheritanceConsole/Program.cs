using InheritanceLib;
using System;

namespace InheritanceConsole
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        /// <summary>
        /// Shape's public fields/properties are accesible via an instance of Shape.
        /// Shape and Triangle's public field/properties are accessible via an instance of Triangle.
        /// </summary>
        private void PropertyVisibilityFromBase()
        {
            Shape shape1 = new Shape();
            shape1.publicField = "program test";
            shape1.publicProperty = "program test";

            Triangle triangle1 = new Triangle();
            triangle1.publicField = "triangle test";
            triangle1.publicProperty = "triangle test";
            triangle1.publicField_Triangle = "triangle test";
            triangle1.publicProperty_Triangle = "triangle test";

            return;
        }
    }
}
