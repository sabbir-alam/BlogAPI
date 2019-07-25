using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.models
{
    public class Comment
    {
        public int Id { get; set; }
        public Author Author { get; set; }
        public Post Post { get; set; }
        public String Body { get; set; }
        public DateTime CreatedAt { get; set; }
        
    }
}
