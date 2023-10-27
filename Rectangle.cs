using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rectangle : Geometry
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle() 
        {
            Width = 8;
            Length = 5;
        }

        public override void Area()
        {
            double i = Width * Length;
            Console.WriteLine("Area Rectangle : " + i);
            base.Area();
        }
    }
}
