using System;

namespace DesafioLogicaProg
{
    class Desafio2
    {
        static void Main(string[] args)
        {
            double raio;

            Console.WriteLine("Ola, bem vindo ao sistema de calculo de area do circulo!");

            Console.WriteLine("Digite o raio do circulo!");
            raio = Convert.ToDouble(Console.ReadLine());
            
            

            Console.WriteLine("\n");
            Console.WriteLine("O valor da area do circulo é de: {0}", Math.Round(resultadoarea(raio), 4));

            static double resultadoarea(double r)
            {
                double pi = 3.14159;
                return (pi*(Math.Pow(r,2)));
            }
            
        }
    }
}