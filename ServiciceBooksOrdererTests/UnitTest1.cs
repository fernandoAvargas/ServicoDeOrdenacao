using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;
using ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Domain.ServiceBooksOrderer.Domain;
using ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Domain.ServiceBooksOrderer.Services.Domain;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Domain.SeviceBooksOrderer.Model;
using System.Collections.Generic;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Domain.ListOrderer;

namespace ServiciceBooksOrdererTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]

        public void PopularLista()
        {
            #region Objetos          

/*
            
            

            
      
           
           
           
           
          
         
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

*/

            #endregion

            #region Popular 



            #endregion

        }

        public List<BookModel> Popular()
        {

            List<BookModel> ListBooks = new List<BookModel>();

            ListBooks.Add(new BookModel(1, "Java How to Program", "Deitel & Deitel", 2007, true));
            ListBooks.Add(new BookModel(2, "Patterns of Enterprise Application Architecture", "Martin Fowler", 2002, true));
            ListBooks.Add(new BookModel(3, "Head First Design Patterns", "Elisabeth Freeman", 2004, true));
            ListBooks.Add(new BookModel(4, "Internet & World Wide Web: How to Program", "Deitel & Deitel", 2007, true));

            return ListBooks;
        }

        [TestMethod]
        public void OrdernarPorNumeroDoLivroAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer idBook = new ServiceOrderById();

            var resultado = service.BooksOrderer(Popular(), idBook, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorTituloAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer title = new ServiceOrderByTitle();

            var resultado = service.BooksOrderer(Popular(), title, ordenacao);
        }

        [TestMethod]
        public void OrdernarPorAuthorAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer nomeAutor = new ServiceOrderByAuthor();

            var resultado = service.BooksOrderer(Popular(), nomeAutor, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorAnoDeEdicaoAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer anoDeEdicao = new ServiceOrderByEditionYear();

            var resultado = service.BooksOrderer(Popular(), anoDeEdicao, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorNumeroDoLivroDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer idBook = new ServiceOrderById();

            var resultado = service.BooksOrderer(Popular(), idBook, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorTituloDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer title = new ServiceOrderByTitle();

            var resultado = service.BooksOrderer(Popular(), title, ordenacao);
        }

        [TestMethod]
        public void OrdernarPorAuthorDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer nomeAutor = new ServiceOrderByAuthor();

            var resultado = service.BooksOrderer(Popular(), nomeAutor, 2);
        }


        [TestMethod]
        public void OrdernarPorAnoDeEdicaoDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer anoDeEdicao = new ServiceOrderByEditionYear();

            var resultado = service.BooksOrderer(Popular(), anoDeEdicao, ordenacao);
        }


        [TestMethod]
        public void OrdernarNumeroDoLivroAscTituloDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer LivroEtitulo = new ServiceOrderByIdAndTitle();

            var resultado = service.BooksOrderer(Popular(), LivroEtitulo, ordenacao);
        }

        [TestMethod]
        public void OrdernarNumeroDoLivroAscNomeAutorDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer LivroEautor = new ServiceOrderByIdAndAuthor();

            var resultado = service.BooksOrderer(Popular(), LivroEautor, ordenacao);
        }


        [TestMethod]
        public void OrdernarNumeroDoLivroAscAnoEdicaoDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer LivroEanoEdicao = new ServiceOrderByIdBookAndEditionYear();

            var resultado = service.BooksOrderer(Popular(), LivroEanoEdicao, ordenacao);
        }


        [TestMethod]
        public void OrdernarNumeroDoLivroDescTituloAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer LivroEtitulo = new ServiceOrderByIdAndTitle();

            var resultado = service.BooksOrderer(Popular(), LivroEtitulo, ordenacao);
        }

        [TestMethod]
        public void OrdernarNumeroDoLivroDescNomeAutorAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer LivroEautor = new ServiceOrderByIdAndAuthor();

            var resultado = service.BooksOrderer(Popular(), LivroEautor, ordenacao);
        }


        [TestMethod]
        public void OrdernarNumeroDoLivroDescAnoEdicaoAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer LivroEanoEdicao = new ServiceOrderByIdBookAndEditionYear();

            var resultado = service.BooksOrderer(Popular(), LivroEanoEdicao, ordenacao);
        }



        [TestMethod]
        public void OrdernarPorAutorElivroAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer AutroElivro = new ServiceOrderByAuthorAndId();

            var resultado = service.BooksOrderer(Popular(), AutroElivro, ordenacao);
        }



        [TestMethod]
        public void OrdernarPorAutorEtituloAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer AutorEtitulo = new ServiceOrderByAuthorAndTitle();

            var resultado = service.BooksOrderer(Popular(), AutorEtitulo, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorAutorEanoEdicaoAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer AutorEanoEdicao = new ServiceOrderByAuthorAndEditionYear();

            var resultado = service.BooksOrderer(Popular(), AutorEanoEdicao, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorAutorElivroDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer AutroElivro = new ServiceOrderByAuthorAndId();

            var resultado = service.BooksOrderer(Popular(), AutroElivro, ordenacao);
        }



        [TestMethod]
        public void OrdernarPorAutorEtituloDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer AutorEtitulo = new ServiceOrderByAuthorAndTitle();

            var resultado = service.BooksOrderer(Popular(), AutorEtitulo, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorAutorEanoEdicaoDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer AutorEanoEdicao = new ServiceOrderByAuthorAndEditionYear();

            var resultado = service.BooksOrderer(Popular(), AutorEanoEdicao, ordenacao);
        }



        [TestMethod]
        public void OrdernarPorTituloAscElivroDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer TituloAscElivroDesc = new ServiceOrderByTitleAndId();

            var resultado = service.BooksOrderer(Popular(), TituloAscElivroDesc, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorTituloAscEauthorDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer TituloAscEauthorDesc = new ServiceOrderByTitleAndAuthor();

            var resultado = service.BooksOrderer(Popular(), TituloAscEauthorDesc, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorTituloAscAnoEdicaoDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer TituloAscAnoEdicaoDesc = new ServiceOrderByTitleAndEditionYear();

            var resultado = service.BooksOrderer(Popular(), TituloAscAnoEdicaoDesc, ordenacao);
        }



        [TestMethod]
        public void OrdenarPorTituloAscElivroDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer TituloAscElivroDesc = new ServiceOrderByTitleAndId();

            var resultado = service.BooksOrderer(Popular(), TituloAscElivroDesc, ordenacao);
        }


        [TestMethod]
        public void OrdenarPorTituloAscEauthorDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer TituloAscEauthorDesc = new ServiceOrderByTitleAndAuthor();

            var resultado = service.BooksOrderer(Popular(), TituloAscEauthorDesc, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorTituloDescAnoEdicaoAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer TituloDescAnoEdicaoAsc = new ServiceOrderByTitleAndEditionYear();

            var resultado = service.BooksOrderer(Popular(), TituloDescAnoEdicaoAsc, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorTituloDescEanoEdicaoAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Desc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer TituloAscAnoEdicaoDesc = new ServiceOrderByTitleAndEditionYear();

            var resultado = service.BooksOrderer(Popular(), TituloAscAnoEdicaoDesc, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorAnoDeEdicaoAscEnumereoDoLivroDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer AnoDeEdicaoAscEnumereoDoLivroDesc = new ServiceOrderByEditionYearAndIdBook();

            var resultado = service.BooksOrderer(Popular(), AnoDeEdicaoAscEnumereoDoLivroDesc, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorAnoDeEdicaoAscEautorDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer AnoDeEdicaoAscEautorDesc = new ServiceOrderByEditionYearAndAuthor();

            var resultado = service.BooksOrderer(Popular(), AnoDeEdicaoAscEautorDesc, ordenacao);
        }


        [TestMethod]
        public void OrdernarPorAnoEdicaoAscTituloDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer AnoEdicaoAscTituloDesc = new ServiceOrderByTitleAndEditionYear();

            var resultado = service.BooksOrderer(Popular(), AnoEdicaoAscTituloDesc, ordenacao);
        }


        // Esse método booksOrderer é bastante flexível. Com ele é possível ordenar até tres colunas
        // Exemplo:



        [TestMethod]
        public void OrdenarPorNumeroDoLivroAscTitluloDescEautorDesc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer NumeroDoLivroAscTitluloDescEautorDesc = new ServiceOrderByIdAndTitleAndAuthor();

            var resultado = service.BooksOrderer(Popular(), NumeroDoLivroAscTitluloDescEautorDesc, ordenacao);
        }



        [TestMethod]
        public void OrdenarNumeroDoLivroDescTitluloAscEautorAsc()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer NumeroDoLivroDescTitluloAscEautorAsc = new ServiceOrderByIdAndTitleAndAuthor();

            var resultado = service.BooksOrderer(Popular(), NumeroDoLivroDescTitluloAscEautorAsc, ordenacao);
        }

        [TestMethod]
        public void OrdenarUmCojuntoVazio()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            List<BookModel> ConjuntoVazio = new List<BookModel>();

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            IBooksOrderer Empty = new ServiceOrderById();

            var resultado = service.BooksOrderer(ConjuntoVazio, Empty, ordenacao);      }


        [TestMethod]
        public void OrdenarConjuntoNuloTemQueDarOrderbyException()
        {
            int ordenacao = Convert.ToInt32(ListOrderes.Asc);

            SeviceBooksOrderer service = new SeviceBooksOrderer();

            List<BookModel> ConjuntoNulo = null;

            IBooksOrderer Empty = new ServiceOrderById();

            IBooksOrderer NumeroDoLivroDescTitluloAscEautorAsc = new ServiceOrderByIdAndTitleAndAuthor();

            var resultado = service.BooksOrderer(ConjuntoNulo, Empty, ordenacao);
        }











    }
    }

