using BlogAPI.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.BusinessLogic
{
    public interface IAuthorManager
    {
        IEnumerable<Author> GetAll();
        Author GetById(int id);
        void DeleteById(int id);
        bool Validate(Author post);
        void Save(Author author);
        IEnumerable<Post> GetPosts(int id);
        IEnumerable<Comment> GetComments(int id);
    }
}

