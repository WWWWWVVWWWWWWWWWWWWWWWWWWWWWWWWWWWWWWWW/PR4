using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Equation
{
    public static class Math_Equation
    {
        public static (double? x1, double? x2)
            SolveQuadraticEquation(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return (x1, x2);

            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                return (x, x);
            }
            else
            {
                return (null, null);
            }
        }
    }
}
