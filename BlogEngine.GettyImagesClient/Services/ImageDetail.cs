using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Diagnostics;
using BlogEngine.GettyImagesClient.Domain;
using System.Collections.Generic;

namespace BlogEngine.GettyImagesClient.Services
{
    public class ImageDetail
    {
        // token received from CreateSession/RenewSession API call
        public GetImageDetailsResponse GetImageDetails(string token, List<string> imageIds)
        {
            var getImageDetailsRequest = new GetImageDetailsRequest
            {
                RequestHeader = new RequestHeader { Token = token },
                GetImageDetailsRequestBody = new GetImageDetailsRequestBody
                {
                    CountryCode = "USA",
                    Language = "en-us",
                    ImageIds = imageIds
                }
            };

            return MakeWebRequest(Constants.GetImageDetailsRequestUrl, getImageDetailsRequest);
        }

        //You may wish to replace this code with your preferred library for posting and receiving JSON data.
        private static GetImageDetailsResponse MakeWebRequest(string requestUrl, GetImageDetailsRequest request)
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

            return jsonSerializer.Deserialize<GetImageDetailsResponse>(jsonResult);
        }
    }
}
