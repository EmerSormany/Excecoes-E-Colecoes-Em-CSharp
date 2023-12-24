using System;

namespace Excecoes_E_Colecoes_Em_CSharp.models
{
    public class ExemplosFila
    {
        public void Fila(){
            Console.WriteLine("Início do exemplo de Fila.");
            Queue<int> fila = new Queue<int>(); // Declaração de uma Fila
            fila.Enqueue(1); // Inclusão de um elemento na fila

            // Preenchendo a fila com for
            for (int i = 1; i <= 4; i++)
            {
                fila.Enqueue(2+i); // Adicionando elementos 1 a 1
                Console.WriteLine($"Adicionando o elemento {2+i}");
            }

            // Lendo a fila com foreach
            foreach (var item in fila)
            {
                Console.WriteLine($"Percorrendo a Fila no elemento {item}");
            }

            // Removendo os primeiros elementos, restará apenas o último
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Removido o elemento {fila.Dequeue()}"); // Removendo elementos da fila
            }

            // Lendo a fila, apenas o elemento 6 permeneceu
            foreach (var item in fila)
            {
                Console.WriteLine($"Restou o elemento {item} na fila");
            }
        }
    }
}
