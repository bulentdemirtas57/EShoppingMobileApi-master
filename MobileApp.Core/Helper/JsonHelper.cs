using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MobileApp.Core.Helper
{
    public static class JsonHelper
    {
        public static bool ValidateJSON(this string s)
        {
            var response = false;

            try
            {
                JToken.Parse(s);
                response = true;
            }
            catch
            {
                response = false;
            }

            return response;
        }
    }
}
