using System;

namespace ExerciciosDois
{
    public class ForcaPalavra 
    {
        public static void Forca()
        {
        Console.WriteLine("\n::: Jogo da Forca :::\nConfigurando...\n\nDigite a Palavra-Chave:");
        String palavraOculta = Console.ReadLine();
        
        int tentativas = 6;

        for (int contador = 0; contador < tentativas; contador++) {
            Console.WriteLine("Digite a Palavra: ");
            String resposta = Console.ReadLine();

            if (palavraOculta.Equals(resposta)) {
                Console.WriteLine("Você Ganhou!!!");
                Console.WriteLine("Acertou na Tentativa: " + contador + 1);
                break;
            } else {
                Console.WriteLine("Você Errou! Tem Ainda " + (tentativas - (contador + 1)));

                switch (contador) {
                case 0:
                    Console.WriteLine(" ____");
                    Console.WriteLine("|    :");
                    Console.WriteLine("|    :");
                    Console.WriteLine("|    O ");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    break;
                case 1:
                    Console.WriteLine(" ____");
                    Console.WriteLine("|    :");
                    Console.WriteLine("|    :");
                    Console.WriteLine("|    O ");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    break;
                case 2:
                    Console.WriteLine(" ____");
                    Console.WriteLine("|    :");
                    Console.WriteLine("|    :");
                    Console.WriteLine("|    O ");
                    Console.WriteLine("|  --|");
                    Console.WriteLine("|    | ");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    break;
                case 3:
                    Console.WriteLine(" ____");
                    Console.WriteLine("|    :");
                    Console.WriteLine("|    :");
                    Console.WriteLine("|    O ");
                    Console.WriteLine("|  --|--");
                    Console.WriteLine("|    | ");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    break;
                case 4:
                    Console.WriteLine(" ____");
                    Console.WriteLine("|    :");
                    Console.WriteLine("|    :");
                    Console.WriteLine("|    O ");
                    Console.WriteLine("|  --|--");
                    Console.WriteLine("|    | ");
                    Console.WriteLine("|   |");
                    Console.WriteLine("|");
                    break;
                case 5:
                    Console.WriteLine(" ____");
                    Console.WriteLine("|    :");
                    Console.WriteLine("|    :");
                    Console.WriteLine("|    O ");
                    Console.WriteLine("|  --|--");
                    Console.WriteLine("|    | ");
                    Console.WriteLine("|   | |");
                    Console.WriteLine("|");
                    break;
                }

                if (contador + 1 == tentativas) {
                    Console.WriteLine("\n==================================");
                    Console.WriteLine("       VOCÊ ERROU!!! " + contador + " VEZES");
                    Console.WriteLine("==================================");
                    Console.WriteLine("VOCÊ PERDEU! FIM DO JOGO, LOSER!!!");
                    Console.WriteLine("==================================");
                }
            }

    }
        }
    }
}
