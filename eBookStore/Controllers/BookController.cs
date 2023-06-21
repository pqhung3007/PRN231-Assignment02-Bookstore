using eBookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace eBookStore.Controllers
{
	public class BookController : Controller
	{
        protected string _connectionString = "https://localhost:7058/api/Books";
		   protected string _connectionString2 = "https://localhost:7058/api/Publishers";
		
        // GET: BooksController
        public async Task<ActionResult> Index()
		{
            List<Book> books = new List<Book>();

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(_connectionString))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        books = JsonSerializer.Deserialize<List<Book>>(data);
                    }
                }
            }
            ViewBag.ListBook = books;

            List<Publisher> publishers = new List<Publisher>();

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(_connectionString2))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        publishers = JsonSerializer.Deserialize<List<Publisher>>(data);
                    }
                }
            }
            ViewBag.ListPublisher = publishers;

            return View();
        }

		// GET: BooksController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: BooksController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: BooksController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: BooksController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: BooksController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: BooksController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: BooksController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
