
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Domain.SeviceBooksOrderer.Model;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;
using ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Domain.ServiceBooksOrderer.Domain;
using ServicoDeOrdenacaoDDD.SeviceBooksOrderer.Domain.ServiceBooksOrderer.Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Service
{
    public class SeviceBooksOrderer
    {


        List<BookModel> ListBooks = new List<BookModel>();

        public List<BookModel> BooksOrderer(List<BookModel> BookModel, IBooksOrderer booksOrderer, int idOrder)
        {
            try
            {
                if (BookModel != null)
                {

                    return ListBooks = booksOrderer.BooksOrderer(BookModel, idOrder).ToList();
                }
                else
                {
                    throw new Exception("Orderby Exception");
                }

            }

            catch (Exception)
            {
                throw;
            }              
        }
    }
}







