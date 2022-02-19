using System.Linq;
using System.Collections.Generic;
using BookStore.Models;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(book => book.Id==id).FirstOrDefault();
        }
        public List<BookModel> SearchBooks(string name,string author)
        {
            return DataSource().Where(book => book.Name.Contains(name) || book.Author.Contains(author)).ToList();
        }
        private List<BookModel> DataSource()
        {
            List<BookModel> books = new List<BookModel>()
            {
                new BookModel(){Id=1,Name="Harry porter",Author="Imran Hossain"},
                new BookModel(){Id=2,Name="Dirlis Artugul",Author="Faridur Jaman"},
                new BookModel(){Id=3,Name="Kurulus Osman",Author="Saddam Hossain"}
            };
            return books;
        }
    }
}