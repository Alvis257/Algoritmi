// See https://aka.ms/new-console-template for more information
using KD4;

double a = 0;
double b = 1;
double tolerance = 1e-5;
var bisection = new Dihotomijas();
var secant = new Hordu();
bisection.BisectionMethod(a, b, tolerance);
secant.SecantMethod(a, b, tolerance);