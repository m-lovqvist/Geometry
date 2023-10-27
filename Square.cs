using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square : Geometry
    {
        public double Side { get; set; }

        public Square() 
        {
            Side = 7;
        }

        public override void Area()
        {
            double i = Side * Side;
            Console.WriteLine("Area Square : " + i);
            base.Area();
        }
    }
}
