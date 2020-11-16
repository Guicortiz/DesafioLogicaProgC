using System;

namespace DesafioLogicaProg
{
    class Desafio1
    {
        public void Main(string[] args)
        {

            int codigo1, codigo2, qtde1, qtde2;
            double valor1, valor2;

            Console.WriteLine("Ola, bem vindo ao sistema de vendas!");

            Console.WriteLine("Digite o codigo do produto 1!");
            codigo1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto 1!");
            qtde1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor em R$ do produto 1!");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o codigo do produto 2!");
            codigo2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto 2!");
            qtde2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor em R$ do produto 2!");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("O valor da compra é de: R$ {0}",resultadocompra(qtde1, qtde2, valor1, valor2));

            static double resultadocompra(int qt1,int qt2, double v1, double v2)
            {
                double somacompra = (qt1 * v1) + (qt2 * v2);
                return somacompra;
            }
            
        }
    }
}