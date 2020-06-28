using System;

namespace ListaExercicios2
{
    public class SomaSete
    {
        public static void SomaDosSete()
        {

            int i = 7;
            int soma = 0;
            for (i = 7; i <= 500; i++)
            {
                if (i % 7 == 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine("A Soma dos Multiplos de 7 é: " + soma + "\n");
        }
    }
}
