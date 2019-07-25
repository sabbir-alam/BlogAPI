using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.models;

namespace BlogAPI.repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private List<Author> authors = new List<Author>();
        public AuthorRepository()
        {
            Author author = new Author
            {
                Name = "ragib",
                Id = 1,
                Email = "ragib22@gmail.com"
            };
            authors.Add(author);
            authors.Add(author);
            authors.Add(author);
            authors.Add(author);

        }

        public void DeleteById(int id)
        {
            authors.Remove(authors.Find(x => x.Id == id));
        }

        public IEnumerable<Author> GetAll()
        {
            return authors;
        }

        
        public Author GetById(int id)
        {
            return authors.Find(x => x.Id==id);
        }

        public void Save(Author author)
        {
            if (!authors.Exists(x => x.Id== author.Id)) // create
            {
                author.Id = authors.Max(x => x.Id) + 1;
                authors.Add(author);
            }
            else // update
            {
                authors[authors.FindIndex(x => x.Id == author.Id)] = author;
            }
        }
    }
}
