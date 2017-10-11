using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    abstract class Shape
    {   // all abstract methods are virtual!

        public abstract void Draw(); // abstract method

        public abstract double GetArea(); // abstract method

        public override string ToString()
        {
            return "The area of this shape is:" + GetArea();

        }


    }
}
