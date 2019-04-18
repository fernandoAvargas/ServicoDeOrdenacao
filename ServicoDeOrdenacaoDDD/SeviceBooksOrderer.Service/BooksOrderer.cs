using System;
using System.Collections.Generic;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface;
using System.Linq;

namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Service
{
    public class SeviceBooksOrderer : IBooksOrderer
    {
        public List<BookModel> BooksOrderer(List<BookModel> BookModel, int idOrder = 0, int titleOrder = 0, int authorOrder = 0, int editOrder = 0)
        {
            try
            {
                if (BookModel != null)
                {
                    List<BookModel> ListBooks = new List<BookModel>();

                    if (idOrder == 1)
                    {

                        ListBooks = BookModel.OrderBy(o => o.idBook).ToList<BookModel>();

                    }
                    else if (idOrder == 2)
                    {

                        ListBooks = BookModel.OrderByDescending(o => o.idBook).ToList<BookModel>();

                    }
                    else if (titleOrder == 1)
                    {

                        ListBooks = BookModel.OrderBy(o => o.title).ToList<BookModel>();

                    }
                    else if (titleOrder == 2)
                    {
                        ListBooks = BookModel.OrderByDescending(o => o.title).ToList<BookModel>();

                    }
                    else if (authorOrder == 1)
                    {
                        ListBooks = BookModel.OrderBy(o => o.authorName).ToList<BookModel>();
                    }
                    else if (authorOrder == 2)
                    {
                        ListBooks = BookModel.OrderByDescending(o => o.authorName).ToList<BookModel>();
                    }
                    else if (editOrder == 1)
                    {
                        ListBooks = BookModel.OrderBy(o => o.editionYear).ToList<BookModel>();
                    }
                    else if (editOrder == 2)
                    {
                        ListBooks = BookModel.OrderByDescending(o => o.editionYear).ToList<BookModel>();
                    }
                    else
                    {
                        ListBooks = BookModel;
                    }

                    return ListBooks;
                }

                throw new Exception("Orderby Exception");

            }
          
            catch (Exception)
            {

                throw;
            }
          
        }
    }
}
