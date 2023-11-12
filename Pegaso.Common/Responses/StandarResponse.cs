using System.Net;

namespace Pegaso.Common.Responses
{
    public class StandardResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }

        public bool IsSuccessStatusCode
        {
            get
            {
                if (StatusCode >= HttpStatusCode.OK)
                {
                    return StatusCode <= HttpStatusCode.IMUsed;
                }
                return false;
            }
        }
        public StandardResponse()
        {

        }
        public StandardResponse(HttpStatusCode statusCode, T data = default(T), string message = "")
        {
            Data = data;
            StatusCode = statusCode;
            Message = message;
        }
    }
}
