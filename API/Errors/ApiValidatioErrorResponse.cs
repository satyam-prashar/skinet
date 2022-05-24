namespace API.Errors
{
    public class ApiValidatioErrorResponse : ApiResponse
    {
        public ApiValidatioErrorResponse() : base(400)
        {
        }

        public IEnumerable<string> Errors { get; set; }
    }
}