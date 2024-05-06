using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD1
{
    class simpsona_metode
    {
        public simpsona_metode()
        {

        }
        public void runMethod(double v)
        {
            Console.WriteLine("Simpsona metode:");
            double a = 0;
            double n = v;
            double b = 2;
            double i = a;
            double h = (b - a) / (2 * n);
            List<double> x = new List<double>();
            List<double> firstformula = new List<double>();

            while (i <= b)
            {
                x.Add(i);
                i += h;
                i = Math.Round(i,13);
            };
            Console.WriteLine();


            for (int j = 0; j < x.Count(); j++)
            {
                if (x[j] < 1)
                {
                    firstformula.Add(Math.Round(1 / (Math.Pow(x[j], 2) + 4 * x[j] + 5), 7));
                }
                else if (x[j] >= 1)
                {
                    firstformula.Add(Math.Round(Math.Pow(x[j], 2) / 10, 7));
                }
            }

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("n = {0}", n);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine();
            Console.WriteLine("h = ( b - a ) / (2 * n)");
            Console.WriteLine("h = {0}", h);
            Console.WriteLine();

            for (int j = 0; j < x.Count(); j++)
            {
                Console.WriteLine(" x{0}: {1};", j, x[j]);
            }

            Console.WriteLine();
            Console.WriteLine("Formula = x < 1  | 1 / x2 + 4 * x + 5;");
            Console.WriteLine("Formula = x >= 1 | x2 / 10");
            Console.WriteLine();

            for (int j = 0; j < firstformula.Count(); j++)
            {
                if (x[j] < 1)
                {
                    Console.WriteLine("y{0}: {1}", j, firstformula[j]);
                }
                else
                {
                    Console.WriteLine("y{0}: {1}", j, firstformula[j]);
                }
            }
            Console.WriteLine();

            double sumEven = 0;
            double sumOdd = 0;
            int indexFirst = 0;
            int indexLast = firstformula.Count() - 1;
            int indexPrevious = indexLast - 1;

            for (int j = 0; j < x.Count(); j++)
            {
                if (j != indexFirst && j != indexLast && j != indexPrevious)
                {
                    if (j % 2 == 0)
                    {
                        sumEven += firstformula[j];
                    }
                    else
                    {
                        sumOdd += firstformula[j];
                    }
                }
            }
            
            double calculateEven = firstformula[indexPrevious] + 2 * sumEven ;
            double calculateOdd = firstformula[indexFirst] + firstformula[indexLast] + 4 * sumOdd;
            double integral = (h / 3) * ( calculateOdd + calculateEven );
            Console.WriteLine("");
            Console.WriteLine("I: {0}", Math.Round(integral, 5));

            Console.WriteLine();

        }
    }
}
