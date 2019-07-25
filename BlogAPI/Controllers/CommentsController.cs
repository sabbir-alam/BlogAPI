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
    public class CommentsController : ControllerBase
    {
        private ICommentManager _commentManager;
        public CommentsController(ICommentManager commentManager)
        {
            _commentManager = commentManager;
        }
        // GET: api/Comments
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return _commentManager.GetAll();
        }

        // GET: api/Comments/5
        [HttpGet("{id}", Name = "GetComment")]
        public Comment Get(int id)
        {
            return _commentManager.GetById(id);
        }

        // POST: api/Comments
        [HttpPost]
        public void Post([FromBody] Comment comment)
        {
            if (_commentManager.Validate(comment))
                _commentManager.Save(comment);

        }

        // PUT: api/Comments/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Comment comment)
        {
            _commentManager.Validate(comment);
            _commentManager.Save(id, comment);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _commentManager.DeleteById(id);
        }
    }
}
