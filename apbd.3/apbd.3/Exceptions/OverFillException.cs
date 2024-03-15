namespace apbd._3.Exceptions;

public class OverFillException : Exception
{
    public OverFillException()
    {
    }

    public OverFillException(string? message) : base(message)
    {
    }

    public OverFillException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}