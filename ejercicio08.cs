using System;


class ej08
{
  public static void Do ()
  {
	Console.WriteLine("\n[Ejercicio03.8] Declara un conjunto de 2 cadenas de texto y asignales un valor por consola.");

   	string[] arrayString = new string[2];

	Console.WriteLine("\nIntroduce el primer texto : ");
	arrayString[0] = Console.ReadLine();

	Console.WriteLine("\nIntroduce el primer texto : ");
	arrayString[1] = Console.ReadLine();
    
	Console.WriteLine("\nHas introducido los textos : \n Texto 1 = " + arrayString[0] + "\n Texto 2 = " + arrayString[1]);
	
	Console.Write("\n***************\n");
  }
}