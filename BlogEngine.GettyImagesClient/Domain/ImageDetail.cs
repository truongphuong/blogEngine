using System.Collections.Generic;

namespace BlogEngine.GettyImagesClient.Domain
{
    public class GetImageDetailsRequestBody
    {
        public string CountryCode { get; set; }
        public string Language { get; set; }
        public List<string> ImageIds { get; set; }
    }

    public class GetImageDetailsRequest
    {
        public RequestHeader RequestHeader { get; set; }
        public GetImageDetailsRequestBody GetImageDetailsRequestBody { get; set; }
    }

    public class GetImageDetailsResult
    {
        public List<Image> Images { get; set; }
        public string EditorialSegment { get; set; }
    }

    public class GetImageDetailsResponse
    {
        public ResponseHeader ResponseHeader { get; set; }
        public GetImageDetailsResult GetImageDetailsResult { get; set; }
    }

}
