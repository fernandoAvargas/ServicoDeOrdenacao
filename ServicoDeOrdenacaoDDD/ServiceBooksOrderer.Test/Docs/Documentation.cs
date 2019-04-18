using MarkdownLog;
using System;

namespace ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test.Docs
{
    public static class Documentation
    {

        public static void DocSystem()
        {

            Console.WriteLine("SISTEMA: SERVIÇO DE ORDENAÇÃO DE LIVROS".ToMarkdownHeader());
            Console.Write("");       
            Console.WriteLine("CASE: ORDERNAR UMA COLEÇÃO DE LIVROS CONFORME REQUISITOS E CENÁRIOS DE TESTES".ToMarkdownSubHeader());
            Console.Write("");
            Console.WriteLine("Solicitantes: MNG / FGV".ToMarkdownParagraph());
            Console.WriteLine("Desenvolvedor: Fernando de Assis Vargas".ToMarkdownParagraph());
            Console.WriteLine("Data: 18/04/2019".ToMarkdownParagraph());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Descrição do sistemas: ".ToMarkdownParagraph());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Ordernação conforme solicitação do cliente do serviço".ToMarkdownParagraph());
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Cenários de testes: ".ToMarkdownParagraph());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("1 - Ordernação ascendente pelo número dos livros".ToMarkdownParagraph());
            Console.WriteLine("2 - Ordernação descendente pelo número dos livros".ToMarkdownParagraph());
            Console.WriteLine("3 - Ordernação ascendente pelo título dos livros".ToMarkdownParagraph());
            Console.WriteLine("4 - Ordernação descendente pelo título dos livros".ToMarkdownParagraph());
            Console.WriteLine("5 - Ordernação ascendente pelo autor dos livros".ToMarkdownParagraph());
            Console.WriteLine("6 - Ordernação descendente pelo autor dos livros".ToMarkdownParagraph());
            Console.WriteLine("7 - Ordernação ascendente pelo ano de edição dos livros".ToMarkdownParagraph());
            Console.WriteLine("8 - Ordernação descendente pelo  ano de edição livros".ToMarkdownParagraph());
            Console.WriteLine("9 - Ordernação ascendente pelo número dos livros".ToMarkdownParagraph());
            Console.WriteLine("10 - Retonar um conjunto vazio".ToMarkdownParagraph());
            Console.WriteLine("11 - Apresentar erro de excessão referente à ordenação de um conjunto nullo".ToMarkdownParagraph());
            Console.Write("");
            Console.Write("");
            Console.WriteLine("Sistema desenvolvido conforme requisitos - aguardando validação".ToMarkdownBlockquote());
          
            Console.ReadKey();
            Console.Clear();

        }


    }
}
