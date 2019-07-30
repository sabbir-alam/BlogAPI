using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Exceptions
{
    [Serializable()]
    public class PostNotFound : System.Exception
    {
        public PostNotFound() : base() { }
        public PostNotFound(string message) : base(message) { }
        public PostNotFound(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected PostNotFound(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
