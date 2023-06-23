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
            _connectionString = "https://localhost:7058/odata/Authors";

            HttpResponseMessage response = await _client.GetAsync(_connectionString);
            string strData = await response.Content.ReadAsStringAsync();
            List<Author> listAuthors = JsonSerializer.Deserialize<List<Author>>(strData);

            return View(listAuthors);
        }

        public async Task<ActionResult> CreateAuthor(string firstName, string lastName, string emailAddress, string city)
		{
            _connectionString = "https://localhost:7058/odata/Authors";
			
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

		// GET: AuthorController/Edit/5
		public async Task<IActionResult> Edit(int id)
		{
            _connectionString = "https://localhost:7058/odata/Authors/" + id.ToString();
            HttpResponseMessage response = await _client.GetAsync(_connectionString);
            string strData = await response.Content.ReadAsStringAsync();
            
            Author author = JsonSerializer.Deserialize<Author>(strData);
            ViewBag.Author = author;

            return View();
		}
        
        [HttpPost]
        public async Task<IActionResult> Edit(Author author)
		{
            _connectionString = "https://localhost:7058/odata/Authors/" + author.AuthorId;
            string json = JsonSerializer.Serialize(author);
           
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PutAsync(_connectionString, content);
            
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
		{
            _connectionString = "https://localhost:7058/odata/Authors/" + id.ToString();
            HttpResponseMessage response = await _client.DeleteAsync(_connectionString);
            
            return RedirectToAction("Index");
		}
	}
}
