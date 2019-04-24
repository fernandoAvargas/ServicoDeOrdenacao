using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Domain.ListOrderer;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Domain.IServiceOrderTest;
using System;

namespace ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Domain
{
    public class ShowResultOrderByIdAndTitle : IServiceOrderShowTest
    {
        public void ShowMeOrderByTests(dynamic IdBookAndTitle, int idOrder)
        {
            int asc = Convert.ToInt32(ListOrderes.Asc);
            int desc = Convert.ToInt32(ListOrderes.Desc);

            Console.WriteLine("");

            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||");

            if (idOrder == asc)
                Console.WriteLine("||||  LIVRO ID E TÍTULO ASCENDENTE  ||||");

            if (idOrder == desc)
                Console.WriteLine("||||   LIVRO ID E TÍTULO DESCENDENTE   ||||");

            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||");

            foreach (var x in IdBookAndTitle)
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
