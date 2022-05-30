using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        
        private int andarAtual { get; set; } 
        private int totalAndares { get; set; } 
        private int capacidadeElevador { get; set; } 
        private int qtdPessoas { get; set; } 

        public Elevador() 
        {
            andarAtual = 0; // inicia no térreo 
            qtdPessoas = 0; //começa sem pessoas  
        }

        public void Inicio() 
        {
            
            Console.WriteLine("Capacidade do elevador: 6 pessoas");
            
            Console.WriteLine("Total de andares : 10 andares");
           
        }

        public void Entrar() 
        {
            if (qtdPessoas < capacidadeElevador)
            {
                qtdPessoas++;
                Console.WriteLine("Andar: {0}, Lotação: {1} passageiro(s)", andarAtual, qtdPessoas);
            }
            else
            {
                Console.WriteLine("ERRO: Lotado! Por favor aguarde.");
            }
        }

        public void Sair() 
        {
            if (qtdPessoas > 0)
            {
                qtdPessoas--;
                Console.WriteLine("Andar: {0}, Lotação: {1} passageiro(s)", andarAtual, qtdPessoas);
            }
            else
            {
                Console.WriteLine("ERRO: Elevador vazio!");
            }
        }

        public void Subir() 
        {
            if (andarAtual < totalAndares)
            {
                andarAtual++;
                Console.WriteLine("Andar: {0}, Lotação: {1} passageiro(s)", andarAtual, qtdPessoas);
            }
            else
            {
                Console.WriteLine("ERRO: Elevador no último andar!");
            }
        }

        public void Descer() 
        {
            if (andarAtual > 0)
            {
                andarAtual--;
                Console.WriteLine("Andar: {0}, Lotação: {1} passageiro(s)", andarAtual, qtdPessoas);
            }
            else
            {
                Console.WriteLine("ERRO: Elevador no térreo!");
            }
        }

    }
}












