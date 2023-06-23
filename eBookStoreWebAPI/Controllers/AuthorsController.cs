using BusinessObject;
using BusinessObject.DTO;
using DataAccess;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eBookStoreWebAPI.Controllers
{

    public class AuthorsController : ODataController
    {
        private readonly IAuthorRepository _repository;

        public AuthorsController(IAuthorRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<AuthorsController>
        [EnableQuery]
        public ActionResult Get()
        {
            return Ok(_repository.GetAllAuthors());
        }

        // GET api/<AuthorsController>/5
        [EnableQuery]
        public IActionResult Get(int key)
        {
            return Ok(_repository.GetAuthorById(key));
        }

        // POST api/<AuthorsController>
        [EnableQuery]
        public IActionResult Post([FromBody]AuthorDto author)
        {
            _repository.InsertAuthor(author);
            return Ok();
        }
       

        // PUT api/<AuthorsController>/5
        [EnableQuery]
        public IActionResult Put(int key, [FromBody] AuthorDto author)
        {
            _repository.UpdateAuthor(author, key);
            return Ok();
        }

        // DELETE api/<AuthorsController>/5
        [EnableQuery]
        public IActionResult Delete(int key)
        {
            _repository.DeleteAuthor(key);
            return Ok();
        }
    }
}
