using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            double y = 5;
            double z = 5;
            double c = 5;
            double b = 5;
            double d = 5;
            double f = 5;
            double a = 5;

            #region Выражение 6.

            double results6 = x - Math.Pow(x, 3) / 3 + Math.Pow(x, 5) / 5;
            Console.WriteLine(results6);

            #endregion

            #region Выражение 13.

            double results13 = (Math.Cos(x) / Math.PI - 2 * x) + 16 * x * Math.Cos(x * y) - 2;
            Console.WriteLine(results13);

            #endregion

            #region Выражение 42.

            double results42 = Math.Sqrt(1 - Math.Pow(Math.Sin(x),2));
            Console.WriteLine(results42);

            #endregion

            #region Выражение 28.

            double results28 = (Math.Pow(Math.Cos(x), 2) / Math.Sin(x)) - x * y * z + (a * Math.Pow(x, 2) + b * x + c / d * Math.Pow(x, 3) - f);
            Console.WriteLine(results28);

            #endregion

            #region Выражение 2.
            double results2 = (a / c * b / d) - (a * b - c / c * d);
            Console.WriteLine(results2);

            #endregion
        }

    }
}
