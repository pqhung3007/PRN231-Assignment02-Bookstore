using BusinessObject.DTO;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eBookStoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly IPublisherRepository _repository;

        public PublishersController(IPublisherRepository repository)
        {
            _repository = repository;
        }
        
        // GET: api/<PublishersController>
        [HttpGet]
        public ActionResult<IEnumerable<PublisherDto>> Get()
        {
            return Ok(_repository.GetAllPublishers());
        }

        // GET api/<PublishersController>/5
        [HttpGet("{id}")]
        public ActionResult<PublisherDto> Get(int publisherId)
        {
            return Ok(_repository.GetPublisherById(publisherId));
        }
        
        // POST api/<PublishersController>
        [HttpPost]
        public IActionResult Post([FromBody] PublisherDto publisherDto)
        {
            _repository.InsertPublisher(publisherDto);
            return Ok();
        }
       

        // PUT api/<PublishersController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromODataUri] int publisherId, [FromBody] PublisherDto publisherDto)
        {
            _repository.UpdatePublisher(publisherId, publisherDto);
            return Ok();
        }

        // DELETE api/<PublishersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.DeletePublisher(id);
            return Ok();
        }
    }
}
