using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.models;
using BlogAPI.repository;

namespace BlogAPI.BusinessLogic
{
    public class CommentManager : ICommentManager
    {
        private ICommentRepository _commentRepository;
        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public void DeleteById(int id)
        {
            _commentRepository.DeleteById(id);
        }

        public IEnumerable<Comment> GetAll()
        {
            return _commentRepository.GetAll();

        }

        public Comment GetById(int id)
        {
            return _commentRepository.GetById(id);
        }

        public void Save(Comment comment)
        {
            _commentRepository.Save(comment);
        }

        public void Save(int id, Comment comment)
        {
            _commentRepository.Save(id, comment);
        }

        public bool Validate(Comment comment)
        {
            return true;
        }
    }
}
