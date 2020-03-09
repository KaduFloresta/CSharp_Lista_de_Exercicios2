using System;

namespace ExerciciosDois
{
    public class OperacoesMatematicas 
    {
        public static void Operacoes()
        {
        int valorA = 0;
        int valorB = 0;
        int adicao;
        int subtracao;
        int multiplicacao;
        int divisao;
        int menu = 0;

        Console.WriteLine("\nInforme o 1º Valor: ");
        valorA = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Informe o 2º Valor: ");
        valorB = Int32.Parse(Console.ReadLine());

            do {
                Console.WriteLine("DIgite: 1 para Adição");
                Console.WriteLine("        2 para Subtração");
                Console.WriteLine("        3 para Multiplicação");
                Console.WriteLine("        4 para Divisão ");
                menu = Int32.Parse(Console.ReadLine());
                switch (menu) 
                    {
                    case 1:
                        adicao = (valorA + valorB);
                        Console.WriteLine("\n" + valorA + " + " + valorB + " = " + adicao);
                        break;

                    case 2:
                        subtracao = (valorA - valorB);
                        Console.WriteLine(+valorA + " - " + valorB + " = " + subtracao);
                        ;
                        break;

                    case 3:
                        multiplicacao = (valorA * valorB);
                        Console.WriteLine(+valorA + " * " + valorB + " = " + multiplicacao);
                        break;

                    case 4:
                        divisao = (valorA / valorB);
                        Console.WriteLine(+valorA + " / " + valorB + " = " + divisao);
                        break;
                    }
            } while (menu < 5);
        }
    }
}
