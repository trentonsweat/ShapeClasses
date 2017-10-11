﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> Drawing = new List<Shape>();

            Drawing.Add(new Circle(3));
            Drawing.Add(new Circle(4));

            Drawing.Add(new Triangle(3, 4));
            Drawing.Add(new Triangle(5, 7));

            Drawing.Add(new Rectangle(2, 5));
            Drawing.Add(new Rectangle(7, 10));

            // calculate the area of the whole drawing
            // sum 
            double Sum = 0;

            for (int i = 0; i < Drawing.Count; i++)
            {    // add the area of each element (Shape)
                Sum = Sum + Drawing[i].GetArea();  // saying from this object get me this method (GetArea)
            }


            //foreach (Shape Element in Drawing)
            //{

            //    Sum = Sum + Element.GetArea(); // doing the above with a foreach 

            //}



            Console.WriteLine(Sum);



        }

    }
}
