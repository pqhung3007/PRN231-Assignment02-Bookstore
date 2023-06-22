using BusinessObject;
using BusinessObject.DTO;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eBookStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _repository;

        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<BooksController>
        [HttpGet]
        public ActionResult<List<BookDto>> Get()
        {
            return Ok(_repository.GetAllBooks());
        }
    
    }
}
