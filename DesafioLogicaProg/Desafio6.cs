using System;

namespace DesafioLogicaProg
{
    class Desafio6
    {
        static void Main(string[] args)
        {
            int entradas;
            int intervaloinicial = 10, intervalofinal = 20;
            int dentro=0,fora=0;

            Console.WriteLine("Ola, bem vindo ao sistema de verificacao de intervalo!");

            Console.WriteLine("Digite quantos numeros quer verificar no intervalo!");
            entradas = Int32.Parse(Console.ReadLine());

            int[] numeros = new int[entradas];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite o numero!");
                numeros[i] = Int32.Parse(Console.ReadLine());
                if(numeros[i] >= intervaloinicial && numeros[i] <= intervalofinal)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine("{0} IN!",dentro);
            Console.WriteLine("{0} OUT!",fora);
        }
    }
}