using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.models
{
    public class Post
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public Author Author { get; set; }
    }
}
