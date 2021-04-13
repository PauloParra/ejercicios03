using System;


class ej07
{
  public static void Do ()
  {
	Console.WriteLine("\n[Ejercicio03.7] Declara un conjunto de 3 numeros, asignales un valor y muestra la media de ellos.");

   	float[] arrayNumeros = {4f , 4f , 5f};

	float media = (arrayNumeros[0] + arrayNumeros[1] + arrayNumeros[2]) / arrayNumeros.Length;    	

	Console.WriteLine("\nLa media de todo el array da como resultado : " + media);
    
    Console.Write("\n***************\n");
  }
}