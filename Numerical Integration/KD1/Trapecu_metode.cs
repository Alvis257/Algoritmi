using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD1
{
    class Trapecu_metode
    {
        public Trapecu_metode()
        {

        }
        public void runMethod(double v)
        {
            Console.WriteLine("Trapecu metode:");
            double a = 0;
            double n = v;
            double b = 2;
            double i = a;
            double h = (b - a) / n;
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            while (i <= b)
            {
                x.Add(Math.Round(i, 1));
                i += h;
            };


            for (int j = 0; j < x.Count(); j++)
            {
                //y.Add(Math.Sqrt(1 - Math.Pow(x[j],2)));
                if (x[j] < 1)
                {
                    y.Add(Math.Round(1 / (Math.Pow(x[j], 2) + 4 * x[j] + 5), 7));
                }
                else if (x[j] >= 1)
                {
                    y.Add(Math.Round(Math.Pow(x[j], 2) / 10, 7));
                }
            }
            int first = 0;
            int last = y.Count() - 2;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("n = {0}", n);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine();
            Console.WriteLine("h = ( b - a ) / n");
            Console.WriteLine("h = {0}", h);
            Console.WriteLine();

            for (int j = 0; j < y.Count(); j++)
            {
                Console.WriteLine(" x{0}: {1};", j, x[j]);
            }

            Console.WriteLine();
            Console.WriteLine("Formula = x < 1  | 1 / x2 + 4 * x + 5;");
            Console.WriteLine("Formula = x >= 1 | x2 / 10");
            Console.WriteLine();

            for (int j = 0; j < y.Count(); j++)
            {
                if (x[j] < 1)
                {
                    Console.WriteLine("y{0}: {1}", j, y[j]);
                }
                else
                {
                    Console.WriteLine("y{0}: {1}", j, y[j]);
                }
            }

            double sumOfYwithoutFirstandLast = Math.Round(y.Skip(1).Take(last).Sum(),7);
            double summ = ((y[first] + y[y.Count() - 1]) / 2 + sumOfYwithoutFirstandLast);
            double I = h * ((y[first] + y[y.Count()-1]) / 2 + sumOfYwithoutFirstandLast);

            Console.WriteLine("h={0}", h);
            Console.WriteLine("Ysum={0}", summ);
            Console.WriteLine();

            Console.WriteLine("I={0}", Math.Round(I, 5));

        }
    }
}
