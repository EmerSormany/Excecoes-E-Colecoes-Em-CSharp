using System;

namespace Excecoes_E_Colecoes_Em_CSharp.models
{
    public class ExemplosDictionary
    {
        public void Dictionary(){
            // Implementando Dictionary

                    //Tipo Key  //Elemento key
            Dictionary<string , string> estados = new Dictionary<string, string>();// Decalaração de uma coleção Dictionary
        

                       //key   //elemento
            estados.Add("RN", "Rio Grande do Norte"); // Adicionando elemento
            estados.Add("PB", "Paraíba"); // Adicionando elemento
            estados.Add("PE", "Pernanmbuco"); // Adicionando elemento
            estados.Add("CE", "Ceará"); // Adicionando elemento


            // Lendo a coleção 
            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key} - Elemento: {item.Value}");
            }

            estados.Remove("CE"); // Removendo item da coleção acessando a chave
            estados["RN"] = "Capital: Natal"; // Acessando e alterando o elemento pela Chave

            // Lendo novamente a coleção com os dados alterados
            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key} - Elemento: {item.Value}");
            }

            if (estados.ContainsKey("RN")) // Buscando dentro da coleção se a chave já existe
            {
                Console.WriteLine("Chave RN já existe.");
            }
        }
    }
}
