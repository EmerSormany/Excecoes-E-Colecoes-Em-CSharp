using System;

namespace Excecoes_E_Colecoes_Em_CSharp.models
{
    public class ExemplosExcecoes
    {
        //  Exemplos de tratamento de exceções
        public void PrimeiroArquivo(){ // Primeiro Método
            Console.WriteLine("Início dos exemplos de exceções.");
            try
            {   // Código com possibilidade de gerar exceção // Irá cair na exceção arquivo não encontrado
                string[] primeiroArquivo = File.ReadAllLines("Arquivos/arquivo_Leitura.txt"); 
            }
            catch (FileNotFoundException x) // Exceção Específica de Arquivo não Encontrado
            { 
                Console.WriteLine("Arquivo de leitura não encontrado."); // Mensagem personalizada
                Console.WriteLine(x.Message); // Mensagem do erro
            }
            SegundoArquivo(); // Chama o segundo método
        }
        public void SegundoArquivo(){ // Segundo Método
            try
            {   // Código com possibilidade de gerar exceção 
                // Pasta não existe, vai cair na exceção de diretório não encontrado
                string[] segundoArquivo2 = File.ReadAllLines("Arquivos/p/arquivoLeitura.txt");
            }
            catch (DirectoryNotFoundException x) // Exceção Específica de dDiretório não Encontrado
            { 
                Console.WriteLine("Pasta não localizada."); // Mensagem personalizada
                Console.WriteLine(x.Message); // Mensagem do erro
            }
            TerceiroArquivo(); // Chama o terceiro método
        }
        public void TerceiroArquivo(){ // Terceiro Método
            try
            {   // Código com possibilidade de gerar exceção 
                // Vai entrar como acesso negado, usei como exemplo para erro geral, mas poderia ficar
                // como UnauthorizedAccessException
                string[] terceiroArquivo1 = File.ReadAllLines("Arquivos");
            }
            catch (Exception x) // Genérica, Mas Poderia Ser a Específica de UnauthorizedAccessException
            { 
                Console.WriteLine("Ocorreu um erro geral."); // Mensagem personalizada
                Console.WriteLine(x.Message); // Mensagem do erro
            }
            QuartoArquivo(); // Chama o quarto método
        }
        public void QuartoArquivo(){ // Quarto Método
            try
            {
                // Código com possibilidade de gerar exceção
                // Não ocorre erro e irá exibir cada linha do arquivo lido.
                string[] quartoArquivo1 = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
                foreach (var linha in quartoArquivo1)
                {
                    Console.WriteLine(linha); // Exibe cada linha do arquivo
                }
            }
            catch (Exception) // Exceção Genérica
            {
                Console.WriteLine("Não vai acontecer erro."); // Mensagem personalizada, Caso ocoresse a exceção
            }finally
            {
                Console.WriteLine("Sempre vai entrar aqui.");
            }
    }
}
}
