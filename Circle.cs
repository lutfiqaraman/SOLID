using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Circle : Shape
    {
        private readonly double radius;

        public Circle(double r)
        {
            radius = r;
        }
        public override double CalcArea()
        {
            area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
