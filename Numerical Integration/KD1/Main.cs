using KD1;
using static KD1.Taisnstura_metonde;
using static KD1.Trapecu_metode;
using static KD1.simpsona_metode;

var simpsona = new simpsona_metode();
var taisnstura = new Taisnstura_metonde();
var trapecu = new Trapecu_metode();
var n = 2;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("n={0}", n);
    Console.WriteLine("----------------------------------------------------");
    taisnstura.runMethod(n);
    Console.WriteLine("----------------------------------------------------");
    trapecu.runMethod(n);
    Console.WriteLine("----------------------------------------------------");
    simpsona.runMethod(n);
    Console.WriteLine("----------------------------------------------------");
    n = n * 2;
}