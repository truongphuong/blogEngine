using System;
using System.Collections.Generic;

namespace BlogEngine.GettyImagesClient.Domain
{
    public class Image
    {
        public string ImageId { get; set; }
        public string Title { get; set; }
        public string ImageFamily { get; set; }
        public string CollectionName { get; set; }
        public DateTime DateCreated { get; set; }
        public string LicensingModel { get; set; }
        public string UrlThumb { get; set; }
        public string UrlPreview { get; set; }
        public string UrlWatermarkPreview { get; set; }
        public string UrlWatermarkComp { get; set; }
        public List<SizesDownloadableImage> SizesDownloadableImages { get; set; }
        public List<Keyword> Keywords { get; set; }
    }

    public class SizesDownloadableImage
    {
        public int ResolutionDpi { get; set; }
        public string SizeKey { get; set; }
        public int PixelHeight { get; set; }
        public int PixelWidth { get; set; }
    }
    public class Keyword
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
    }
}
