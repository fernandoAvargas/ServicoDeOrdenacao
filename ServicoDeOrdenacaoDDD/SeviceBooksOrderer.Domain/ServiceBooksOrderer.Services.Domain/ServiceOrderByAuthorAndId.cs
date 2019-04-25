﻿using System;
using System.Linq;
using System.Collections.Generic;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Domain.ListOrderer;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Domain.SeviceBooksOrderer.Model;

namespace ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Domain.ServiceBooksOrderer.Services.Domain
{
    public class ServiceOrderByAuthorAndId : IBooksOrderer
    {
        List<BookModel> ListBooks = new List<BookModel>();
        int asc = Convert.ToInt32(ListOrderes.Asc);
        int desc = Convert.ToInt32(ListOrderes.Desc);

        public List<BookModel> BooksOrderer(List<BookModel> BookList, int order)
        {
            if (order == asc)
            {
                ListBooks = (from o in BookList
                             orderby o.authorName ascending, o.idBook descending 
                             select o).ToList();
            }
            else if (order == desc)
            {

                ListBooks = BookList.OrderByDescending(o => o.authorName).ThenBy(o => o.idBook).ToList();
            }

            return ListBooks;
        }
    }
}
