using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : Geometry
    {
        public double Radius { get; set; }
       
        public float Pi { get; set; }

        public Circle() 
        {
            Radius = 4;
            Pi = 3.141f;
        }

        public override void Area()
        {
            double i = Radius * Radius * Pi;
            Console.WriteLine("Area Circle : " + i);
            base.Area();
        }
    }

}
