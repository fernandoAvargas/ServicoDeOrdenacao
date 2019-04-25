using System;
using System.Linq;
using System.Collections.Generic;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Domain.ListOrderer;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Domain.SeviceBooksOrderer.Model;

namespace ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Domain.ServiceBooksOrderer.Domain
{
    public class ServiceOrderById : IBooksOrderer
    {
        public List<BookModel> BooksOrderer(List<BookModel> BookModel, int order)
        {
            List<BookModel> ListBooks = new List<BookModel>();
            int asc = Convert.ToInt32(ListOrderes.Asc);
            int desc = Convert.ToInt32(ListOrderes.Desc);

            if (order == asc)
            {

                ListBooks = BookModel.OrderBy(o => o.idBook).ToList<BookModel>();

            }
            else if (order == desc)
            {

                ListBooks = BookModel.OrderByDescending(o => o.idBook).ToList<BookModel>();

            }

            return ListBooks;
        }
    }      
}
