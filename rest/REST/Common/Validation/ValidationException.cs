namespace REST.Common.Validation
{
    using System;
    using System.Collections.Generic;

    public class ValidationException : Exception
    {
        public IList<string> Errors { get; private set; }
        public ValidationException(IList<string>errors):base()
        {
            this.Errors = errors;
        }

    }
}