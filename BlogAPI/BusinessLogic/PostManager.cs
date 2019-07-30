using BlogAPI.Exceptions;
using BlogAPI.models;
using BlogAPI.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.BusinessLogic
{
    public class PostManager : IPostManager
    {
        private IPostRepository _postRepository;
        private ICommentRepository _commentRepository;
        private IAuthorRepository _authorRepository;
        public PostManager(IPostRepository postRepository, ICommentRepository commentRepository, IAuthorRepository authorRepository)
        {
            _commentRepository = commentRepository;
            _postRepository = postRepository;
            _authorRepository = authorRepository;
        }

        public void DeleteById(int id)
        {
            _postRepository.DeleteById(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll();
            
        }

        public Post GetById(int id)
        {
            return _postRepository.GetById(id);
        }

        public void Save(Post post)
        {
            if (_authorRepository.Exists(post.AuthorId))
                _postRepository.Save(post);
            else throw new AuthorNotFound();
        }

        //public void Save(int id, Post post)
        //{
        //    _postRepository.Save(id, post);
        //}

        public bool Validate(Post post)
        {
            return true;
        }
        public List<String> GetTitles()
        {
            List<String> titles = new List<string>();
            IEnumerable<Post> posts = _postRepository.GetAll();
            foreach(Post post in posts)
            {
                titles.Add(post.Title);
            }
            return titles;
        }

        public IEnumerable<Comment> GetComments(int id)
        {
            Post post = GetById(id);
            return _commentRepository.GetAll().Where(x => x.PostId == post.Id);
        }
    }
}
