using System;
using System.Linq;
using System.Collections.Generic;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Domain.ListOrderer;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Domain.SeviceBooksOrderer.Model;

namespace ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Domain.ServiceBooksOrderer.Services.Domain
{
    public class ServiceOrderByTitleAndAuthorAndEditionYear : IBooksOrderer
    {
        public List<BookModel> BooksOrderer(List<BookModel> BookList, int order)
        {
            List<BookModel> ListBooks = new List<BookModel>();
            int asc = Convert.ToInt32(ListOrderes.Asc);
            int desc = Convert.ToInt32(ListOrderes.Desc);

            if (order == asc)
            {
                ListBooks = (from o in BookList
                             orderby o.title ascending, o.authorName descending, o.editionYear descending
                             select o).ToList();
            }
            else if (order == desc)
            {

                ListBooks = BookList.OrderByDescending(o => o.title).ThenBy(o => o.authorName).ThenBy(o => o.editionYear).ToList();
            }

            return ListBooks;
        }
    }
}
