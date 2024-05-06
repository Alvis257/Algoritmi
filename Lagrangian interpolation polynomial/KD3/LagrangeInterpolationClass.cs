using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD3
{
    class LagrangeInterpolationClass
    {
        public double LagrangeInterpolation(double[] x, double[] y, double argument)
        {
            double result = 0;
            for (int i = 0; i < x.Length; i++)
            {
                double term = y[i];
                string formula = $"y[{i}]";
                for (int j = 0; j < x.Length; j++)
                {
                    if (j != i)
                    {
                        term *= (argument - x[j]) / (x[i] - x[j]);
                        formula += $" * (arguments - {x[j]}) / ({x[i]} - {x[j]})";
                    }
                }
                result += term;
                Console.WriteLine($"Solis {i + 1}: arguments = {term}");
                Console.WriteLine($"\t formula = {formula}");
                Console.WriteLine();
            }
            return result;
        }
    }
}
