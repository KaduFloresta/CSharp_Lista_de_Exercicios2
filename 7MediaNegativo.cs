using System;

namespace ListaExercicios2
{
    public class MediaAlunosNegativo
    {
        public static void MediaNegativo()
        {
            int cont7 = 0;
            double nota7;
            double soma7 = 0;

            do
            {
                Console.WriteLine("\nInforme a Nota " + (cont7 + 1));
                nota7 = Int32.Parse(Console.ReadLine());

                if (nota7 >= 0) // >0 = Continua o laço...
                {
                    soma7 += nota7;
                    cont7++;
                }
            } while (nota7 >= 0); // <0 = Encerra o laço...

            Console.WriteLine("A MÉDIA É: " + (soma7 / cont7));

        }
    }
}
