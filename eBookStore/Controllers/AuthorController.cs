using eBookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace eBookStore.Controllers
{
	public class AuthorController : Controller
	{
		private readonly HttpClient _client;
		private string _connectionString = "";

        public AuthorController()
        {
            _client = new HttpClient();
        }
		
        // GET: AuthorController
        public async Task<IActionResult> Index()
        {
            _connectionString = "https://localhost:7058/api/Authors";

            HttpResponseMessage response = await _client.GetAsync(_connectionString);
            string strData = await response.Content.ReadAsStringAsync();
            List<Author> listAuthors = JsonSerializer.Deserialize<List<Author>>(strData);

            return View(listAuthors);
        }

        public async Task<ActionResult> CreateAuthor(string firstName, string lastName, string emailAddress, string city)
		{
            _connectionString = "https://localhost:7058/api/Authors";
			
            var request = new Author
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                City = city
            };
			
            string json = JsonSerializer.Serialize(request);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(_connectionString, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["Error"] = "Error adding author";
            }

            return RedirectToAction("Index");
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
