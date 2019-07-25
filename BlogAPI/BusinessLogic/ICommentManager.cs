using BlogAPI.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.BusinessLogic
{
    public interface ICommentManager
    {
        IEnumerable<Comment> GetAll();
        Comment GetById(int id);
        void DeleteById(int id);
        bool Validate(Comment post);
        void Save(Comment post);
        void Save(int id, Comment post);

    }
}
