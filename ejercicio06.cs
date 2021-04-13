using System;


class ej06
{
  public static void Do ()
  {
	Console.WriteLine("\n[Ejercicio03.1] Declara un conjunto de enteros.");

   	float[] arrayNumeros = {4f , 4f , 5f, 1.2f ,100f};

	float suma = arrayNumeros[0] + arrayNumeros[1] + arrayNumeros[2] + arrayNumeros[3] + arrayNumeros[4];    	

	Console.WriteLine("\nLa suma de todo el array da como resultado : " + suma);
    
    Console.Write("\n***************\n");
  }
}