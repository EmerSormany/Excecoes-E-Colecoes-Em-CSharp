using System;

namespace Excecoes_E_Colecoes_Em_CSharp.models
{
    public class ExemplosPilha
    {
        public void Pilha(){
            Console.WriteLine("Início do exemplo de Pilha.");
            // Implementando uma Pilha
            Stack<int> pilha = new Stack<int>(); // declaração de Pilha

            pilha.Push(2); // Adicionando primeiro elemento na pilha

            // Preenchendo a pilha
            for (int i = 1; i <= 4; i++)
            {
                pilha.Push(2+i); // Adicionando elementos 1 a 1
                Console.WriteLine($"Adicionando o elemento {2+i}");
            }

            // Lendo os elementos da pilha
            foreach (var item in pilha)
            {
                Console.WriteLine($"Percorrendo a Pilha no elemento {item}");
            }

            // Removendo os elementos da pilha
            for (int i = 1; i <= 4; i++)
            {   // Removendo 1 a 1 do mais recente para o mais antigo
                Console.WriteLine($"Removendo o {pilha.Pop()}"); 
            }

            // Lendo a pilha novamente, resta apenas o primeiro elemento adicionado à pilha, número 2
            foreach (var item in pilha)
            {
                Console.WriteLine($"Restou o elemento {item} na pilha");
            }
        }
    }
}
