using BusinessObject;
using BusinessObject.DTO;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eBookStoreWebAPI.Controllers
{
    public class BooksController : ODataController
    {
        private readonly IBookRepository _repository;

        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<BooksController>
        [EnableQuery]
        public ActionResult<List<BookDto>> Get()
        {
            return Ok(_repository.GetAllBooks());
        }
    
    }
}
