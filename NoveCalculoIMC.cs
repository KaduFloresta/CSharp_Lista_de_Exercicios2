using System;

namespace ExerciciosDois
{
    public class CalculoIMC 
    {
        public static void CalculoDoIMC()
        {      
        /*
         *        IMC        |  Classificação
         *  ---------------- | ----------------
         * Abaixo de 18,5    | Abaixo do peso9 
         * Entre 18,6 e 24,9 | peso9 Ideal
         * Entre 25,0 e 29,9 | Levemente acima do peso9
         * Entre 30,0 e 34,9 | Obesidade Grau I
         * Entre 35,0 e 39,9 | Obesidade Grau II
         * Acima de 40       | Obesidade Grau III (mórbida)
        */

        float peso9, altura9, imc9;

        Console.WriteLine("\nDigite o peso (Kg): ");
        peso9 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a Altura (Mt) ");
        altura9 = float.Parse(Console.ReadLine());

        imc9 = (peso9) / (altura9 * altura9);
        Console.WriteLine("SEU IMC É: " + imc9 + " %");

            if (imc9 < 16.99) 
            {
                Console.WriteLine("====================");
                Console.WriteLine("MUITO ABAIXO DO PESO");
                Console.WriteLine("====================");

            } 
            else if ((imc9 >= 17) && (imc9 <= 18.60)) 
            {
                Console.WriteLine("==============");
                Console.WriteLine("ABAIXO DO PESO");
                Console.WriteLine("==============");
            } 
            else if ((imc9 >= 18.61) && (imc9 <= 24.99)) 
            {
                Console.WriteLine("==========");
                Console.WriteLine("PESO IDEAL");
                Console.WriteLine("==========");
            } 
            else if ((imc9 >= 25) && (imc9 <= 29.99)) 
            {
                Console.WriteLine("=============");
                Console.WriteLine("ACIMA DO PESO");
                Console.WriteLine("=============");
            } 
            else if ((imc9 >= 30) && (imc9 <= 34.99)) 
            {
                Console.WriteLine("================");
                Console.WriteLine("OBESIDADE GRAU I");
                Console.WriteLine("================");
            } 
            else if ((imc9 >= 35) && (imc9 <= 39.99)) 
            {
                Console.WriteLine("==========================");
                Console.WriteLine("OBESIDADE MODERADA GRAU II");
                Console.WriteLine("==========================");
            } 
            else if (imc9 >= 40) 
            {
                Console.WriteLine("==========================");
                Console.WriteLine("OBESIDADE MÓRBIDA GRAU III");
                Console.WriteLine("==========================");
            }
        }
    }
}
