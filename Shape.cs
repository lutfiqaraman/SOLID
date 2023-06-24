using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    abstract class Shape
    {
        protected double  area;
        public abstract double CalcArea();
    }
}
