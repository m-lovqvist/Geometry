using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Ellipse : Geometry
    {
        public double MajorRadius { get; set; }
        public double MinorRadius { get; set; }
        public float Pi { get; set; }

        public Ellipse() 
        {
            MajorRadius = 7;
            MinorRadius = 4;
            Pi = 3.141f;
        }

        public override void Area()
        {
            double i = MajorRadius * MinorRadius * Pi;
            Console.WriteLine("Area Ellipse : " + i);
            base.Area();
        }
    }
}
