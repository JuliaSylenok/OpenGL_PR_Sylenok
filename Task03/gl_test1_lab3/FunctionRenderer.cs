using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gl_test1_lab3
{
    public abstract class FunctionRenderer
    {
        public abstract double CalculateFunction(double x);

        public virtual void CalculateYBounds(double Xmin, double Xmax, int N, out double Ymin, out double Ymax)
        {
            double step = (Xmax - Xmin) / N;
            double ymin = double.MaxValue;
            double ymax = double.MinValue;

            for (double x = Xmin; x <= Xmax; x += step)
            {
                double y = CalculateFunction(x);

                if (!double.IsInfinity(y) && !double.IsNaN(y))
                {
                    if (y < ymin) ymin = y;
                    if (y > ymax) ymax = y;
                }
            }

            Ymin = Math.Floor(ymin);
            Ymax = Math.Ceiling(ymax);
        }
    }


}
