using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Infra.ListOrderer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Service.ServiceBooksOrderer.Design
{
    public class ServiceOrderByAuthor : IBooksOrderer
    {
        public List<BookModel> BooksOrderer(List<BookModel> BookModel, int order)
        {
            List<BookModel> ListBooks = new List<BookModel>();
            int asc = Convert.ToInt32(ListOrderes.Asc);
            int desc = Convert.ToInt32(ListOrderes.Desc);

            if (order == asc)
            {

                ListBooks = BookModel.OrderBy(o => o.authorName).ToList<BookModel>();

            }
            else if (order == desc)
            {

                ListBooks = BookModel.OrderByDescending(o => o.authorName).ToList<BookModel>();

            }

            return ListBooks;
        }
    }
}
