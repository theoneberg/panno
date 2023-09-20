using System.Net.Mime;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Panno;

public class DefaultNotificationFilter : INotificationFilter
{
	private readonly INotificationContext _notificationContext;

	public DefaultNotificationFilter(INotificationContext notificationContext)
	{
		_notificationContext = notificationContext;
	}

	public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
	{
		if (_notificationContext.HasNotifications)
		{
			context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
			context.HttpContext.Response.ContentType = MediaTypeNames.Application.Json;

			var notifications = JsonSerializer.Serialize(_notificationContext.Notifications);
			await context.HttpContext.Response.WriteAsync(notifications);

			return;
		}

		await next();
	}
}
