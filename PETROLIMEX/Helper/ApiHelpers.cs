using RestSharp;
using RestSharp.Authenticators;

namespace PETROLIMEX.Helper
{
    public static class ApiHelpers
    {
        public static string startupPath = "";
        public static int timeOut = 10000;
        public static string tokenHeader = "token";
        public const int max_send_times = 2;

        public static async Task<IRestResponse> GeneralBasicAuthJsonAPI(string apiUrl, string username, string password, object data, Dictionary<string, string> headerValues, Dictionary<string, string> requiredParams, int timeOut, Method method)
        {
            var client = new RestClient(apiUrl);
            client.Authenticator = new HttpBasicAuthenticator(username, password);
            client.Timeout = timeOut;
            var request = new RestRequest(method)
            {
                RequestFormat = DataFormat.Json
            };
            if (data != null)
                request.AddJsonBody(data);

            request.AddHeaders(headerValues);
            foreach (KeyValuePair<string, string> kvp in requiredParams)
            {
                request.AddQueryParameter(kvp.Key, kvp.Value);
            }

            LogHelperv2.Logger_API_Infor("SEND API: " + apiUrl, LogHelperv2.SaveLogFolder, data);
            IRestResponse response = client.Execute(request);
            LogHelperv2.Logger_API_Infor("Receive Response: " + apiUrl + "\r\n: " + response.Content, LogHelperv2.SaveLogFolder);
            return response;
        }

        public static async Task<IRestResponse> GeneralJsonAPI(string apiUrl, object data, Dictionary<string, string> headerValues, Dictionary<string, string> requiredParams, int timeOut, Method method)
        {

            var client = new RestClient(apiUrl);
            client.Timeout = timeOut;
            var request = new RestRequest(method);
            request.RequestFormat = DataFormat.Json;
            if (data != null)
                request.AddJsonBody(data);
            request.AddHeaders(headerValues);
            foreach (KeyValuePair<string, string> kvp in requiredParams)
            {
                request.AddQueryParameter(kvp.Key, kvp.Value);
            }
            LogHelperv2.Logger_API_Infor("SEND API: " + apiUrl, LogHelperv2.SaveLogFolder, data);
            IRestResponse response = client.Execute(request);
            LogHelperv2.Logger_API_Infor("Receive Response: " + apiUrl + "\r\n: " + response.Content, LogHelperv2.SaveLogFolder);
            return response;

        }
        public static async Task<IRestResponse> GeneralJsonAPINotBody(string apiUrl, Dictionary<string, string> headerValues, Dictionary<string, string> requiredParams, int timeOut, Method method)
        {

            var client = new RestClient(apiUrl);

            client.Timeout = timeOut;

            var request = new RestRequest(method);

            request.RequestFormat = DataFormat.Json;

            request.AddHeaders(headerValues);

            foreach (KeyValuePair<string, string> kvp in requiredParams)
            {
                request.AddQueryParameter(kvp.Key, kvp.Value);
            }
            LogHelperv2.Logger_API_Infor("SEND API: " + apiUrl, LogHelperv2.SaveLogFolder);
            IRestResponse response = client.Execute(request);
            LogHelperv2.Logger_API_Infor("Receive Response: " + apiUrl + "\r\n: " + response.Content, LogHelperv2.SaveLogFolder);
            return response;

        }
        public static string GeneralJsonAPI(string apiUrl, string data, Dictionary<string, string> headerValues, Dictionary<string, string> requiredParams, int timeOut, ref string error, Method method)
        {
            var client = new RestClient(apiUrl);
            client.Timeout = timeOut;
            var request = new RestRequest(method);

            if (data != null)
                request.AddParameter("application/json", data, ParameterType.RequestBody);

            request.AddHeaders(headerValues);
            foreach (KeyValuePair<string, string> kvp in requiredParams)
            {
                request.AddQueryParameter(kvp.Key, kvp.Value);
            }
            IRestResponse response = client.Execute(request);
            if (!response.IsSuccessful)
            {
                client = new RestClient(apiUrl);
                client.Timeout = timeOut;
                request = new RestRequest(method);
                request.RequestFormat = DataFormat.Json;
                if (data != null)
                    request.AddParameter("application/json", data, ParameterType.RequestBody);
                request.AddHeaders(headerValues);
                foreach (KeyValuePair<string, string> kvp in requiredParams)
                {
                    request.AddQueryParameter(kvp.Key, kvp.Value);
                }
                response = client.Execute(request);
                if (!response.IsSuccessful)
                {
                    error = apiUrl + ":" + response.ErrorMessage;
                    return string.Empty;
                }
            }
            return response.Content;
        }
    }
}
