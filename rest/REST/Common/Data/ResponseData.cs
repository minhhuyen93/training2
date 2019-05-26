namespace REST.Common.Data
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    public class ResponseData
    {
        public object Data { get; set; }
        public HttpStatusCode Status { get; set; }
        public IList<string> Errors { get; set; }

        public ResponseData()
        {
            this.Status = HttpStatusCode.OK;
            this.Errors = new List<string>();
        }
        internal void SetData(object data)
        {
            this.Status = HttpStatusCode.OK;    
            this.Data = data;
        }

        internal void SetErrors(IList<string> errors)
        {
            this.Status = HttpStatusCode.BadRequest;
            this.Errors = errors;
        }
    }
}