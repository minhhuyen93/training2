using System;

namespace TinyERP.Common.Common.Exceptions
{
    public class UnSupportException : Exception
    {
        public UnSupportException(string message) : base(message) { }
    }
}
