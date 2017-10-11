using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Rectangle : Shape
    {
        // members
        private double width;
        private double length;

        // properties
        public double Width
        {
            set { width = value; }
            get { return width; }
        }

        public double Length
        {
            set { length = value; }
            get { return length; }
        }

        // constructors

        public Rectangle()
        {
            Width = Length = 0;
        }

        // constructors
        public Rectangle(double w, double h)
        {
            Width = w;
            Length = h;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }

        public override double GetArea()
        {
            return Width * Length;
        }


    }
}
