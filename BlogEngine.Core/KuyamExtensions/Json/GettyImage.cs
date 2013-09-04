namespace BlogEngine.Core.KuyamExtensions.Json
{
    /// <summary>
    /// Get all imagse for Getty images API
    /// </summary>
    public class GettyImage
    {
        /// <summary>
        /// Image ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Name of image
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Url Thumb of image
        /// </summary>
        public string UrlThumb { get; set; }
        /// <summary>
        /// Url Preview of image
        /// </summary>
        public string UrlPreview { get; set; }
        /// <summary>
        /// Status of all images
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// Tags of images
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// LocationData of images
        /// </summary>
        public string LocationData { get; set; }
        /// <summary>
        /// UserID
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// Getty Image Id
        /// </summary>
        public string GettyImageId { get; set; }
        
    }
}
