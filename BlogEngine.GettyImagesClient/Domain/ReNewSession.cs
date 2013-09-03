
namespace BlogEngine.GettyImagesClient.Domain{

    public class RenewSessionRequestBody{
        public string SystemId { get; set; }
        public string SystemPassword { get; set; }
        public string UserId { get; set; }
        public string UserPassword { get; set; }
    }

    public class RenewSessionRequest{
        public RequestHeader RequestHeader { get; set; }
        public RenewSessionRequestBody RenewSessionRequestBody { get; set; }
    }

    public class RenewSessionResult{
        public string AccountId { get; set; }
        public string SecureToken { get; set; }
        public string Token { get; set; }
        public int TokenDurationMinutes { get; set; }
    }

    public class RenewSessionResponse
    {
        public ResponseHeader ResponseHeader { get; set; }
        public RenewSessionResult RenewSessionResult { get; set; }
    }

}
