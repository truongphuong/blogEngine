using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Diagnostics;
using BlogEngine.GettyImagesClient.Domain;

namespace BlogEngine.GettyImagesClient.Services
{
    public class ReNewSession
    {
        public string GetToken(string secureToken)
        {
            return RenewSecureToken(secureToken).RenewSessionResult.Token;
        }

        public string GetSecureToken(string secureToken)
        {
            return RenewSecureToken(secureToken).RenewSessionResult.SecureToken;
        }

        // token received from CreateSession API call
        public RenewSessionResponse RenewSecureToken(string secureToken)
        {
            
            var sessionToken = new RenewSessionRequestBody
            {
                SystemId = Constants.SystemId,
                SystemPassword = Constants.SystemPassword,
            };

            var renewSessionRequest = new RenewSessionRequest
            {
                RequestHeader = new RequestHeader { Token = secureToken },
                RenewSessionRequestBody = sessionToken
            };

            return MakeWebRequest(Constants.ReNewSessionRequestUrl, renewSessionRequest);
        }

        //You may wish to replace this code with your preferred library for posting and receiving JSON data.
        private static RenewSessionResponse MakeWebRequest(string requestUrl, RenewSessionRequest request)
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

            return jsonSerializer.Deserialize<RenewSessionResponse>(jsonResult);
        }
    }
}
