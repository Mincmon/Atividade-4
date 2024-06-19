using System;

namespace Atividade_4
{
    class Projeto
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Informe um numero");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int mult = numero * i;
                Console.WriteLine(mult);
            }

            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());
            int result = 0;
            while (result <= numero)
            {
                Console.WriteLine(result);
                result += 3;
            };*/

            int quant = 1;

            while (quant <= 5) {
                Console.WriteLine("Digite um número");
                int num = int.Parse(Console.ReadLine());
                if (num >= 100) {
                Console.WriteLine("Número especial");
                } else {
                    Console.WriteLine("Número comum");
                }
                Console.WriteLine("");
                quant++;
             }

            /*Console.WriteLine("Deseja continuar?");
            char resposta = char.Parse(Console.ReadLine());
            while (resposta == 's')
            {
                Console.WriteLine("Deseja continuar?");
                resposta = char.Parse(Console.ReadLine());
            }*/

        }
    }
}
