using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.BusinessLogic;
using BlogAPI.models;
using BlogAPI.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private IAuthorManager _authorManager;
        public AuthorsController(IAuthorManager authorManager)
        {
            _authorManager = authorManager;
        }

        // GET: api/Authors
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return _authorManager.GetAll();
        }

        // GET: api/Authors/5
        [HttpGet("{id}", Name = "GetAuthor")]
        public Author Get(int id)
        {
            return _authorManager.GetById(id);
        }

        // POST: api/Authors
        [HttpPost]
        public void Post([FromBody] Author author)
        {
            _authorManager.Save(author);
        }

        // PUT: api/Authors/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Author author)
        {
            _authorManager.Save(author);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _authorManager.DeleteById(id);
        }
        [HttpGet("{id}/posts")]
        public IActionResult GetPosts(int id)
        {
            return Ok(_authorManager.GetPosts(id));
        }
        [HttpGet("{id}/comments")]
        public IActionResult GetComments(int id)
        {
            return Ok(_authorManager.GetComments(id));
        }
    }
}
