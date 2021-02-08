using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLib
{
    public class Shape
    {
        protected int dictatingMeasurement;

        /// <summary>
        /// For every subclass of Shape, if a constructor does not explicitly call
        /// a base constructor, : base() will still be called. (Notice, "Creating a Shape()"
        /// is always output.)
        /// Even if the default constructor Shape() was not explicitly declared here, 
        /// it would be automatically created behind the scenes and called.
        /// 
        /// For inheritance, it's not a question of *if* a base class will be created,
        /// it's only a choice of which constructor will be called.
        /// </summary>
        public Shape()
        {
            Console.WriteLine($"Creating a Shape()");
        }

        public Shape(int size)
        {
            Console.WriteLine($"Creating a Shape(int {size})");
            dictatingMeasurement = size;
        }

        public string publicField = "Public";
        protected string protectedField = "Protected";
        private string privateField = "Private";

        public string publicProperty { get; set; }
        protected string protectedProperty { get; set; }
        private string privateProperty { get; set; }

        public virtual double CalculateArea()
        {
            return dictatingMeasurement*dictatingMeasurement;
        }
    }
}
