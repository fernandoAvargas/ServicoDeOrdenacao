using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Infra.ListOrderer;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test.Docs;
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

            #region Docs

            Documentation.DocSystem();

            #endregion

            #region Objetos

            SeviceBooksOrderer.Service.SeviceBooksOrderer service = new SeviceBooksOrderer.Service.SeviceBooksOrderer();

            IBooksOrderer idBook = new ServiceOrdererById();
            IBooksOrderer title = new ServiceOrdererByTitle();
            IBooksOrderer idAutor = new ServiceOrderByAuthor();
            IBooksOrderer editionYear = new ServiceOrderByEditionYear();

           

            #endregion

            #region Popular  

            ListBooks = new List<BookModel>();

            

            ListBooks.Add(new BookModel(1, "Java How to Program", "Deitel & Deitel", 2007, true));
            ListBooks.Add(new BookModel(2, "Patterns of Enterprise Application Architecture", "Martin Fowler", 2002, true));
            ListBooks.Add(new BookModel(3, "Head First Design Patterns", "Elisabeth Freeman", 2004, true));
            ListBooks.Add(new BookModel(4, "Internet & World Wide Web: How to Program", "Deitel & Deitel", 2007, true));

            #endregion

            #region Ordenações

            int asc = Convert.ToInt32(ListOrderes.Asc);
            int desc = Convert.ToInt32(ListOrderes.Desc);
            int nop = Convert.ToInt32(ListOrderes.Nop);

            #endregion



            #region Testes

            //Teste Ascendente -------------------------------------------------

            //Livro id ascendente
            var bookIdAsc = service.BooksOrderer(ListBooks, idBook, asc);

            ShowResultOrderByBook byBookAsc = new ShowResultOrderByBook();
            byBookAsc.ShowMeOrderByTests(bookIdAsc, asc);

            //Titulo ascendente
            var titleAsc = service.BooksOrderer(ListBooks, title, asc);

            ShowResultOrderByTitle byTitleAsc = new ShowResultOrderByTitle();
            byTitleAsc.ShowMeOrderByTests(titleAsc, asc);

            //Autor ascendente
            var autAsc = service.BooksOrderer(ListBooks, idAutor, asc);

            ShowResultOrderByAuthor byAuthorAsc = new ShowResultOrderByAuthor();
            byAuthorAsc.ShowMeOrderByTests(autAsc, asc);

            //Ano edição ascendente
            var yerEditAsc = service.BooksOrderer(ListBooks, editionYear, asc);

            ShowResultOrderByEditionYear byEditionYearAsc = new ShowResultOrderByEditionYear();
            byEditionYearAsc.ShowMeOrderByTests(yerEditAsc, asc);

            //Teste descendente -----------------------------------------------

            //Livro id descendente
            var bookIdDesc = service.BooksOrderer(ListBooks, idBook, desc);

            ShowResultOrderByBook byBooDesc = new ShowResultOrderByBook();
            byBooDesc.ShowMeOrderByTests(bookIdDesc, desc);

            //Titulo descendente
            var titleDesc = service.BooksOrderer(bookIdDesc, title, desc);

            ShowResultOrderByTitle byTitleDesc = new ShowResultOrderByTitle();
            byTitleDesc.ShowMeOrderByTests(titleDesc, desc);

            //Autor descendente
            var autDesc = service.BooksOrderer(ListBooks, idAutor, desc);

            ShowResultOrderByAuthor byAuthorDesc = new ShowResultOrderByAuthor();
            byAuthorDesc.ShowMeOrderByTests(autDesc, desc);

            //Ano edição descendente
            var yerEditDesc = service.BooksOrderer(ListBooks, editionYear, desc);

            ShowResultOrderByEditionYear yerEdithDesc = new ShowResultOrderByEditionYear();
            yerEdithDesc.ShowMeOrderByTests(yerEditDesc, desc);


            //Testes de Conjuntos -----------------------------------------

            //Conjunto vazio

            ListBooks.Clear();

            IBooksOrderer Empty = new ServiceOrdererById();

            var retBooksNot = service.BooksOrderer(ListBooks, Empty, nop);

            ShowResultOrderByEmpty retBooks = new ShowResultOrderByEmpty();
            retBooks.ShowMeOrderByTests(retBooksNot, desc);

            //Nulo

            ShowResultOrderByNull retNull = new ShowResultOrderByNull();
            retNull.ShowMeOrderByTests(null);          

            ListBooks = null;

            var retBooksNull = service.BooksOrderer(ListBooks, null, nop);

            #endregion

          
        }
    }
}
