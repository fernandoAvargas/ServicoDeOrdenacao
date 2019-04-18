using System.Collections.Generic;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;
using System.Linq;
using ServicoDeOrdenacaoDDD.ServiceBooksOrder.Infra.ListOrderer;
using System;

namespace ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Service.ServiceBooksOrderer.Design
{
    class ServiceOrdererById : IBooksOrderer
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
