using KD3;


double[] x = { 0, 10, 20, 30, 40, 50 };
double[] y = { 10, 7.5, 5.1, 3.0, 1.8, 1.1 };
double argument = 27;
var interpolationMethod = new LagrangeInterpolationClass();
Console.WriteLine($"Dotas vertibas (x): {string.Join(", ", x)}");
Console.WriteLine($"Dotas funkcijas vertibas (y): {string.Join(", ", y)}");
Console.WriteLine($"Interpolacijas arguments: {argument}\n");

double interpolatedValue = interpolationMethod.LagrangeInterpolation(x, y, argument);

Console.WriteLine($"\nIterpolacijas funkcijas vertiba pie argumenta {argument}: {interpolatedValue}");

Console.ReadLine();