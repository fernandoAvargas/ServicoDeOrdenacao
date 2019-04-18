using System;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test.IServiceOrderTest;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Infra.ListOrderer;

namespace ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test
{
    public class ShowResultOrderByBook : IServiceOrderShowTest
    {
        public void ShowMeOrderByTests(dynamic bookIdAsc , int idOrder)
        {
            int asc = Convert.ToInt32(ListOrderes.Asc);
            int desc = Convert.ToInt32(ListOrderes.Desc);

            Console.WriteLine("");

            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            if (idOrder == asc) 
                Console.WriteLine("||||   LIVRO ID ASCENDENTE    ||||");
         
            if(idOrder == desc)
                Console.WriteLine("||||   LIVRO ID DESCENDENTE   ||||");

            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            foreach (var x in bookIdAsc)
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
