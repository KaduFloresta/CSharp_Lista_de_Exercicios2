using System;

namespace ListaExercicios2
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
            Console.WriteLine("Informe o Ínicio da Tabuada: ");
            inicio = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Fim da Tabuada: ");
            fim = Int32.Parse(Console.ReadLine());

            for (int i = inicio; i <= fim; i++)
            {
                Console.WriteLine(" " + Num + " x " + i + " = " + Num * i);
            }

        }

    }
}
