namespace EPS.Smartcart.Domain.Exceptions;

public class ErrorResponse
{
    public int StatusCode { get; set; }
    public List<Error> Errors { get; set; } = new List<Error>();
}
