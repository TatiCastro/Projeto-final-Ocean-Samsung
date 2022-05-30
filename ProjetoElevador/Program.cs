using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string acaoEscolhida; 
            bool continuar = true; 

            Elevador elevador = new Elevador(); 

            elevador.Inicio(); 

            do
            {
                Console.WriteLine(" Escolha uma opção: ");
                Console.WriteLine(" 1 - Entrar ");
                Console.WriteLine(" 2 - Subir ");
                Console.WriteLine(" 3 - Descer ");
                Console.WriteLine(" 4 - Sair ");
                Console.WriteLine(" 5 - Sair App ");
    

                acaoEscolhida = Console.ReadLine();
                Console.Clear();

                switch (acaoEscolhida) 
                {
                    case "1": Console.WriteLine("Entrar"); elevador.Entrar(); 
                        break;
                    case "2": Console.WriteLine("Subindo"); elevador.Subir(); 
                        break;
                    case "3": Console.WriteLine("Descendo"); elevador.Descer(); 
                        break;
                    case "4": Console.WriteLine("Sair"); elevador.Sair();
                        break;
                    case "5": Console.WriteLine("Sair App"); continuar = false; 
                        break;
                    default: Console.WriteLine("ERRO: opção inválida."); 
                        break;
                }
                Console.WriteLine("");
            }

            while (continuar);


        }

    }
}




