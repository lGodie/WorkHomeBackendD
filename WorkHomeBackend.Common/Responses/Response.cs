using System;
using System.Collections.Generic;
using System.Text;

namespace WorkHomeBackend.Common.Responses
{
    public class Response <T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
