using System;

namespace MapService.CommandObjects
{
    public class ServiceProcessorWrapper
    {
        public static TResponse Wrap<TResponse>(Func<TResponse> function) where TResponse : BaseResponse, new()
        {
            TResponse response;
            try
            {
                response = function.Invoke();
            }
            catch(Exception e)
            {
                return new TResponse()
                {
                    Success = false,
                    ErrorMessage = e.Message,
                    StackTrace = e.StackTrace
                };
            }
            
            return response;
        }
    }
}
