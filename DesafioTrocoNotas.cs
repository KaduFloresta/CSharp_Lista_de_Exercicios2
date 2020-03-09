using System;

namespace ExerciciosDois
{
    public class Desafio 
    {
        public static void Troco()
        {
        Console.WriteLine("Informe o Valor: ");
        int valorD = Int32.Parse(Console.ReadLine());

        int notaD = 0;
        int valorND = 0;
        int qtdeND = 0;
        String msg = "";

        while (valorD != 0) 
        {
            if (notaD == 0)
                {
                    valorND = 100;
                } 
            else if (notaD == 1) 
                {
                    valorND = 50;
                } 
            else if (notaD == 2)
                {
                    valorND = 10;
                } 
            else if (notaD == 3)
                {
                    valorND = 5;
                } 
            else
                {
                    valorND = 1;
                }
            qtdeND = valorD / valorND;

            if (qtdeND != 0) 
            {
                if (msg.Length > 0)
                    {
                        msg += " e ";
                    }
                msg += qtdeND + " notas(s) de R$ " + valorND;
                valorD = valorD % valorND;
            }
            notaD++;
        }
        Console.WriteLine(msg);
        }
    }
}