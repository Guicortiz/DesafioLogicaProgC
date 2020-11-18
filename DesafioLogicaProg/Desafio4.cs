using System;

namespace DesafioLogicaProg
{
    class Desafio4
    {
        public void Main(string[] args)
        {
            double a, b, c;

            double[] raizes = new double[2];

            Console.WriteLine("Ola, bem vindo ao sistema de calculo da equecao de bhaskara!");

            Console.WriteLine("Digite o primeiro coficiente da equecao de segundo grau. A =");
            a = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Impossivel calcular");
                Environment.Exit(0);
            }

            Console.WriteLine("Digite o segundo coficiente da equecao de segundo grau. B =");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro coficiente da equecao de segundo grau. C =");
            c = Convert.ToDouble(Console.ReadLine());
            
            bhaskara(a, b, delta(a, b, c), raizes);

            Console.WriteLine("\n");
            Console.WriteLine("X1 = {0}", raizes[0]);
            Console.WriteLine("X2 = {0}", raizes[1]);
                      
            static double delta(double a, double b, double c)
            {
                double delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("Impossivel calcular");
                    Environment.Exit(0);
                }
                return delta;
            }

            static void bhaskara(double a, double b, double d, double[] raizes)
            {
                raizes[0] = ((-b) + Math.Sqrt(d)) / (2 * a);
                raizes[1] = ((-b) - Math.Sqrt(d)) / (2 * a);
            }

        }
    }
}