using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Diagnostics;
using BlogEngine.GettyImagesClient.Domain;

namespace BlogEngine.GettyImagesClient.Services
{
    public class SearchForCreativeImages
    {

        // token received from CreateSession/RenewSession API call
        public SearchForImagesResponse Search(string token, string searchTerm)
        {
            var searchForImagesRequest = new SearchForImagesRequest
            {
                RequestHeader = new RequestHeader { Token = token },
                SearchForImages2RequestBody = new SearchForImages2RequestBody
                {
                    Query = new Query { SearchPhrase = searchTerm },
                    Filter = new Filter { ImageFamilies = new List<string> { "Creative" } },
                    ResultOptions = new ResultOptions { ItemCount =50 , ItemStartNumber = 1 }
                }
            };

            return MakeWebRequest(Constants.SearchForImagesRequestUrl, searchForImagesRequest);
        }

        //You may wish to replace this code with your preferred library for posting and receiving JSON data.
        private static SearchForImagesResponse MakeWebRequest(string requestUrl, SearchForImagesRequest request)
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

            return jsonSerializer.Deserialize<SearchForImagesResponse>(jsonResult);
        }

    }
}
