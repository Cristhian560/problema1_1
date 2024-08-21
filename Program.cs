// See https://aka.ms/new-console-template for more information
using problema1_1.Implementaciones;
using problema1_1.Interfaces;

Console.WriteLine("Hello, World!");
IColleccion colleccion = new Pila();
colleccion.añadir("numero1");
colleccion.añadir("numero2");
colleccion.estaVacia();
colleccion.extraer();