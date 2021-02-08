using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLib
{
    public class Square : Rectangle
    {
        public Square()
        {
            Console.WriteLine($"Creating a Square()");
        }

        // Not possible to call Shape's constructor from Square.
        // A derived class may only decide how to call its superclass. It's Rectangle's responsibility to decide how Shape should be constructed.
        //public Square(int size) : base(size) { }

        public Square(int size) : base(size, size)
        {
            Console.WriteLine($"Creating a Square(int {size})");
        }

        // Not overriding CalculateArea() here because Rectangle's calculation works for Square.
        // Since Square.CalculateArea() doesn't exist, if a Square is created and mySquare1.CalculateArea() is called, 
        // the call will get passed down the hierarchy until a defined method is found. In this case,
        // it would find Rectangle.CalculateArea() and use that.
    }
}
