namespace OAuth.Types.Abstraction
{
    internal interface IErrorResponse
    {
        string Error { get; }

        string? ErrorDescription { get; }

        string? ErrorUri { get; }

        string? State { get; }
    }
}
