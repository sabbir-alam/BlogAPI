using BlogAPI.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.repository
{
    public class CommentRepository : ICommentRepository
    {
        List<Comment> comments = new List<Comment>();
        public CommentRepository()
        {
            Comment comment = new Comment
            {
                Id = 1,
                Author = new Author
                {
                    Id = 1,
                    Name = "sabbir",
                    Email = "sabbir@sabbir.com",

                },
                Post = new Post
                {

                },
                Body = "This is a comment",
                CreatedAt = DateTime.Now
            };
            comments.Add(comment);
            comment = new Comment
            {
                Id = 2,
                Author = new Author
                {
                    Id = 1,
                    Name = "sabbir",
                    Email = "sabbir@sabbir.com",

                },
                Post = new Post
                {

                },
                Body = "This is a comment",
                CreatedAt = DateTime.Now
            };
            comments.Add(comment);
        }
        public void DeleteById(int id)
        {
            comments.Remove(comments.Find(x => x.Id == id));
            return;

        }

        public IEnumerable<Comment> GetAll()
        {
            return comments;
        }

        public Comment GetById(int id)
        {
            return comments.Find(x => x.Id == id);
        }

        public void Save(Comment comment)
        {
            comments.Add(comment);
        }

        public void Save(int id, Comment comment)
        {
            comments[comments.FindIndex(x => x.Id == id)] = comment;
        }
    }
}
