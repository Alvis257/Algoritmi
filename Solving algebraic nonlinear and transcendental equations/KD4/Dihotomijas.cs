using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD4
{
    internal class Dihotomijas
    {
        static double f(double x)
        {
            return 2 * x - Math.Pow(Math.E, -x);
        }

        public void DihotomijasMethod(double a, double b, double tolerance)
        {
            int iterations = 0;
            double c;

            Console.WriteLine("Dihotomijas Metode:");
            Console.WriteLine("Iteracijas   \t a           \t b           \t c           \t f(c)   \t|b - a|");
            Console.WriteLine();
            do
            {
                c = (a + b) / 2;
                iterations++;
                if (f(c) < 0)
                {
                    Console.WriteLine($"{iterations}\t\t{Math.Round(a, 5)}\t\t{Math.Round(b, 5)}\t\t{Math.Round(c, 5)}\t\t{Math.Round(f(c), 5)}\t{Math.Round(b - a, 5)}");
                }
                else
                {
                    Console.WriteLine($"{iterations}\t\t{Math.Round(a, 5)}\t\t{Math.Round(b, 5)}\t\t{Math.Round(c, 5)}\t\t{Math.Round(f(c), 5)}\t\t{Math.Round(b - a, 5)}");
                }
                if (f(c) == 0 || (b - a) / 2 < tolerance)
                    break;
                else if (f(c) * f(a) < 0)
                    b = c;
                else
                    a = c;
            } while (true);
            Console.WriteLine();
            Console.WriteLine($"Sakne atrasta pie x = {Math.Round(c,5)} pec {iterations} iteracijam.");
        }
    }
}
