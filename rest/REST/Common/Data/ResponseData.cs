
namespace REST.Common.Data
{
    public class ResponseData
    {
        public object Data { get; set; }
        public HttpStatusCode Status { get; set; }
        public IList<string> Errors { get; set; }

    }
}