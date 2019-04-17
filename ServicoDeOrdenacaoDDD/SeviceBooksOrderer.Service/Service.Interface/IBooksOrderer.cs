﻿
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using System.Collections.Generic;

namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface
{
    interface IBooksOrderer
    {
        List<BookModel> BooksOrderer(List<BookModel> BookModel, int titleAsc, int authorAsc, int editAsc); 
    }
}