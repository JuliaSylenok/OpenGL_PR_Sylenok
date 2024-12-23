using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gl_test1_lab3
{
    public class Function2Renderer : FunctionRenderer
    {
        private Func<double> getYmin; // Делегат для отримання Ymin
        private Func<double> getYmax; // Делегат для отримання Ymax

        public Function2Renderer(Func<double> getYmin, Func<double> getYmax)
        {
            this.getYmin = getYmin;
            this.getYmax = getYmax;
        }

        public override double CalculateFunction(double x)
        {
            double cosValue = Math.Cos(Math.PI * x);
            if (Math.Abs(cosValue) < 1e-10) // Перевірка на область визначення
            {
                return double.NaN; // Значення не визначене
            }
            return Math.Exp(-1 / (10 * cosValue)) * Math.Sin(Math.PI * x);
        }

        public override void CalculateYBounds(double Xmin, double Xmax, int N, out double Ymin, out double Ymax)
        {
            // Використовуємо значення з інтерфейсу користувача
            Ymin = getYmin();
            Ymax = getYmax();
        }
    }


}
