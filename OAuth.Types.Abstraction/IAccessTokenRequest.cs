namespace OAuth.Types.Abstraction
{
    public interface IAccessTokenRequest
    {
        string GrantType { get; }
        string? Code { get; }
        string? RedirectUri { get; }
        string? ClientId { get; }
        string? ClientSecret { get; }
        string? Username { get; }
        string? Password { get; }
        string? Scope { get; }
        string? RefreshToken { get; }
    }
}
