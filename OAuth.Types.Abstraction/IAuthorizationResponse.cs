namespace OAuth.Types.Abstraction
{
    public interface IAuthorizationResponse
    {
        string Code { get; }

        string State { get; }
    }
}
