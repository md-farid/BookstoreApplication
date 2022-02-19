using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController: Controller
    {
        public string GetAllBooks()
        {
            return "All Books";
        }
        public string GetBookId(int id)
        {
            return $"Book Id: {id}";
        }
        public string SearchBooks(string name, string author)
        {
            return $"Book name: {name} & author: {author}";
        }
    }
}