using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) 
        {
            Radius = radius;
        }

        public override void DisplayArea()
        {
            Console.WriteLine($"Circle Area: {Math.PI * Radius * Radius}");
        }
    }
}
