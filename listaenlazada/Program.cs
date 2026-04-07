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
Locomotora b = new Locomotora();
b.AgregaInt(5);
b.AgregaInt(3);
b.AgregaInt(10);
b.AgregaFin(7);
b.Imprime();

Console.WriteLine(b.Get(2));
Console.WriteLine($"Hay {b.Length} elementos");
Console.WriteLine("Ingrese valor a buscar");
int vbus = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(b.BuscaValor(vbus)? "Joel Estuvo aqui" : "Pero lo buscaba tanto");


