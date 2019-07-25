using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.models;

namespace BlogAPI.repository
{
    public class PostRepositoryWithMemory : IPostRepository
    {
        private List<Post> posts = new List<Post>();
        private int _lastId = 5;
        public PostRepositoryWithMemory()
        {
            Author author = new Author
            {
                Id = 1,
                Name = "sabbir",
                Email = "sabbir@sabbir.com"
            };

            Post post = new Post
            {
                Body = "dsdc",
                Title = "dsdc",
                Author = author,
                Id = 1,
                CreatedAt = DateTime.Now
            };

            Console.WriteLine(post.Id);
            
            posts.Add(post);
            post = new Post
            {
                Body = "dsdc",
                Title = "dsdc",
                Author = author,
                Id = 2,
                CreatedAt = DateTime.Now
            };
            posts.Add(post);
            post = new Post
            {
                Body = "dsdc",
                Title = "dsdc",
                Author = author,
                Id = 3,
                CreatedAt = DateTime.Now
            };
            posts.Add(post);
            post = new Post
            {
                Body = "dsdc",
                Title = "dsdc",
                Author = author,
                Id = 4,
                CreatedAt = DateTime.Now
            };
            posts.Add(post);
            post = new Post
            {
                Body = "dsdc",
                Title = "dsdc",
                Author = author,
                Id = 5,
                CreatedAt = DateTime.Now
            };
            posts.Add(post);
            

        }

        public void DeleteById(int id)
        {
            posts.Remove(posts.Find(x => x.Id == id));
            return;
           
        }

        public IEnumerable<Post> GetAll()
        {
            return posts;
        }

        public Post GetById(int id)
        {
            //posts.Single
            return posts.Find(x => x.Id == id);
        }

        public void Save(Post post)
        {
            if (!posts.Exists(x => x.Id==post.Id)) // create
            {
                post.Id = posts.Max(x=> x.Id) + 1;
                posts.Add(post);
            }
            else // update
            {
                posts[posts.FindIndex(x => x.Id == post.Id)] = post;
            }
        }
        //public void Save(int id, Post post)
        //{
        //    posts[posts.FindIndex(x => x.Id == id)] = post;
        //}
    }
}
