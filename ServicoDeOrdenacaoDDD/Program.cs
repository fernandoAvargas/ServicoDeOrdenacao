using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Infra.ListOrderer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceBooksOrdererDDD
{
    class Program
    {
        static List<BookModel> ListBooks;  

        static void Main(string[] args)
        {
            SeviceBooksOrderer.Service.SeviceBooksOrderer service = new SeviceBooksOrderer.Service.SeviceBooksOrderer();

            ListBooks = new List<BookModel>();         

          
            ListBooks.Add(new BookModel(1, "Java How to Program", "Deitel & Deitel", 2007, true));  
            ListBooks.Add(new BookModel(2, "Patterns of Enterprise Application Architecture", "Martin Fowler", 2002, true));
            ListBooks.Add(new BookModel(3, "Head First Design Patterns", "Elisabeth Freeman", 2004, true));
            ListBooks.Add(new BookModel(4, "Internet & World Wide Web: How to Program", "Deitel & Deitel", 2007, true));


            int asc = Convert.ToInt32(ListOrderes.Asc);
            int desc = Convert.ToInt32(ListOrderes.Desc);
            int nop = Convert.ToInt32(ListOrderes.Nop);

            //Teste Ascendente -------------------------------------------------

            //Livro id ascendente
            var bookIdAsc = service.BooksOrderer(ListBooks,asc);

            //Titulo ascendente
            var titleAsc = service.BooksOrderer(ListBooks,nop,asc);

            //Autor ascendente
            var autAsc = service.BooksOrderer(ListBooks, nop,nop,asc);

            //Ano edição ascendente
            var yerEditAsc = service.BooksOrderer(ListBooks, nop,nop,nop ,asc);

            //Teste descendente -----------------------------------------------

            //Livro id descendente
            var bookIdDesc = service.BooksOrderer(ListBooks, desc);

            //Titulo descendente
            var titleDesc = service.BooksOrderer(ListBooks, nop, desc);

            //Autor descendente
            var autDesc = service.BooksOrderer(ListBooks, nop, nop, desc);

            //Ano edição descendente
            var yerEditDesc = service.BooksOrderer(ListBooks, nop, nop, nop, desc);

            //Testes de Conjuntos -----------------------------------------

            //Conjunto vazio

            ListBooks.Clear();

            var retBooksNot = service.BooksOrderer(ListBooks);

            //Nulo

            ListBooks = null;

            var retBooksNull = service.BooksOrderer(ListBooks);

        }
    }
}
