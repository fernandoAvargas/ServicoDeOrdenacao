
using System;
using System.Collections.Generic;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;

namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Service
{
    public class BooksOrderer : IBooksOrderer
    {
        List<BookModel> IBooksOrderer.BooksOrderer(List<BookModel> BookModel, int titleAsc, int authorAsc, int editAsc)
        {
            return null;
        }
    }
}
