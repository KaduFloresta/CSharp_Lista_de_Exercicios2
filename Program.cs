using System;

namespace ListaExercicios2
{
    class Program
    {
        static void Main(string[] args)
        {

        int menu = 0;  

            do 
            {
            Console.WriteLine("|-------------MENU---------------|"); 
            Console.WriteLine("| 1 >>> Média 3 Alunos           |");
            Console.WriteLine("| 2 >>> Digito Mês               |");
            Console.WriteLine("| 3 >>> Jogo da Forca - Palavra  |");
            Console.WriteLine("| 4 >>> Tabuada - Select         |");
            Console.WriteLine("| 5 >>> String - Letra/Letra     |");
            Console.WriteLine("| 6 >>> Soma dos Setes           |");
            Console.WriteLine("| 7 >>> Média Alunos Negativo    |");
            Console.WriteLine("| 8 >>> Fatorial do Número       |");
            Console.WriteLine("| 9 >>> Cáculo do IMC            |");
            Console.WriteLine("| 10 >>> Operações Matemáticas   |");
            Console.WriteLine("| 11 >>> DESAFIO do Troco        |");
            Console.WriteLine("| 12 >>> Sair                    |");
            Console.WriteLine("|--------------------------------|");

            Console.WriteLine("\nInforme o Nº do Exercício: ");

            

			
			menu = Int32.Parse(Console.ReadLine());
			
                switch (menu) {
                case 1:
                    Console.WriteLine("Média de 3 Alunos");
                    ExerciciosDois.MediaAlunos.Media();
                    break;
                case 2:
                    Console.WriteLine("Mês");
                    ExerciciosDois.NumeroMes.Mes();
                    break;
                case 3:
                    Console.WriteLine("Forca");
                    ExerciciosDois.ForcaPalavra.Forca();                
                    break;
                case 4:
                    Console.WriteLine("Tabuada");
                    ExerciciosDois.TabuadaSelect.Tabuada();
                    break;
                case 5:
                    Console.WriteLine("String");
                    ExerciciosDois.StPalavra.StPalavraLetra();                    
                    break;
                case 6:
                    Console.WriteLine("Soma dos 7");
                    ExerciciosDois.SomaSete.SomaDosSete();                    
                    break;
                case 7:
                    Console.WriteLine("Soma dos 7");
                    ExerciciosDois.MediaAlunosNegativo.MediaNegativo();                    
                    break;
                case 8:
                    Console.WriteLine("Fatorial");
                    ExerciciosDois.FatorialNumero.Fatorial();                    
                    break;

                case 9:
                    Console.WriteLine("Cáculo do IMC");
                    ExerciciosDois.CalculoIMC.CalculoDoIMC();                    
                    break;
                case 10:
                    Console.WriteLine("Operações Matemáticas");
                    ExerciciosDois.OperacoesMatematicas.Operacoes();                    
                    break;
                case 11:
                    Console.WriteLine("Desafio Do Troco");
                    ExerciciosDois.Desafio.Troco();                    
                    break;
                } 
            
            } 
            while (menu <= 11);                   
        }
    }
}