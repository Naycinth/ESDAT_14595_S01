// See https://aka.ms/new-console-template for more information
using listaenlazada;
/*
Locomotora a = new Locomotora();
Vagon v1 = new Vagon(1);
Vagon v2 = new Vagon(2);
a.Primero = v1;
v1.Sig = v2;
a.Imprime();
Console.WriteLine();

Vagon v3 = new Vagon(3);
v1 = a.Primero;
v3.Sig = v1;
a.Primero = v3;
a.Imprime();
*/
Console.WriteLine();
/*
Locomotora z = new Locomotora();
z.AgregaInt(5);
z.AgregaInt(3);
z.AgregaInt(10);
z.AgregaFin(7);
z.Imprime();

Console.WriteLine(z.Get(2));
Console.WriteLine($"Hay {z.Length} elementos");
Console.WriteLine("Ingrese valor a buscar");
int vbus = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(z.BuscaValor(vbus)? "Joel Estuvo aqui" : "Pero lo buscaba tanto");
*/

Locomotora a = new Locomotora();
a.AgregaFin(1);
a.AgregaFin(3);
a.AgregaFin(5);

Locomotora b = new Locomotora();
b.AgregaFin(2);
a.AgregaFin(4);
a.AgregaFin(6);

a.Imprime(); //1,2,3
a.MerclaAlFinal(b);
a.Imprime(); //1,3,5,2,4 ,6


