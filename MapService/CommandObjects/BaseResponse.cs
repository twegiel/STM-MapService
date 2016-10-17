namespace MapService.CommandObjects
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }

        public BaseResponse()
        {
            Success = true;
        }
    }
}
