using System;

namespace ExerciciosDois
{
    public class TabuadaSelect 
    {
        public static void Tabuada()
        {
        int Num; // Valor da Variável
        int inicio;
        int fim;

        Console.WriteLine("\nInforme a Tabuada: ");
        Num = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Informe o inicio da tabuada: ");
        inicio = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Informe o fim da tabuada: ");
        fim = Int32.Parse(Console.ReadLine());

            for (int i = inicio; i <= fim; i++) {
                Console.WriteLine(" " + Num + " x " + i + " = " + Num * i);
                Console.WriteLine(" ");
            }
        
        }

    }
}
