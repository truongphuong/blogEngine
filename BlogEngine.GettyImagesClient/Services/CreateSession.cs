using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Diagnostics;
using BlogEngine.GettyImagesClient.Domain;

namespace BlogEngine.GettyImagesClient.Services
{
    public class CreateSession
    {
        public string GetToken()
        {
            return GetCreateSessionResponse().CreateSessionResult.Token;
        }

        public string GetSecureToken()
        {
            return GetCreateSessionResponse().CreateSessionResult.SecureToken;
        }

        public CreateSessionTokenResponse GetCreateSessionResponse()
        {

            var createSessionRequestBody = new CreateSessionRequestBody
            {
                SystemId = Constants.SystemId,
                SystemPassword = Constants.SystemPassword,
                UserName = Constants.UserName,
                UserPassword = Constants.UserPassword,
            };

            var createSessionTokenRequest = new CreateSessionTokenRequest
            {
                RequestHeader = new RequestHeader(),
                CreateSessionRequestBody = createSessionRequestBody
            };

            return MakeWebRequest(Constants.CreateSessionRequestUrl, createSessionTokenRequest);
        }

        //You may wish to replace this code with your preferred library for posting and receiving JSON data.
        private static CreateSessionTokenResponse MakeWebRequest(string requestUrl, CreateSessionTokenRequest request)
        {
            var webRequest = WebRequest.Create(requestUrl) as HttpWebRequest;

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            var jsonSerializer = new JavaScriptSerializer();
            var requestStr = jsonSerializer.Serialize(request);

            Debug.WriteLine(requestStr);

            using (var writer = new StreamWriter(webRequest.GetRequestStream()))
            {
                writer.Write(requestStr);
                writer.Close();
            }

            var response = webRequest.GetResponse() as HttpWebResponse;

            string jsonResult;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                jsonResult = reader.ReadToEnd();
                reader.Close();
            }

            Debug.WriteLine(jsonResult);

            return jsonSerializer.Deserialize<CreateSessionTokenResponse>(jsonResult);
        }

    }
}
