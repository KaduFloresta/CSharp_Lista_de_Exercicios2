using System;

namespace ListaExercicios2
{
    public class StPalavra
    {
        public static void StPalavraLetra()
        {

            Console.WriteLine("\nInforme a Palavra: ");
            string palavra5 = Console.ReadLine();

            for (int i = 0; i < palavra5.Length; i++)
            {
                Console.WriteLine(palavra5[i]);
            }
        }

    }
}
