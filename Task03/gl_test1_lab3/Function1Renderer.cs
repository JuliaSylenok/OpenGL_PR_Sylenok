using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gl_test1_lab3
{
    public class Function1Renderer : FunctionRenderer
    {
        public override double CalculateFunction(double x)
        {
            return Math.Tan((0.5 * Math.Sin(2 * x)) / 1.5 + Math.Cos(5 * x));
        }
    }


}
