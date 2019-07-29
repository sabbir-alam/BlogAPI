using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.models;

namespace BlogAPI.repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private List<Author> _authors = new List<Author>();
        public AuthorRepository()
        {
            Author author = new Author
            {
                Name = "ragib",
                Id = 1,
                Email = "ragib22@gmail.com"
            };
            _authors.Add(author);
            _authors.Add(author);
            _authors.Add(author);
            _authors.Add(author);

        }

        public void DeleteById(int id)
        {
            _authors.Remove(_authors.Find(x => x.Id == id));
        }

        public IEnumerable<Author> GetAll()
        {
            return _authors;
        }

        
        public Author GetById(int id)
        {
            return _authors.Find(x => x.Id==id);
        }

        public void Save(Author author)
        {
            if (!_authors.Exists(x => x.Id== author.Id)) // create
            {
                author.Id = _authors.Max(x => x.Id) + 1;
                _authors.Add(author);
            }
            else // update
            {
                _authors[_authors.FindIndex(x => x.Id == author.Id)] = author;
            }
        }
    }
}
