
namespace BlogEngine.GettyImagesClient.Domain{

    public class CreateSessionRequestBody{
        public string SystemId { get; set; }
        public string SystemPassword { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }

    public class CreateSessionTokenRequest{
        public RequestHeader RequestHeader { get; set; }
        public CreateSessionRequestBody CreateSessionRequestBody { get; set; }
    }

    public class CreateSessionResult{
        public string AccountId { get; set; }
        public string SecureToken { get; set; }
        public string Token { get; set; }
        public int TokenDurationMinutes { get; set; }
    }

    public class CreateSessionTokenResponse{
        public ResponseHeader ResponseHeader { get; set; }
        public CreateSessionResult CreateSessionResult { get; set; }
    }
}
