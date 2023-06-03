namespace EStoreNet.API.Errors
{
    public class ApiExcepiton : ApiResponse
    {
        public ApiExcepiton(int statusCode, string message = null, string details = null) : base(statusCode, message)
        {
            Details = details;
        }

        public string Details { get; set; }
    }
}
