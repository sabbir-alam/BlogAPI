using BlogAPI.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.repository
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetAll();
        Post GetById(int id);
        void DeleteById(int id);
        void Save(Post post);
        //void Save(int id, Post post);
        bool Exists(int id);

    }
}
