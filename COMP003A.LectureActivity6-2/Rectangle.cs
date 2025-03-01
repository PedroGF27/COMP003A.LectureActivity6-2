﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length; Width = width;
        }

        public override void DisplayArea()
        {
            Console.WriteLine($"rectangle Area: {Length * Width}");
        }
    }
}
