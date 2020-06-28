using System;

namespace ListaExercicios2
{
    public class MediaAlunos
    {
        public static void Media()
        {
            // Valor da Variável
            int nota1;
            int nota2;
            int nota3;
            int media1;
            // 1ª Forma Inserção de Dados:
            Console.WriteLine("Digite a 1ª Nota: ");
            nota1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 2ª Nota: ");
            nota2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 3ª Nota: ");
            nota3 = Int32.Parse(Console.ReadLine());

            // 2ª Forma Inserção de Dados:
            //nota2 = Convert.ToInt32(Console.ReadLine());

            media1 = ((nota1 + nota2 + nota3) / 3);

            if (media1 >= 7)
            { // Maior ou Igual ao Resultado 21
                Console.WriteLine("=================");
                Console.WriteLine(" ALUNO APROVADO!");
                Console.WriteLine("=================");
            }
            else if (media1 >= 5)
            { // Menor ou Igual ao Resultado 20
                Console.WriteLine("====================");
                Console.WriteLine(" ALUNO RECUPERAÇÃO!");
                Console.WriteLine("====================");
            }
            else
            { // Caso Contrário
                Console.WriteLine("==================");
                Console.WriteLine(" ALUNO REPROVADO!");
                Console.WriteLine("==================");
            }
        }
    }
}
