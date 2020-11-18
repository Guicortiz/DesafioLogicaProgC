using System;

namespace DesafioLogicaProg
{
    class Desafio5
    {
        public void Main(string[] args)
        {
            int senha;
            bool acess=false;

            Console.WriteLine("Ola, bem vindo ao sistema de login!");

            while (acess != true)
            {
                Console.WriteLine("Digite a sua senha!");
                senha = Int32.Parse(Console.ReadLine());
                if (Verificasenha(senha))
                {
                    Console.WriteLine("Acesso permitido");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Senha invalida");
                    Console.WriteLine();
                }
                acess = Verificasenha(senha);
            }
            
            static bool Verificasenha(int senha)
            {
                if (senha == 2002) return true;
                else return false;
            }
        }
    }
}