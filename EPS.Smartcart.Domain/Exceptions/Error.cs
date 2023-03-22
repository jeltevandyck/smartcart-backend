namespace EPS.Smartcart.Domain.Exceptions;

public class Error
{
    public string Title { get; set; }
    public string Message { get; set; }
    public string? Property { get; set; }

    public Error(string title, string message)
    {
        Title = title;
        Message = message;
    }

    public Error(string title, string message, string? property)
    {
        Title = title;
        Message = message;
        Property = property;
    }
}