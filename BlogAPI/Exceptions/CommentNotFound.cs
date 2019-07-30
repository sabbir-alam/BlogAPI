using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Exceptions
{
    public class CommentNotFound : System.Exception
    {
        public CommentNotFound() : base() { }
        public CommentNotFound(string message) : base(message) { }
        public CommentNotFound(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected CommentNotFound(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
