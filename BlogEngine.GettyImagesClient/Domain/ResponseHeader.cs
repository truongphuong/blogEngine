using System.Collections.Generic;

namespace BlogEngine.GettyImagesClient.Domain{
    public class ResponseHeader{
        public string Status { get; set; }
        public ICollection<StatusEntry> StatusList { get; set; }
        public string CoordinationId { get; set; }
    }
}
