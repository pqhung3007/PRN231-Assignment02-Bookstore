using BusinessObject;
using BusinessObject.DTO;
using DataAccess;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Routing.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eBookStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ODataController
    {
        private readonly IAuthorRepository _repository;

        public AuthorsController(IAuthorRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<AuthorsController>
        [HttpGet]
        public ActionResult<IEnumerable<AuthorDto>> Get()
        {
            return Ok(_repository.GetAllAuthors());
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok();
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public IActionResult Post([FromBody]AuthorDto author)
        {
            _repository.InsertAuthor(author);
            return Ok();
        }
       

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public void Put([FromODataUri]int authorId, [FromBody] AuthorDto author)
        {
            _repository.UpdateAuthor(author, authorId);
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
