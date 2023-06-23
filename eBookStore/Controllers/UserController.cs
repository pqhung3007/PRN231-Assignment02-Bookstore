using eBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace eBookStore.Controllers
{
    public class UserController : Controller
    {
        private readonly HttpClient _client;
        private string _connectionString = "";

        public UserController()
        {
            _client = new HttpClient();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            _connectionString = "https://localhost:7058/Users/Login";

            FormData formData = new FormData
            {
                Email = email,
                Password = password
            };

            string json = JsonSerializer.Serialize(formData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(_connectionString, content);

            if (response.IsSuccessStatusCode)
            {
                return Redirect("/Home/Index");
            }
            else
            {
                ViewData["error"] = "Cannot log in";
                return View();
            }
        }
    }
}
