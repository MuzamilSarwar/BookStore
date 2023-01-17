using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
	public class BookController : Controller
	{
		private readonly BookRepository repository;
		public BookController()
		{
			repository = new BookRepository();
		}
		public IActionResult GetAllBooks()
		{
			var data = repository.GetAllBooks();
			return View(data);

		}
		public BookModel GetBook(int id)
		{
			return repository.GetBookByID(id);
		}
		public List<BookModel> SearchBooks(string BookName, string autherName)
		{
			return repository.SearchBook(BookName, autherName);
		}
	}
}
