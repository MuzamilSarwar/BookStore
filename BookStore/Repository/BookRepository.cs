using BookStore.Models;
using Microsoft.AspNetCore.SignalR;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return dataSource();
        }
        public BookModel GetBookByID(int id)
        {
            return dataSource().FirstOrDefault(x => x.Id == id);
        }
        public List<BookModel> SearchBook(string bookName, string author)
        {
            return dataSource().Where( x => x.Title.Contains(bookName) && x.Author.Contains(author)).ToList();
        }

        private List<BookModel> dataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "C#", Author = "Muzamil" },
                new BookModel() { Id = 2, Title = "MVC", Author = "Web Gental" },
                new BookModel() { Id = 3, Title = "Angular", Author = "venkat" },
                new BookModel() { Id = 4, Title = "MVc5", Author = "Ashish" },
                new BookModel() { Id = 5, Title = "C# 11", Author = "sir Wassem" }
            };
        }
    }
}
