using eBookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace eBookStore.Controllers
{
	public class AuthorController : Controller
	{
		protected string _connectionString = "https://localhost:7058/api/Authors";
		// GET: AuthorController
		public async Task<ActionResult> Index()
		{
			List<Author> authors = new List<Author>();

			using (HttpClient client = new HttpClient())
			{
				using (HttpResponseMessage res = await client.GetAsync(_connectionString))
				{
					using (HttpContent content = res.Content)
					{
						string data = await content.ReadAsStringAsync();
						// deserialize data
						authors = JsonSerializer.Deserialize<List<Author>>(data);
					}
				}
			}
			ViewBag.ListAuthor = authors;

			return View();
		}

		// GET: AuthorController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: AuthorController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: AuthorController/Create
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

		// GET: AuthorController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: AuthorController/Edit/5
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

		// GET: AuthorController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: AuthorController/Delete/5
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
