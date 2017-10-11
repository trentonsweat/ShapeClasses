using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Circle : Shape
    {
        //methods
        private double radius;
        // property
        public double Radius
        {
            set { radius = value; }
            get { return radius; }
        }

       //constructor
        public Circle()
        {
            Radius = 0;
        }

        public Circle(double r)
        {
            Radius = r;
        }

        // override
        public override void Draw()
        {
            Console.WriteLine("Draw a circle!");
        }

        // ovverride method to get area
        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
            //return Math.PI * Math.Pow(Radius, 2); just a different way of doing it 
        }


    }


}
