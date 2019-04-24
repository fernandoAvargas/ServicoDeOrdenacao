
using System;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Domain.IServiceOrderTest;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Domain.ListOrderer;

namespace ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Domain
{
    public class ShowResultOrderByTitle : IServiceOrderShowTest
    {
        public void ShowMeOrderByTests(dynamic titleAsc, int idOrder)
        {
            int asc = Convert.ToInt32(ListOrderes.Asc);
            int desc = Convert.ToInt32(ListOrderes.Desc);

            Console.WriteLine("");

            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            if(idOrder == asc)

            Console.WriteLine("||||    TITULO ASCENDENTE     ||||");

            if (idOrder == desc)

                Console.WriteLine("||||   TITULO DESCENDENTE    ||||");

            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            foreach (var y in titleAsc)
            {
                Console.WriteLine(y.idBook.ToString());
                Console.WriteLine(y.title);
                Console.WriteLine(y.authorName);
                Console.WriteLine(y.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }
        }
    }
}
