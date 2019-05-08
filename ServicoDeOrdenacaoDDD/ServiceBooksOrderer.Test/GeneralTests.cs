
using System;
using System.Collections.Generic;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Test;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Domain;
using ServicoDeOrdenacaoDDD.ServiceBooksOrderer.Domain.Docs;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Domain.ListOrderer;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Domain.SeviceBooksOrderer.Model;
using ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Domain.ServiceBooksOrderer.Domain;
using ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Domain.ServiceBooksOrderer.Services.Domain;

namespace ServiceBooksOrdererDDD
{
    class Program
    {
        static List<BookModel> ListBooks;      

        static void Main(string[] args)
        {
            #region Popular 

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
            IBooksOrderer idBookAndAuthor = new ServiceOrderByIdAndAuthor();
            IBooksOrderer idBookAndEditionYear = new ServiceOrderByIdBookAndEditionYear();
            IBooksOrderer authorAndIdBook = new ServiceOrderByAuthorAndId();
            IBooksOrderer authorAndTitle = new ServiceOrderByAuthorAndTitle();
            IBooksOrderer authorAndEditionYear = new ServiceOrderByAuthorAndEditionYear();
            IBooksOrderer titleAndIdBook = new ServiceOrderByTitleAndId();
            IBooksOrderer titleAndAuthor = new ServiceOrderByTitleAndAuthor();
            IBooksOrderer titleAndEditionYear = new ServiceOrderByTitleAndEditionYear();
            IBooksOrderer editionYearAndIdBook = new ServiceOrderByEditionYearAndIdBook();
            IBooksOrderer editionYearAndTitle = new ServiceOrderByEditionYearAndTitle();
            IBooksOrderer editionYearAndAuthor = new ServiceOrderByEditionYearAndAuthor();
            IBooksOrderer idBookAndTitleAndAuthor = new ServiceOrderByIdAndTitleAndAuthor();
            IBooksOrderer idBookAndAuthorAndTitle = new ServiceOrderByIdAndAuthorAndTitle();
            IBooksOrderer idBookAndEditionYearAndTitle = new ServiceOrderByIdAndEditionYearAndTitle();
            IBooksOrderer idBookAndTitleAndEditionYear = new ServiceOrderByIdAndTitleAndEditionYear();
            IBooksOrderer idBookAndAuthorAndEditionYear = new ServiceOrderByIdAndAuthorAndEditionYear();
            IBooksOrderer idBookAndEditionYearAndAuthor = new ServiceOrderByIdAndEditionYearAndAuthor();
            IBooksOrderer titleAndIdBookAndAuthor = new ServiceOrderByTitleAndIdAndAuthor();
            IBooksOrderer titleAndAuthorAndIdBook = new ServiceOrderByTitleAndAuthorAndId();
            IBooksOrderer titleAndIdBookAndEditionYear = new ServiceOrderByTitleAndIdAndEditionYear();
            IBooksOrderer titleAndEditionYearAndIdBook = new ServiceOrderByTitleAndEditionYearAndId();
            IBooksOrderer titleAndAuthorAndEditionYear = new ServiceOrderByTitleAndAuthorAndEditionYear();
            IBooksOrderer titleAndEditionYearAndAuthor = new ServiceOrderByTitleAndEditionYearAndAuthor();
            IBooksOrderer authorAndIdBookAndTitle = new ServiceOrderByAuthorAndIdAndTitle();
            IBooksOrderer authorAndTitleAndIdBook = new ServiceOrderByAuthorAndTitleAndId();
            IBooksOrderer authorAndIdBookAndEditionYear = new ServiceOrderByAuthorAndIdAndEditionYear();
            IBooksOrderer authorAndEditionYearAndIdBook = new ServiceOrderByAuthorAndEditionYearAndId();
            IBooksOrderer authorAndTitleAndEditionYear = new ServiceOrderByAuthorAndTitleAndEditionYear();
            IBooksOrderer authorAndEditionYearAndTitle = new ServiceOrderByAuthorAndEditionYearAndTitle();
            IBooksOrderer editionYearAndIdBookAndTitle = new ServiceOrderByEditionYearAndIdAndTitle();
            IBooksOrderer editionYearAndTitleAndIdBook = new ServiceOrderByEditionYearAndTitleAndId();
            IBooksOrderer editionYearAndIdBookAndAuthor = new ServiceOrderByEditionYearAndIdAndAuthor();
            IBooksOrderer editionYearAndAuthorAndIdBook = new ServiceOrderByEditionYearAndAuthorAndId();
            IBooksOrderer editionYearAndTitleAndAuthor = new ServiceOrderByEditionYearAndTitleAndAuthor();
            IBooksOrderer editionYearAndAuthorAndTitle = new ServiceOrderByEditionYearAndAuthorAndTitle();
            
            #endregion

            #region Ordenações

            int asc = Convert.ToInt32(ListOrderes.Asc);
            int desc = Convert.ToInt32(ListOrderes.Desc);
            int nop = Convert.ToInt32(ListOrderes.Nop);

            #endregion

            #region Testes

            //Teste Ascendente -------------------------------------------------

            // IdLivro ascendente
            var bookIdAsc = service.BooksOrderer(ListBooks,idBook, asc);
            ShowResultOrderByBook byBookAsc = new ShowResultOrderByBook();
            byBookAsc.ShowMeOrderByTests(bookIdAsc, asc);

            // Titulo ascendente
            var titleAsc = service.BooksOrderer(ListBooks, title, asc);

            ShowResultOrderByTitle byTitleAsc = new ShowResultOrderByTitle();
            byTitleAsc.ShowMeOrderByTests(titleAsc, asc);

            // Autor ascendente
            var autAsc = service.BooksOrderer(ListBooks, idAutor, asc);

            ShowResultOrderByAuthor byAuthorAsc = new ShowResultOrderByAuthor();
            byAuthorAsc.ShowMeOrderByTests(autAsc, asc);

            // Ano edição ascendente
            var yerEditAsc = service.BooksOrderer(ListBooks, editionYear, asc);

            ShowResultOrderByEditionYear byEditionYearAsc = new ShowResultOrderByEditionYear();
            byEditionYearAsc.ShowMeOrderByTests(yerEditAsc, asc);

            //Teste descendente -----------------------------------------------

            // IdLivro descendente
            var bookIdDesc = service.BooksOrderer(ListBooks, idBook, desc);

            ShowResultOrderByBook byBooDesc = new ShowResultOrderByBook();
            byBooDesc.ShowMeOrderByTests(bookIdDesc, desc);

            // Titulo descendente
            var titleDesc = service.BooksOrderer(bookIdDesc, title, desc);

            ShowResultOrderByTitle byTitleDesc = new ShowResultOrderByTitle();
            byTitleDesc.ShowMeOrderByTests(titleDesc, desc);

            // Autor descendente
            var autDesc = service.BooksOrderer(ListBooks, idAutor, desc);

            ShowResultOrderByAuthor byAuthorDesc = new ShowResultOrderByAuthor();
            byAuthorDesc.ShowMeOrderByTests(autDesc, desc);

            // Ano edição descendente
            var yerEditDesc = service.BooksOrderer(ListBooks, editionYear, desc);

            ShowResultOrderByEditionYear yerEdithDesc = new ShowResultOrderByEditionYear();
            yerEdithDesc.ShowMeOrderByTests(yerEditDesc, desc);

            #endregion

            // Requisitos de ordenações especiais  ---------------------------------------

            // IdLivro e Titulo

            var bookAndTitleAsc = service.BooksOrderer(ListBooks, idBookAndTitle, asc);

            ShowResultOrderByIdAndTitle BookAndTitleAsc = new ShowResultOrderByIdAndTitle();
            BookAndTitleAsc.ShowMeOrderByTests(bookAndTitleAsc, asc);

            var bookAndTitleDesc = service.BooksOrderer(ListBooks, idBookAndTitle, desc);

            ShowResultOrderByIdAndTitle BookAndTitleDesc = new ShowResultOrderByIdAndTitle();
            BookAndTitleDesc.ShowMeOrderByTests(bookAndTitleDesc, desc);

            // IdLivro e Autor 

            var idBookAndAutorAsc = service.BooksOrderer(ListBooks, idBookAndAuthor, asc);

            ShowResultOrderByIdAndAuthor BookAndAuthorAsc = new ShowResultOrderByIdAndAuthor();
          //  BookAndAuthorAsc.ShowMeOrderByTests(bookAndAuthorAsc, asc);

            var idBookAndAutorDesc = service.BooksOrderer(ListBooks, idBookAndAuthor, desc);

          //  ShowResultOrderByIdAndAuthor BookAndAuthorAsc = new ShowResultOrderByIdAndAuthor();
          //  BookAndAuthorAsc.ShowMeOrderByTests(bookAndAuthorAsc, asc);

            // IdLivro e Ano da Edição 

            var idBookAndEditionYearAsc = service.BooksOrderer(ListBooks, idBookAndEditionYear, asc);

            // show asc

            var idBookAndEditionYearDesc = service.BooksOrderer(ListBooks, idBookAndEditionYear, desc);

            // show desc

            //Titulo e IdLivro

            var titleAndBookAsc = service.BooksOrderer(ListBooks, titleAndIdBook, asc);

            ShowResultOrderByTitleAndId TitleAndBookAsc = new ShowResultOrderByTitleAndId();
            TitleAndBookAsc.ShowMeOrderByTests(titleAndBookAsc, asc);

            var titleAndBookDesc = service.BooksOrderer(ListBooks, idBookAndTitle, desc);

            ShowResultOrderByTitleAndId TitleAndBookDesc = new ShowResultOrderByTitleAndId();
            TitleAndBookDesc.ShowMeOrderByTests(titleAndBookDesc, desc);

            // Titulo e Autor          

            var titleAndAuthorAsc = service.BooksOrderer(ListBooks, titleAndAuthor, asc);

            //show asc

            var titleAndAuthorDesc = service.BooksOrderer(ListBooks, titleAndAuthor, desc);

            //show desc

            // Titulo e Ano de Edição          

            var titleAndEditionYearAsc = service.BooksOrderer(ListBooks, titleAndEditionYear, asc);

            //show asc

            var titleAndEditionYearDesc = service.BooksOrderer(ListBooks, titleAndEditionYear, desc);

            //show desc

            // Autor e IdLivro

            var authorAndIdBookAsc = service.BooksOrderer(ListBooks, authorAndIdBook, asc);

            // show asc

            var authorAndIdBookDesc = service.BooksOrderer(ListBooks, authorAndIdBook, desc);

            // show desc

            // Autor e Titulo

            var authorAndTitleAsc = service.BooksOrderer(ListBooks, authorAndTitle, asc);

            // show asc

            var authorAndTitleDesc = service.BooksOrderer(ListBooks, authorAndTitle, desc);

            // show desc

            // Autor e Ano da Edição

            var authorAndEditionYearAsc = service.BooksOrderer(ListBooks, authorAndEditionYear, asc);

            //show asc

            var authorAndEditionYearDesc = service.BooksOrderer(ListBooks, authorAndEditionYear, desc);

            //show desc

            // Ano da Edição e IdLivro

            var editionYearAndIdBookAsc = service.BooksOrderer(ListBooks, editionYearAndIdBook, asc);

            // show asc

            var editionYearAndIdBookDesc = service.BooksOrderer(ListBooks, editionYearAndIdBook, desc);

            // show desc

            // Ano da Edição e Titulo

            var editionYearAndTitleAsc = service.BooksOrderer(ListBooks, editionYearAndTitle, asc);

            // show asc

            var editionYearAndTitleDesc = service.BooksOrderer(ListBooks, editionYearAndTitle, desc);

            // show desc 

            // Ano da Edição e Autor

            var editionYearAndAuthorAsc = service.BooksOrderer(ListBooks, editionYearAndAuthor, asc);

            // show asc

            var editionYearAndAuthorDesc = service.BooksOrderer(ListBooks, editionYearAndAuthor, desc);

            // show desc 

            // IdLivro , Titulo e Autor 

            var idBookAndTitleAndAuthorAsc = service.BooksOrderer(ListBooks, idBookAndTitleAndAuthor, asc);

            // show asc

            var idBookAndTitleAndAuthorDesc = service.BooksOrderer(ListBooks, idBookAndTitleAndAuthor, desc);

            // show desc

            // IdLivro , Autor e Titulo

            var idBookAndAuthorAndTitleAsc = service.BooksOrderer(ListBooks, idBookAndAuthorAndTitle, asc);

            // show asc

            var idBookAndAuthorAndTitleDesc = service.BooksOrderer(ListBooks, idBookAndAuthorAndTitle, desc);

            // show desc

            // IdLivro , Titulo e Ano de Edição

            var idBookAndTitleAndEditionYearAsc = service.BooksOrderer(ListBooks, idBookAndTitleAndEditionYear, asc);

            //show asc

            var idBookAndTitleAndEditionYearDesc = service.BooksOrderer(ListBooks, idBookAndTitleAndEditionYear, desc);

            // show desc

            // IdLivro , Ano de Edição e Titulo

            var idBookAndEditionYearAndTitleAsc = service.BooksOrderer(ListBooks, idBookAndEditionYearAndTitle, asc);

            //show asc

            var idBookAndEditionYearAndTitleDesc = service.BooksOrderer(ListBooks, idBookAndEditionYearAndTitle, desc);

            // show desc 

            // IdLivro , Autor e Ano de Edição 

            var idBookAndAuthorAndEditionYearAsc = service.BooksOrderer(ListBooks, idBookAndAuthorAndEditionYear, asc);

            //show asc

            var idBookAndAuthorAndEditionYearDesc = service.BooksOrderer(ListBooks, idBookAndAuthorAndEditionYear, desc);

            // show desc

            // IdLivro, Ano de Edição e Autor  

            var idBookAndEditionYearAndAuthorAsc = service.BooksOrderer(ListBooks, idBookAndEditionYearAndAuthor, asc);

            //show asc

            var idBookAndEditionYearAndAuthorDesc = service.BooksOrderer(ListBooks, idBookAndEditionYearAndAuthor, desc);

            // show desc

            // Titulo,IdLivro e Autor 

            var titleAndIdBookAndAuthorAsc = service.BooksOrderer(ListBooks, titleAndIdBookAndAuthor, asc);

            // show asc

            var titleAndIdBookAndAuthorDesc = service.BooksOrderer(ListBooks, titleAndIdBookAndAuthor, desc);

            // show desc

            // Titulo , Autor e IdLivro

            var titleAndAuthorAndIdBookAsc = service.BooksOrderer(ListBooks, titleAndAuthorAndIdBook, asc);

            // show asc

            var titleAndAuthorAndIdBookDesc = service.BooksOrderer(ListBooks, titleAndAuthorAndIdBook, desc);

            // show desc

            // Titulo, IdLivro e Ano de Edição

            var titleAndIdBookAndEditionYearAsc = service.BooksOrderer(ListBooks, titleAndIdBookAndEditionYear, asc);

            //show asc

            var titleAndIdBookAndEditionYearDesc = service.BooksOrderer(ListBooks, titleAndIdBookAndEditionYear, desc);

            // show desc

            // Titulo, Ano de Edição e IdLivro

            var titleAndEditionYearAndIdBookAsc = service.BooksOrderer(ListBooks, titleAndEditionYearAndIdBook, asc);

            //show asc

            var titleAndEditionYearAndIdBookDesc = service.BooksOrderer(ListBooks, titleAndEditionYearAndIdBook, desc);

            // show desc 

            // Titulo, Autor e Ano de Edição 

            var titleAndAuthorAndEditionYearAsc = service.BooksOrderer(ListBooks, titleAndAuthorAndEditionYear, asc);

            //show asc

            var titleAndAuthorAndEditionYearDesc = service.BooksOrderer(ListBooks, titleAndAuthorAndEditionYear, desc);

            // show desc

            // Titulo, Ano de Edição e Autor  

            var titleAndEditionYearAndAuthorAsc = service.BooksOrderer(ListBooks, titleAndEditionYearAndAuthor, asc);

            //show asc

            var titleAndEditionYearAndAuthorDesc = service.BooksOrderer(ListBooks, titleAndEditionYearAndAuthor, desc);

            // show desc

            // Autor,IdLivro, Titulo 
            var autorAndIdBookAndTitleAsc = service.BooksOrderer(ListBooks, authorAndIdBookAndTitle, asc);

            // show asc

            var autorAndIdBookAndTitleDesc = service.BooksOrderer(ListBooks, authorAndIdBookAndTitle, desc);

            // show desc

            // Autor, Titulo e IdLivro

            var authorAndTitleAndIdBookAsc = service.BooksOrderer(ListBooks, authorAndTitleAndIdBook, asc);

            // show asc

            var authorAndTitleAndIdBookDesc = service.BooksOrderer(ListBooks, authorAndTitleAndIdBook, desc);

            // show desc

            // Autor, IdLivro e Ano de Edição

            var authorAndIdBookAndEditionYearAsc = service.BooksOrderer(ListBooks, authorAndIdBookAndEditionYear, asc);

            //show asc

            var authorAndIdBookAndEditionYearDesc = service.BooksOrderer(ListBooks, authorAndIdBookAndEditionYear, desc);

            // show desc

            // Autor, Ano de Edição e IdLivro

            var authorAndEditionYearAndIdBookAsc = service.BooksOrderer(ListBooks, authorAndEditionYearAndIdBook, asc);

            //show asc

            var authorAndEditionYearAndIdBookDesc = service.BooksOrderer(ListBooks, authorAndEditionYearAndIdBook, desc);

            // show desc 

            // Autor, Titulo e Ano de Edição 

            var authorAndTitleAndEditionYearAsc = service.BooksOrderer(ListBooks, authorAndTitleAndEditionYear, asc);

            //show asc

            var authorAndTitleAndEditionYearDesc = service.BooksOrderer(ListBooks, authorAndTitleAndEditionYear, desc);

            // show desc

            // Autor, Ano de Edição e Titulo

            var AuthorAndEditionYearAndTitleAsc = service.BooksOrderer(ListBooks, authorAndEditionYearAndTitle, asc);

            //show asc

            var AuthorAndEditionYearAndTitleDesc = service.BooksOrderer(ListBooks, authorAndEditionYearAndTitle, desc);

            // show desc

            // Ano Edição ,IdLivro, Titulo 

            var editionYearAndIdBookAndTitleAsc = service.BooksOrderer(ListBooks, editionYearAndIdBookAndTitle, asc);

            // show asc

            var editionYearAndIdBookAndTitleDesc = service.BooksOrderer(ListBooks, editionYearAndIdBookAndTitle, desc);

            // show desc

            // Ano Edição, Titulo e IdLivro

            var editionYearAndTitleAndIdBookAsc = service.BooksOrderer(ListBooks, editionYearAndTitleAndIdBook, asc);

            // show asc

            var editionYearAndTitleAndIdBookDesc = service.BooksOrderer(ListBooks, editionYearAndTitleAndIdBook, desc);

            // show desc

            // Ano Edição, IdLivro e Autor

            var editionYearAndIdBookAndAuthorAsc = service.BooksOrderer(ListBooks, editionYearAndIdBookAndAuthor, asc);

            //show asc

            var editionYearAndIdBookAndAuthorDesc = service.BooksOrderer(ListBooks, editionYearAndIdBookAndAuthor, desc);

            // show desc

            // Ano Edição, Autor e IdLivro

            var editionYearAndAuthorAndIdBookAsc = service.BooksOrderer(ListBooks, editionYearAndAuthorAndIdBook, asc);

            //show asc

            var editionYearAndAuthorAndIdBookDesc = service.BooksOrderer(ListBooks, editionYearAndAuthorAndIdBook, desc);

            // show desc 

            // Ano de Edição, Titulo e  Autor

            var editionYearAndTitleAndAuthorAsc = service.BooksOrderer(ListBooks, editionYearAndTitleAndAuthor, asc);

            //show asc

            var editionYearAndTitleAndAuthorDesc = service.BooksOrderer(ListBooks, editionYearAndTitleAndAuthor, desc);

            // show desc

            // Ano de Edição, Autor, e Titulo

            var editionYearAndAuthorAndTitleAsc = service.BooksOrderer(ListBooks, editionYearAndAuthorAndTitle, asc);

            //show asc

            var editionYearAndAuthorAndTitleDesc = service.BooksOrderer(ListBooks, editionYearAndAuthorAndTitle, desc);

            // show desc

            //Testes de Conjuntos -----------------------------------------

            //Conjunto vazio

            ListBooks.Clear();

            IBooksOrderer Empty = new ServiceOrderById();

            var retBooksNot = service.BooksOrderer(ListBooks, Empty, nop);

            ShowResultOrderByEmpty retBooks = new ShowResultOrderByEmpty();
            retBooks.ShowMeOrderByTests(retBooksNot, desc);

            //Fim

            ShowResultOrderByEnd.ShowMeOrderByEnd();          

      //  #endregion

        }
    }
}



