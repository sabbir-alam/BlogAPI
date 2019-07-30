using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.models;

namespace BlogAPI.repository
{
    public class PostRepositoryWithLocalDB : IPostRepository
    {
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

       

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Post post)
        {
            throw new NotImplementedException();
        }

        //public void Save(int id, Post post)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
