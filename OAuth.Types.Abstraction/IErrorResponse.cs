namespace OAuth.Types.Abstraction
{
    public interface IErrorResponse
    {
        string Error { get; }

        string? ErrorDescription { get; }

        string? ErrorUri { get; }

        string? State { get; }
    }
}
