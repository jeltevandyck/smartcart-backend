using EPS.Smartcart.Domain.Exceptions;

namespace EPS.Smartcart.Application.Exceptions;

public class ValidationException : Exception
{
    public List<Error> Errors { get; }
    
    public ValidationException()
    {
    }
    
    public ValidationException(List<Error> errors)
    {
        Errors = errors;
    }
    
    public ValidationException(string message)
    {
        this.Errors = new List<Error>();
        this.Errors.Add(new Error("Validation Error", message));
    }
}