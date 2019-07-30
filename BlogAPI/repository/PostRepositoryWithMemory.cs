using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.models;

namespace BlogAPI.repository
{
    public class PostRepositoryWithMemory : IPostRepository
    {
        private List<Post> _posts = new List<Post>();
        private int _lastId = 5;
        public PostRepositoryWithMemory()
        {
            

            Post post = new Post
            {
                Body = "dsdc",
                Title = "dsdc",
                AuthorId = 1,
                Id = 1,
                CreatedAt = DateTime.Now
            };

            Console.WriteLine(post.Id);
            
            _posts.Add(post);
            post = new Post
            {
                Body = "dsdc",
                Title = "dsdc",
                AuthorId = 1,
                Id = 2,
                CreatedAt = DateTime.Now
            };
            _posts.Add(post);
            post = new Post
            {
                Body = "dsdc",
                Title = "dsdc",
                AuthorId = 1,
                Id = 3,
                CreatedAt = DateTime.Now
            };
            _posts.Add(post);
            post = new Post
            {
                Body = "dsdc",
                Title = "dsdc",
                AuthorId = 1,
                Id = 4,
                CreatedAt = DateTime.Now
            };
            _posts.Add(post);
            post = new Post
            {
                Body = "dsdc",
                Title = "dsdc",
                AuthorId = 1,
                Id = 5,
                CreatedAt = DateTime.Now
            };
            _posts.Add(post);
            

        }

        public void DeleteById(int id)
        {
            _posts.Remove(_posts.Find(x => x.Id == id));
            return;
           
        }

        public bool Exists(int id)
        {
            return _posts.Exists(x => x.Id == id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _posts;
        }

        public Post GetById(int id)
        {
            //posts.Single
            return _posts.Find(x => x.Id == id);
        }

        public void Save(Post post)
        {
            if (!_posts.Exists(x => x.Id==post.Id)) // create
            {
                post.Id = _posts.Max(x=> x.Id) + 1;
                _posts.Add(post);
            }
            else // update
            {
                _posts[_posts.FindIndex(x => x.Id == post.Id)] = post;
            }
        }
        //public void Save(int id, Post post)
        //{
        //    posts[posts.FindIndex(x => x.Id == id)] = post;
        //}
    }
}
