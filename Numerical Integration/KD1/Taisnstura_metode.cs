using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD1
{
    class Taisnstura_metonde
    {
        public Taisnstura_metonde()
        {
           
        }
        public void runMethod(double v)
        {
                Console.WriteLine("1 KD:");
                Console.WriteLine("Taisnstura metode:");
                double a = 0;
                double n = v;
                double b = 2;
                double i = a;
                double h = (b - a) / n;
                List<double> x = new List<double>();
                List<double> firstformula = new List<double>();

                while (i <= b)
                {
                    x.Add(Math.Round(i, 1));
                    i += h;
                };

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
                Console.WriteLine("h = ( b - a ) / n");
                Console.WriteLine("h = {0}", h);
                Console.WriteLine();

                for (int j = 0; j < firstformula.Count(); j++)
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

                double II = h * firstformula.Skip(1).Sum(x => x);
                double I = h * firstformula.Sum(x => x);

                Console.WriteLine();
                Console.WriteLine("h={0}", h);
                Console.WriteLine("Ysum={0}", firstformula.Sum(x => x));
                Console.WriteLine("Y(0) - Ysum={0}", firstformula.Skip(1).Sum(x => x));
                Console.WriteLine();

                Console.WriteLine("Ar kreiso I={0}", Math.Round(I, 5));
                Console.WriteLine("Ar labo I={0}", Math.Round(II, 5));

            }
        }
    }
