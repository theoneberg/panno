using FluentValidation.Results;

namespace Panno;

public static class NotificationExtensions
{
	/// <summary>
	/// Add a list of validation errors to the context.
	/// </summary>
	/// <param name="context">The <see cref="INotificationContext"/> to add the notifications to.</param>
	/// <param name="errors">Error list to add to the context</param>
	public static void AddRange(this INotificationContext context, IEnumerable<ValidationFailure> errors)
	{
		foreach (var error in errors)
		{
			context.Add(error.ErrorCode, error.ErrorMessage);
		}
	}

	/// <summary>
	/// Add a list of validation errors to the context.
	/// </summary>
	/// <param name="context">The <see cref="INotificationContext"/> to add the notifications to.</param>
	/// <param name="validation">The <see cref="ValidationResult"/> that contains a error list to add to the context.</param>
	public static void AddRange(this INotificationContext context, ValidationResult validation)
	{
		context.AddRange(validation.Errors);
	}
}
