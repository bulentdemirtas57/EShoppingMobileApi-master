using System.Net;
using System.Runtime.Serialization;

namespace MobileApp.Core
{
    [DataContract]
    public class CommonApiResponse
    {
        public static CommonApiResponse Create(HttpStatusCode statusCode, object result = null, string errorMessage = null, string errorCode = null)
        {
            return new CommonApiResponse(statusCode, result, errorMessage, errorCode);
        }

        [DataMember]
        public string Version => "1.0";

        [DataMember(EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }
        
        [DataMember]
        public HttpStatusCode StatusCode { get; set; }

        [DataMember]
        public object Result { get; set; }

        protected CommonApiResponse(HttpStatusCode statusCode, object result = null, string errorMessage = null, string errorCode = null)
        {
            Result = result;
            ErrorMessage = errorMessage;
            StatusCode = statusCode;
        }
    }
}
