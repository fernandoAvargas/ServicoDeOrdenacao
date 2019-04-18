using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Infra.ListOrderer;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test.IServiceOrderTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test
{
    class ShowResultOrderByEmpty : IServiceOrderShowTest
    {
        int asc = Convert.ToInt32(ListOrderes.Asc);
        int desc = Convert.ToInt32(ListOrderes.Desc);

        public void ShowMeOrderByTests(dynamic autAsc, int idOrder)
        {
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||       CONJUNTO VAZIO      ||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            foreach (var z in autAsc)
            {

                Console.WriteLine(z.idBook.ToString());
                Console.WriteLine(z.title);
                Console.WriteLine(z.authorName);
                Console.WriteLine(z.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }
        }
    }
}

