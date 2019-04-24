using System;
using System.Linq;
using System.Collections.Generic;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Domain.SeviceBooksOrderer.Model;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Domain.ListOrderer;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;

namespace ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Domain.ServiceBooksOrderer.Services.Domain
{
    public class ServiceOrderByIdAndAuthorAndTitle : IBooksOrderer
    {
        List<BookModel> ListBooks = new List<BookModel>();
        int asc = Convert.ToInt32(ListOrderes.Asc);
        int desc = Convert.ToInt32(ListOrderes.Desc);

        public List<BookModel> BooksOrderer(List<BookModel> BookList, int order)
        {
            if (order == asc)
            {
                ListBooks = (from o in BookList
                             orderby o.idBook, o.authorName, o.title
                             select o).ToList();
            }

            else if (order == desc)
            {

                ListBooks = BookList.OrderByDescending(o => o.idBook).ThenByDescending(o => o.authorName).ThenByDescending(o => o.title).ToList();
            }

            return ListBooks;
        }
    }
}
