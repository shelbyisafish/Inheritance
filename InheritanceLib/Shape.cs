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
        public Shape() { }
        public Shape(int size)
        {
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
