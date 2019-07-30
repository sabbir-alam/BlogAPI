using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.models;
using BlogAPI.repository;

namespace BlogAPI.BusinessLogic
{
    public class AuthorManager : IAuthorManager
    {
        private IAuthorRepository _authorRepository;
        private IPostRepository _postRepository;
        private ICommentRepository _commentRepository;
        public AuthorManager(IAuthorRepository authorRepository, IPostRepository postRepository, ICommentRepository commentRepository)
        {
            _authorRepository = authorRepository;
            _postRepository = postRepository;
            _commentRepository = commentRepository;
        }
        public void DeleteById(int id)
        {
            _authorRepository.DeleteById(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public IEnumerable<Comment> GetComments(int id)
        {
            Author author = GetById(id);
            return _commentRepository.GetAll().Where(x => x.AuthorId == author.Id);
        }

        public IEnumerable<Post> GetPosts(int id)
        {
            Author author = GetById(id);
            return _postRepository.GetAll().Where(x=> x.AuthorId==author.Id);
            
        }

        public void Save(Author author)
        {
            _authorRepository.Save(author);
        }

        public bool Validate(Author author)
        {
            return true;
        }
    }
}
