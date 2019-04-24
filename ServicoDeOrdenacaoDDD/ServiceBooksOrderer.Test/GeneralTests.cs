
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Domain.SeviceBooksOrderer.Model;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Domain.ListOrderer;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Domain;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Domain.Docs;
using ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Domain.ServiceBooksOrderer.Domain;
using ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Domain.ServiceBooksOrderer.Services.Domain;
using System;
using System.Collections.Generic;

namespace ServiceBooksOrdererDDD
{
    class Program
    {
        static List<BookModel> ListBooks;

        static void Main(string[] args)
        {

            #region Popular 

            List<BookModel> ListBooks = new List<BookModel>();

            ListBooks = new List<BookModel>();

            ListBooks.Add(new BookModel(1, "Java How to Program", "Deitel & Deitel", 2007, true));
            ListBooks.Add(new BookModel(2, "Patterns of Enterprise Application Architecture", "Martin Fowler", 2002, true));
            ListBooks.Add(new BookModel(3, "Head First Design Patterns", "Elisabeth Freeman", 2004, true));
            ListBooks.Add(new BookModel(4, "Internet & World Wide Web: How to Program", "Deitel & Deitel", 2007, true));

            #endregion

            #region Docs

            Documentation.DocSystem();

            #endregion

            #region Objetos

            SeviceBooksOrderer.Service.SeviceBooksOrderer service = new SeviceBooksOrderer.Service.SeviceBooksOrderer();

            IBooksOrderer idBook = new ServiceOrderById();
            IBooksOrderer title = new ServiceOrderByTitle();
            IBooksOrderer idAutor = new ServiceOrderByAuthor();
            IBooksOrderer editionYear = new ServiceOrderByEditionYear();
            IBooksOrderer idBookAndTitle = new ServiceOrderByIdAndTitle();
            IBooksOrderer titleAndIdBook = new ServiceOrderByTitleAndId();
            IBooksOrderer titleAndAuthor = new ServiceOrderByTitleAndAuthor();
            IBooksOrderer authorAndTitle = new ServiceOrderByAuthorAndTitle();
            IBooksOrderer authorAndEditionYear = new ServiceOrderByAuthorAndEditionYear();
            IBooksOrderer editionYearAndAuthor = new ServiceOrderByEditionYearAndAuthor();
            IBooksOrderer idBookAndTitleAndAuthor = new ServiceOrderByIdAndTitleAndAuthor();
            IBooksOrderer idBookAndAuthorAndTitle = new ServiceOrderByIdAndAuthorAndTitle();
            IBooksOrderer idBookAndEditionYearAndTitle = new ServiceOrderByIdAndEditionYearAndTitle();
            IBooksOrderer idBookAndTitleAndEditionYear = new ServiceOrderByIdAndTitleAndEditionYear();
            IBooksOrderer titleAndIdBookAndAuthor = new ServiceOrderByTitleAndIdAndAuthor();
            IBooksOrderer titleAndAuthorAndIdBook = new ServiceOrderByTitleAndAuthorAndId();
            IBooksOrderer authorAndTitleAndIdBook = new ServiceOrderByAuthorAndTitleAndId();
            IBooksOrderer authorAndIdBookAndTitle = new ServiceOrderByAuthorAndIdAndTitle();
            IBooksOrderer editionYearAndAuthorAndTitle = new ServiceOrderByEditionYearAndAuthorAndTitle();
            IBooksOrderer editionYearAndTitleAndAuthor = new ServiceOrderByEditionYearAndTitleAndAuthor();
            IBooksOrderer editionYearAndTitleAndIdBook = new ServiceOrderByEditionYearAndIdAndTitle();

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

            // Requisitos de ordenações especiais  ---------------------------------------

            //IdLivro e Titulo
            var bookAndTitleAsc = service.BooksOrderer(ListBooks, idBookAndTitle, asc);

            ShowResultOrderByIdAndTitle BookAndTitleAsc = new ShowResultOrderByIdAndTitle();
            BookAndTitleAsc.ShowMeOrderByTests(bookAndTitleAsc, asc);

            var bookAndTitleDesc = service.BooksOrderer(ListBooks, idBookAndTitle, desc);

            ShowResultOrderByIdAndTitle BookAndTitleDesc = new ShowResultOrderByIdAndTitle();
            BookAndTitleDesc.ShowMeOrderByTests(bookAndTitleDesc, desc);

            //Testes de Conjuntos -----------------------------------------

            //Conjunto vazio

            ListBooks.Clear();

            IBooksOrderer Empty = new ServiceOrderById();

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



