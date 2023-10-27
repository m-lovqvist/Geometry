using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Parallellogram : Geometry
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Parallellogram() 
        {
            Base = 3;
            Height = 9;
        }

        public override void Area()
        {
            double i = Base * Height;
            Console.WriteLine("Area Parallellogram : " + i);
            base.Area();
        }
    }
}
