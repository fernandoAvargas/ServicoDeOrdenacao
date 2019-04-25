using System;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Domain.ListOrderer;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Domain.IServiceOrderTest;

namespace ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test
{
    class ShowResultOrderByIdAndAuthor : IServiceOrderShowTest
    {
        public void ShowMeOrderByTests(dynamic result, int order)
        {
            int asc = Convert.ToInt32(ListOrderes.Asc);
            int desc = Convert.ToInt32(ListOrderes.Desc);

            Console.WriteLine("");

            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            if (order == asc)
                Console.WriteLine("||||   LIVRO ID AND AUTOR ASCENDENTE    ||||");

            if (order == desc)
                Console.WriteLine("||||   LIVRO ID DESCENDENTE   ||||");

            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            foreach (var x in result)
            {

                Console.WriteLine(x.idBook.ToString());
                Console.WriteLine(x.title);
                Console.WriteLine(x.authorName);
                Console.WriteLine(x.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }
        }
    }
}
