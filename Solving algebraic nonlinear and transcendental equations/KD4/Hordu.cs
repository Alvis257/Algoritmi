using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD4
{
    internal class Hordu
    {
        static double f(double x)
        {
            return 2 * x - Math.Pow(Math.E, -x);
        }

        public void HorduMethod(double x0, double x1, double tolerance)
        {
            int iterations = 0;
            double x2;
            Console.WriteLine();
            Console.WriteLine("Hordu Metode:");
            Console.WriteLine("Iteracijas   \tx0        \tx1        \tx2        \tf(x2)      \t|x2 - x1|");
            Console.WriteLine();
            do
            {
                x2 = x1 - f(x1) * (x1 - x0) / (f(x1) - f(x0));
                iterations++;
                if (f(x2)<0)
                {
                    Console.WriteLine($"{iterations}\t\t{Math.Round(x0, 5)}\t\t{Math.Round(x1, 5)}\t\t{Math.Round(x2, 5)}\t\t{Math.Round(f(x2), 5)}\t{Math.Round(Math.Abs(x2 - x1), 5)}");

                }
                else {
                    Console.WriteLine($"{iterations}\t\t{Math.Round(x0, 5)}\t\t{Math.Round(x1, 5)}\t\t{Math.Round(x2, 5)}\t\t{Math.Round(f(x2), 5)}\t\t{Math.Round(Math.Abs(x2 - x1), 5)}");
                }
                if (Math.Abs(x2 - x1) < tolerance)
                    break;

                x0 = x1;
                x1 = x2;
            } while (true);
            Console.WriteLine();
            Console.WriteLine($"Sakne atrasta pie x = {Math.Round(x2, 5)} pec {iterations} iteracijam.");
        }
    }
}
