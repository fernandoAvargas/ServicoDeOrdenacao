using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test.IServiceOrderTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test
{
    public class ShowResultOrderByNull : IServiceOrderShowTest
    {
        public void ShowMeOrderByTests(dynamic result, int order = 0)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Fim dos testes antes da exceção. Favor conferir as saídas...Aperte qualquer tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||       CONJUNTO NULO       ||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
        }
    }
}
