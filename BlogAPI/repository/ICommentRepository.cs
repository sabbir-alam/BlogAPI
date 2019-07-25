using BlogAPI.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.repository
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAll();
        Comment GetById(int id);
        void DeleteById(int id);
        void Save(Comment comment);
        void Save(int id, Comment comment);
    }
}
