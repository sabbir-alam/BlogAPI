using BlogAPI.models;
using BlogAPI.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.BusinessLogic
{
    public interface IPostManager
    {
        IEnumerable<Post> GetAll();
        Post GetById(int id);
        void DeleteById(int id);
        bool Validate(Post post);
        void Save(Post post);
        //void Save(int id,Post post);
        List<String> GetTitles();
        IEnumerable<Comment> GetComments(int id);
    }
}
