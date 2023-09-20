using FluentValidation;
using FluentValidation.Results;

namespace Panno;

public static class ValidatorExtensions
{
	public static ValidationResult ValidateAndNotify<T>(this IValidator<T> validator, T instance, INotificationContext context)
	{
		var validation = validator.Validate(instance);
		
		context.AddRange(validation);
		
		return validation;
	}

	public static async Task<ValidationResult> ValidateAndNotifyAsync<T>(this IValidator<T> validator, T instance, INotificationContext context)
	{
		var validation = await validator.ValidateAsync(instance);
		
		context.AddRange(validation);
		
		return validation;
	}
}
