using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Infra.ListOrderer;
using ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Service.ServiceBooksOrderer.Design;
using System;
using System.Collections.Generic;

namespace ServiceBooksOrdererDDD
{
    class Program
    {
        static List<BookModel> ListBooks;  

        static void Main(string[] args)
        {
            Console.WriteLine("Início dos testes...Aperte qualquer tecla para continuar");
            Console.ReadKey();

            SeviceBooksOrderer.Service.SeviceBooksOrderer service = new SeviceBooksOrderer.Service.SeviceBooksOrderer();

            IBooksOrderer idBook = new ServiceOrdererById();
            IBooksOrderer title = new ServiceOrdererByTitle();
            IBooksOrderer idAutor = new ServiceOrderByAuthor();
            IBooksOrderer editionYear = new ServiceOrderByEditionYear();

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
            var bookIdAsc = service.BooksOrderer(ListBooks, idBook, asc);

            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||    LIVRO ID ASCENDENTE    ||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            foreach (var x in bookIdAsc)
            {

                Console.WriteLine(x.idBook.ToString());
                Console.WriteLine(x.title);
                Console.WriteLine(x.authorName);
                Console.WriteLine(x.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }

            Console.WriteLine("");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||    TITULO ASCENDENTE    ||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            //Titulo ascendente
            var titleAsc = service.BooksOrderer(ListBooks, title, asc);

            foreach (var y in titleAsc)
            {

                Console.WriteLine(y.idBook.ToString());
                Console.WriteLine(y.title);
                Console.WriteLine(y.authorName);
                Console.WriteLine(y.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }

            Console.WriteLine("");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||      AUTOR ASCENDENTE     ||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            //Autor ascendente
            var autAsc = service.BooksOrderer(ListBooks, idAutor, asc);

            foreach (var z in autAsc)
            {

                Console.WriteLine(z.idBook.ToString());
                Console.WriteLine(z.title);
                Console.WriteLine(z.authorName);
                Console.WriteLine(z.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }


            Console.WriteLine("");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||     EDIÇÃO ASCENDENTE     ||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            //Ano edição ascendente
            var yerEditAsc = service.BooksOrderer(ListBooks, editionYear, asc);

            foreach (var w in yerEditAsc)
            {

                Console.WriteLine(w.idBook.ToString());
                Console.WriteLine(w.title);
                Console.WriteLine(w.authorName);
                Console.WriteLine(w.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }

            //Teste descendente -----------------------------------------------

            Console.WriteLine("");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||    LIVRO ID DESCENDENTE   ||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            //Livro id descendente
            var bookIdDesc = service.BooksOrderer(ListBooks, idBook, desc);

            foreach (var x in bookIdDesc)
            {

                Console.WriteLine(x.idBook.ToString());
                Console.WriteLine(x.title);
                Console.WriteLine(x.authorName);
                Console.WriteLine(x.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }


            Console.WriteLine("");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||    TITULO   DESCENDENTE   ||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            //Titulo descendente
            var titleDesc = service.BooksOrderer(ListBooks, title, desc);

            foreach (var y in titleDesc)
            {

                Console.WriteLine(y.idBook.ToString());
                Console.WriteLine(y.title);
                Console.WriteLine(y.authorName);
                Console.WriteLine(y.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }


            Console.WriteLine("");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||    AUTOR   DESCENDENTE    ||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            //Autor descendente
            var autDesc = service.BooksOrderer(ListBooks, idAutor, desc);

            foreach (var z in autDesc)
            {

                Console.WriteLine(z.idBook.ToString());
                Console.WriteLine(z.title);
                Console.WriteLine(z.authorName);
                Console.WriteLine(z.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }


            Console.WriteLine("");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||    EDIÇÃO   DESCENDENTE   ||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            //Ano edição descendente
            var yerEditDesc = service.BooksOrderer(ListBooks, editionYear, desc);

            foreach (var w in yerEditDesc)
            {

                Console.WriteLine(w.idBook.ToString());
                Console.WriteLine(w.title);
                Console.WriteLine(w.authorName);
                Console.WriteLine(w.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }

            //Testes de Conjuntos -----------------------------------------

            //Conjunto vazio

            Console.WriteLine("");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||       CONJUNTO VAZIO      ||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            ListBooks.Clear();

            IBooksOrderer Empty = new ServiceOrdererById();

            var retBooksNot = service.BooksOrderer(ListBooks, Empty, nop);

            foreach (var u in retBooksNot)
            {

                Console.WriteLine(u.idBook.ToString());
                Console.WriteLine(u.title);
                Console.WriteLine(u.authorName);
                Console.WriteLine(u.editionYear.ToString());
                Console.WriteLine("----------------------------");

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Fim dos testes antes da exceção. Favor conferir as saídas...Aperte qualquer tecla para continuar");
            Console.ReadKey();

            //Nulo

            Console.WriteLine("");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("|||       CONJUNTO NULO       ||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");

            ListBooks = null;

             var retBooksNull = service.BooksOrderer(ListBooks,null,nop);

        }
    }
}
