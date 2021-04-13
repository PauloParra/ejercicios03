using System;


class ej09
{
  public static void Do ()
  {
	Console.WriteLine("\n[Ejercicio03.9] Declara un conjunto de enteros de tantos elementos como el valor introducido por teclado.");

   	int valorArray;

	Console.WriteLine("\nIntroduce el tamaño del array.");
	valorArray = int.Parse(Console.ReadLine());

	int[] arrayEnteros = new int[valorArray];

	Console.WriteLine("El tamaño del array es de : " + valorArray);
	
	Console.Write("\n***************\n");
  }
}