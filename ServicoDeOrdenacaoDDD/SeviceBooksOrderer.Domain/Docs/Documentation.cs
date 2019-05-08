using MarkdownLog;
using System;

namespace ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Domain.Docs
{
    public static class Documentation
    {

        public static void DocSystem()
        {

            Console.WriteLine("SISTEMA: SERVIÇO DE ORDENAÇÃO DE LIVROS".ToMarkdownHeader());
            Console.Write("");
            Console.WriteLine("CASE: ORDERNAR UMA COLEÇÃO DE LIVROS CONFORME REQUISITOS E CENÁRIOS DE TESTES".ToMarkdownSubHeader());
            Console.Write("");
            Console.WriteLine("Versão: 1.1".ToMarkdownParagraph());
            Console.Write("");
            Console.WriteLine("Solicitantes: Fictícios S/A".ToMarkdownParagraph());
            Console.WriteLine("Desenvolvedor: Fernando de Assis Vargas".ToMarkdownParagraph());
            Console.WriteLine("Data: 18/04/2019".ToMarkdownParagraph());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Descrição do serviço: ".ToMarkdownParagraph());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Ordernação conforme solicitação do cliente do serviço".ToMarkdownParagraph());
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.Write("");
            Console.WriteLine("Sistema desenvolvido conforme requisitos - aguardando validação".ToMarkdownBlockquote());
            Console.Write("");
            Console.Write("");
            Console.WriteLine("Favor pressionar qualquer tecla para continuar".ToMarkdownParagraph());
            Console.Write("");
            Console.Write("");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
