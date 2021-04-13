using System;


class ej05
{
  public static void Do ()
  {
	Console.WriteLine("\n[Ejercicio03.5] Declara un conjunto de 4 caracteres, asignales un valor y muestra el tercero de ellos por consola.");

   	char[] arrayChar = {'A', 'B', 'C', 'D'}; 

   	
	Console.WriteLine("Has asignado los siguientes valores : ");
	Console.WriteLine(arrayChar[0]);
	Console.WriteLine(arrayChar[1]);
	Console.WriteLine(arrayChar[2]);
	Console.WriteLine(arrayChar[3]);

	Console.WriteLine("\nEl tercer elemento del array es : " + arrayChar[2]);

    
    Console.Write("\n***************\n");
  }
}