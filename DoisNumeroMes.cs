using System;
using System.Collections.Generic;

namespace ExerciciosDois
{
    public class NumeroMes 
    {
        public static void Mes()
        {
            Dictionary<string, string> mes2 = new Dictionary<string, string>();

            mes2.Add("4", "4 = ABRIL!");
            mes2.Add("1", "1 = JANEIRO!");
            mes2.Add("8", "8 = AGOSTO!");
            mes2.Add("2", "2 = FEVEREIRO!");
            mes2.Add("3", "3 = MARÇO!");
            mes2.Add("11", "11 = NOVEMBRO!");
            mes2.Add("6", "6 = JUNHO!");
            mes2.Add("7", "7 = JULHO!");
            mes2.Add("5", "5 = MAIO!");
            mes2.Add("10", "10 = OUTUBRO!");
            mes2.Add("9", "9 = SETEMBRO!");
            mes2.Add("12", "12 = DEZEMBRO!");

            Console.WriteLine("Digite o Número do Mês: ");
            try{
                Console.WriteLine(mes2[Console.ReadLine()]);
            } catch {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
