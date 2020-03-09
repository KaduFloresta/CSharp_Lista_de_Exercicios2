using System;

namespace ExerciciosDois
{
    public class FatorialNumero 
    {
        public static void Fatorial()
        {           
		Console.Write("Introduza o numero: ");
		int num = Int32.Parse(Console.ReadLine());
		int factorial = 1;

			if (num != 0)
			{
				for (int i = 1; i <= num; i++) factorial = factorial * i;
			}

		Console.WriteLine("Factorial de " + num + " = " + factorial);            
        }
    }
}

