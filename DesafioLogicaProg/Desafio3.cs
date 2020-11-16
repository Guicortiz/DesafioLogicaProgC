using System;

namespace DesafioLogicaProg
{
    class Desafio3
    {
        static void Main(string[] args)
        {
            int codigo, qtde;

            Console.WriteLine("Ola, bem vindo ao sistema de calculo de compra do lanche!");

            Console.WriteLine("Digite o codigo!");
            codigo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade!");
            qtde = Int32.Parse(Console.ReadLine());



            Console.WriteLine("\n");
            Console.WriteLine("O valor do pedido do lanche é de: R$ {0}", resutadopedido(codigo,qtde));

            static double resutadopedido(int codigo, int qtde)
            {
                double resultado;
                switch (codigo)
                {
                    case 1:
                        return (qtde * 4.00);
                    case 2:
                        return (qtde * 4.50);
                    case 3:
                        return (qtde * 5.00);
                    case 4:
                        return (qtde * 2.00);
                    case 5:
                        return (qtde * 1.50);
                }
            }
        }
    }
}