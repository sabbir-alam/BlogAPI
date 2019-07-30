using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.BusinessLogic;
using BlogAPI.Exceptions;
using BlogAPI.models;
using BlogAPI.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private IPostManager _postManager;
        public PostsController(IPostManager postManager)
        {
            _postManager = postManager;
        }
        // GET: api/Posts
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _postManager.GetAll();
        }

        // GET: api/Posts/5
        [HttpGet("{id}", Name = "GetPost")]
        public Post Get(int id)
        {
            return _postManager.GetById(id);
        }

        // POST: api/Posts
        [HttpPost]
        public IActionResult Post([FromBody] Post post)
        {
            try
            {
                if (_postManager.Validate(post))
                {
                    _postManager.Save(post);
                }
                return Ok();
                    
            }
            catch (AuthorNotFound e)
            {
                return BadRequest(e.Data);
            }
            

        }

        // PUT: api/Posts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Post post)
        {
            _postManager.Validate(post);
            _postManager.Save(post);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _postManager.DeleteById(id);
        }

        [HttpGet("titles")]
        public IActionResult GetTitles()
        {
            return Ok(_postManager.GetTitles());
        }
        [HttpGet("{id}/comments")]
        public IActionResult GetComments(int id)
        {
            return Ok(_postManager.GetComments(id));
        }

    }
}
