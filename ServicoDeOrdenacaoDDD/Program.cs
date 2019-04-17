using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceBooksOrdererDDD
{
    class Program
    {
        static List<BookModel> ListBooks;
        static List<AuthorBookModel> ListAuthorBooks;

        static void Main(string[] args)
        {
            SeviceBooksOrderer.Service.SeviceBooksOrderer service = new SeviceBooksOrderer.Service.SeviceBooksOrderer();

            ListBooks = new List<BookModel>();
            ListAuthorBooks = new List<AuthorBookModel>();

            //var Author = new AuthorBookModel();

            ListAuthorBooks.Add(new AuthorBookModel(1, "Deitel & Deitel", true));

            //Author.idAuthor = 1;
            //Author.name = "Deitel & Deitel";
            //Author.active = true;

            //var Books = new BookModel();

            ListBooks.Add(new BookModel(1, "Java How to Program", ListAuthorBooks, 2007, true));

            //Books.idBook = 1;
            //Books.title = "Java How to Program";            
            //Books.editionYear = 2007;
            //Books.active = true;  

            //ListBooks.Add(Books);
/*
            Books.idBook = 2;
            Books.title = "Patterns of Enterprise Application Architecture";
            Books.AuthorBookModel[1].idAuthor = 1;
            Books.AuthorBookModel[1].name = "Martin Fowler";
            Books.editionYear = 2002;
            Books.active = true;

            Books.idBook = 3;
            Books.title = "Head First Design Patterns";
            Books.AuthorBookModel[2].idAuthor = 1;
            Books.AuthorBookModel[2].name = "Elisabeth Freeman";
            Books.editionYear = 2004;
            Books.active = true;

            Books.idBook = 4;
            Books.title = "Internet & World Wide Web: How to Program";
            Books.AuthorBookModel[3].idAuthor = 1;
            Books.AuthorBookModel[3].name = "Deitel & Deitel";
            Books.editionYear = 2007;
            Books.active = true;

            */

            var retBooks = service.BooksOrderer(ListBooks,1,1,1);

        }
    }
}
