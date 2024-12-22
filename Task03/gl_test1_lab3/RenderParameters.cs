using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gl_test1_lab3
{
    public class RenderParameters
    {
        public double Xmin { get; set; } = -2;
        public double Xmax { get; set; } = 4;
        public int N { get; set; } = 2000;

        public double Ymin { get; set; } = -2;
        public double Ymax { get; set; } = 4;

        public FunctionRenderer CurrentRenderer { get; set; } = new Function1Renderer();

        public void UseFunction1()
        {
            CurrentRenderer = new Function1Renderer();
        }

        public void UseFunction2(Func<double> getYmin, Func<double> getYmax)
        {
            CurrentRenderer = new Function2Renderer(getYmin, getYmax);
        }
    }

}
