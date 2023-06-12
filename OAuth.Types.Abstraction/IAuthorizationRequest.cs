namespace OAuth.Types.Abstraction
{
    public interface IAuthorizationRequest
    {
       string ResponseType { get; }

       string ClientId { get; }

       string? RedirectUri { get; }

       string? Scope { get; }

       string? State { get; }
    }
}
