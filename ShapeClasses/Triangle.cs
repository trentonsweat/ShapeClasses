using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Triangle : Shape
    {
        //members
        private double tbase;
        private double height;

        //properties
        public double Base
        {
            set { tbase = value; }
            get { return tbase;  }
        }

        public double Height
        {
            set { height = value; }
            get { return height; }
        }

        // defualt constructors
        public Triangle()
        {
            Base = Height = 0;
        }

        // constructors
        public Triangle(double b, double h)
        {
            Base = b;
            Height = h;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }

        public override double GetArea()
        {
            return Base * Height * 0.5;
        }


    }
}
