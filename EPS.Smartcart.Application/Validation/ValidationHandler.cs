using EPS.Smartcart.Application.Exceptions;
using EPS.Smartcart.Domain.Exceptions;
using FluentValidation;
using MediatR;
using ValidationException = EPS.Smartcart.Application.Exceptions.ValidationException;

namespace EPS.Smartcart.Application.Validation;

public class ValidationHandler<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationHandler(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (_validators.Any())
        {
            var context = new ValidationContext<TRequest>(request);
            var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
            var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();


            if (failures.Count() != 0)
            {
                List<Error> errors = new List<Error>();
                failures.ForEach(fail => errors.Add(
                    new Error("Validation Error", 
                        fail.ErrorMessage,
                        fail.PropertyName)));
                
                throw new ValidationException(errors);
            }
        }
        
        return await next();
    }
}