namespace OAuth.Types.Abstraction
{
    public interface IRevocationRequest
    {
        string Token { get; }
        string? TokenTypeHint { get; }
    }
}
