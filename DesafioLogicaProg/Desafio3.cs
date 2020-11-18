using System;

namespace DesafioLogicaProg
{
    class Desafio3
    {
        public void Main(string[] args)
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
                double resultado= 0;
                switch (codigo)
                {
                    case 1:
                        resultado = (qtde * 4.00);
                        break;
                    case 2:
                        resultado = (qtde * 4.50);
                        break;
                    case 3:
                        resultado = (qtde * 5.00);
                        break;
                    case 4:
                        resultado = (qtde * 2.00);
                        break;
                    case 5:
                        resultado = (qtde * 1.50);
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }

                return resultado;
            }
        }
    }
}