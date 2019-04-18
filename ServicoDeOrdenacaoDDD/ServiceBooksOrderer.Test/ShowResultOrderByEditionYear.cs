
using System;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test.IServiceOrderTest;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Infra.ListOrderer;

namespace ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test
{
    public class ShowResultOrderByEditionYear : IServiceOrderShowTest
    {
        public void ShowMeOrderByTests(dynamic yerEditAsc, int idOrder)
        {

            int asc = Convert.ToInt32(ListOrderes.Asc);
            int desc = Convert.ToInt32(ListOrderes.Desc);

            Console.WriteLine("");

            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            if (idOrder == asc)
                Console.WriteLine("||||     EDIÇÃO ASCENDENTE    ||||");

            if (idOrder == desc)
                Console.WriteLine("||||    EDIÇÃO DESCENDENTE    ||||");

            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            foreach (var w in yerEditAsc)
            {

                Console.WriteLine(w.idBook.ToString());
                Console.WriteLine(w.title);
                Console.WriteLine(w.authorName);
                Console.WriteLine(w.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }
        }
    }
}
