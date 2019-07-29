﻿using BlogAPI.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.repository
{
    public class CommentRepository : ICommentRepository
    {
        private List<Comment> _comments = new List<Comment>();
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
            _comments.Add(comment);
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
            _comments.Add(comment);
        }
        public void DeleteById(int id)
        {
            _comments.Remove(_comments.Find(x => x.Id == id));
            return;

        }

        public IEnumerable<Comment> GetAll()
        {
            return _comments;
        }

        public Comment GetById(int id)
        {
            return _comments.Find(x => x.Id == id);
        }

        public void Save(Comment comment)
        {
            _comments.Add(comment);
        }

        public void Save(int id, Comment comment)
        {
            _comments[_comments.FindIndex(x => x.Id == id)] = comment;
        }
    }
}
