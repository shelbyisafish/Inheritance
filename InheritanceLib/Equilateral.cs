using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLib
{
    public class Equilateral : Triangle
    {        
        public Equilateral()
        {
            Console.WriteLine($"Creating an Equilateral()");
        }

        public Equilateral(int baseLength, int height) : base(baseLength, height)
        {
            Console.WriteLine($"Creating an Equilateral(int {baseLength}, int {height})");
        }

        /// <summary>
        /// Shape's protected and public fields/properties are accesible to all subclasses.
        /// Equilateral can also see protected and public fields/properties of base class Triangle.
        /// </summary>
        private void PropertyVisibilityFromBase()
        {
            protectedField = "equilateral test";
            protectedProperty = "equilateral test";
            publicField = "equilateral test";
            publicProperty = "equilateral test";

            protectedField_Triangle = "equilateral test";
            protectedProperty_Triangle = "equilateral test";
            publicField_Triangle = "equilateral test";
            publicProperty_Triangle = "equilateral test";

            return;
        }
    }
}
