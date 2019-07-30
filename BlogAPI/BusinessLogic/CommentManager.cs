using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.Exceptions;
using BlogAPI.models;
using BlogAPI.repository;

namespace BlogAPI.BusinessLogic
{
    public class CommentManager : ICommentManager
    {
        private ICommentRepository _commentRepository;
        private IPostRepository _postRepository;
        private IAuthorRepository _authorRepository;
        public CommentManager(ICommentRepository commentRepository,IPostRepository postRepository,IAuthorRepository authorRepository)
        {
            _commentRepository = commentRepository;
            _postRepository = postRepository;
            _authorRepository = authorRepository;
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
            if (_postRepository.Exists(comment.PostId))
            {
                if (_authorRepository.Exists(comment.AuthorId))
                {
                    _commentRepository.Save(comment);
                }
                else
                {
                    throw new AuthorNotFound();
                }
            }
            else throw new PostNotFound();
        }

        public void Save(int id, Comment comment)
        {
            if (_commentRepository.Exists(id))
                _commentRepository.Save(id, comment);
            else throw new CommentNotFound();
        }

        public bool Validate(Comment comment)
        {
            return true;
        }
    }
}
