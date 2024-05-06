namespace KD2
{
    class MainClass
    {

        public double[,] CalculateDifferenceTable(double[] x, double[] y, int n)
        {
            double[,] diffTable = new double[x.Count(), y.Count()];

            for (int i = 0; i < y.Count(); i++)
            {
                diffTable[i, 0] = y[i];
            }

            for (int j = 1; j <= n; j++)
            {
                for (int i = 0; i < n - j; i++)
                {
                    diffTable[i, j] = Math.Round(diffTable[i + 1, j - 1] - diffTable[i, j - 1], 4);
                }
            }

            return diffTable;
        }

        public double NewtonInterpolation(double[] x, double[] y, int n, double arguments)
        {
            double result = y[5];
            Console.WriteLine($"First rezult:{result}");
            double[,] diffTable = CalculateDifferenceTable(x, y, n);
            double q = (arguments - x[n - 1]) / (n - 1);
            double temp = q;

            for (int j = 1; j < n; j++)
            {

                for (int i = 0; i < n; i++)
                {

                    if (j + i == n - 1)
                    {
                        for (int k = 1; k < j; k++)
                        {
                            if (j != 1)
                            {
                                temp *= q + k;
                                temp = Math.Round(temp, 6);
                            }
                        }

                        result += Math.Round(diffTable[i, j] * temp / Factorial(j), 6);
                    }

                }
            }

            Console.WriteLine(temp); 
            Console.WriteLine( Math.Round(temp/Factorial(n-1) * diffTable[0, n-1],6));
            return Math.Round(result,6);
        }

        public double Factorial(double n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}


