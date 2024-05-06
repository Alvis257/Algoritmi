using KD2;


double[] argumentValues = { 3.0027, 3.7273, 2.9025, 3.5065, 3.8925 };
double[] x = { 3.0, 3.1, 3.2, 3.3, 3.4, 3.5, 3.6, 3.7, 3.8 };
double[] y = { 3.093, 4.346, 5.766, 7.367, 9.158, 11.149, 13.349, 15.765, 18.401 };

//double[] argumentValues = { 54 };
//double[] x = { 30, 35, 40, 35, 50, 55 };
//double[] y = { 0.5000, 0.5736, 0.6428, 0.7071, 0.7660, 0.8192 };

int n = x.Count();
var clas = new MainClass();

Console.WriteLine("1. Galīgā diferenču tabula:");

double[,] diffTable = clas.CalculateDifferenceTable(x, y, n);

for (int i = 0; i < n; i++)
{
    Console.Write("y{0} |", i);
    for (int j = 0; j < n-i; j++)
    {
        Console.Write("\t"+diffTable[i, j]);
    }
    Console.WriteLine();
}

for (int i = 0; i < argumentValues.Length; i++)
{
    double arguments = argumentValues[i];
    Console.WriteLine($"argument: {arguments}");
    double interpolatedValue = clas.NewtonInterpolation(x, y, n, arguments);
    Console.WriteLine("\nFunkcijas vērtība pie x = " + arguments + ": " + interpolatedValue);

    double actualValue = y[i]; // Actual value corresponding to arguments
    double error = Math.Abs(actualValue - interpolatedValue);
    Console.WriteLine("Kļūda: " + error);
}

Console.ReadLine();
