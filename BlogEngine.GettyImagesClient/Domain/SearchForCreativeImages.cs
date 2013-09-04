using System.Collections.Generic;

namespace BlogEngine.GettyImagesClient.Domain
{
    public class Query
    {
        public string SearchPhrase { get; set; }
    }

    public class Filter
    {
        public List<string> ImageFamilies;
    }

    public class SearchForImages2RequestBody
    {
        public Query Query;
        public Filter Filter;
        public ResultOptions ResultOptions;
    }

    public class ResultOptions
    {
        public int ItemCount { get; set; }
        public int ItemStartNumber { get; set; }
        public int ItemTotalCount { get; set; }
        public string RefinementOptionsSet { get; set; }
    }


    public class SearchForImagesResponse
    {
        public ResponseHeader ResponseHeader { get; set; }
        public SearchForImagesResult SearchForImagesResult { get; set; }
    }

    public class SearchForImagesResult
    {
        public int ItemStartNumber { get; set; }
        public int ItemTotalCount { get; set; }
        public IList<Image> Images { get; set; }
    }

    public class SearchForImagesRequest
    {
        public RequestHeader RequestHeader { get; set; }
        public SearchForImages2RequestBody SearchForImages2RequestBody { get; set; }
    }

}
