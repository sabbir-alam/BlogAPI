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
        public PostManager(IPostRepository postRepository, ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
            _postRepository = postRepository;
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
            _postRepository.Save(post);
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
            return _commentRepository.GetAll().Where(x => x.Post.Id == post.Id);
        }
    }
}
