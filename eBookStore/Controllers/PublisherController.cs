using eBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace eBookStore.Controllers
{
    public class PublisherController : Controller
    {
        protected string _connectionString = "https://localhost:7058/api/Publishers";
        public async Task<IActionResult> Index()
        {
            List<Publisher> publishers = new List<Publisher>();

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(_connectionString))
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
    }
}
