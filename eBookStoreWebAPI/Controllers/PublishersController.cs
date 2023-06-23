using BusinessObject.DTO;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eBookStoreWebAPI.Controllers
{

    public class PublishersController : ODataController
    {
        private readonly IPublisherRepository _repository;

        public PublishersController(IPublisherRepository repository)
        {
            _repository = repository;
        }
        
        // GET: api/<PublishersController>
        [EnableQuery]
        public ActionResult<IEnumerable<PublisherDto>> Get()
        {
            return Ok(_repository.GetAllPublishers().AsQueryable());
        }

        // GET api/<PublishersController>/5
        [EnableQuery]
        public ActionResult<PublisherDto> Get(int key)
        {
            return Ok(_repository.GetPublisherById(key));
        }

        // POST api/<PublishersController>
        [EnableQuery]
        public IActionResult Post([FromBody] PublisherDto publisherDto)
        {
            _repository.InsertPublisher(publisherDto);
            return Ok();
        }


        // PUT api/<PublishersController>/5
        [EnableQuery]
        public IActionResult Put(int key, [FromBody] PublisherDto publisherDto)
        {
            _repository.UpdatePublisher(key, publisherDto);
            return Ok();
        }

        // DELETE api/<PublishersController>/5
        [EnableQuery]
        public IActionResult Delete(int key)
        {
            _repository.DeletePublisher(key);
            return Ok();
        }
    }
}
