namespace OAuth.Types.Abstraction
{
    public interface IAccessTokenResponse 
    { 
        string AccessToken { get; }

        string TokenType { get; }

        uint ExpiresIn { get; }

        string? RefreshToken { get; }
    }
}
