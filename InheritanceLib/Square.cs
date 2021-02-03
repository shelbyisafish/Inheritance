using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLib
{
    public class Square : Rectangle
    {
        public Square() { }

        /// <summary>
        /// Calls Rectangle constructure, not Shape.
        /// </summary>
        /// <param name="size"></param>
        public Square(int size) : base(size, size) { }

        /// <summary>
        /// Don't need to override base method unless there's something more to add.
        /// This would call Rectangle.CalculateArea().
        /// </summary>
        /// <returns></returns>
        //public override double CalculateArea()
        //{
        //    return base.CalculateArea();
        //}
    }
}
