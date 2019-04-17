using System;
using System.Collections.Generic;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;

namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Service 
{
    public class SeviceBooksOrderer : IBooksOrderer
    {
        public List<BookModel> BooksOrderer(List<BookModel> BookModel, int titleAsc, int authorAsc, int editAsc)
        {
            throw new NotImplementedException();
        }
    }
}
