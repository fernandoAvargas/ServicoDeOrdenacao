﻿
using System;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test.IServiceOrderTest;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Infra.ListOrderer;

namespace ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test
{
    public class ShowResultOrderByAuthor : IServiceOrderShowTest
    {
        public void ShowMeOrderByTests(dynamic autAsc, int idOrder)
        {
            int asc = Convert.ToInt32(ListOrderes.Asc);
            int desc = Convert.ToInt32(ListOrderes.Desc);

            Console.WriteLine("");

            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            if (idOrder == asc)
                Console.WriteLine("||||      AUTOR ASCENDENTE    ||||");

            if (idOrder == desc)
                Console.WriteLine("||||     AUTOR DESCENDENTE    ||||");

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
