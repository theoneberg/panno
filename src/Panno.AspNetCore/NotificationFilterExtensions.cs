using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Panno;

public static class NotificationFilterExtensions
{
	public static INotificationBuilder AddFilter(this INotificationBuilder builder)
	{
		return builder.AddFilter<DefaultNotificationFilter>();
	}

	public static INotificationBuilder AddFilter<TFilter>(this INotificationBuilder builder) where TFilter : INotificationFilter
	{
		builder.Services.Configure<MvcOptions>(options => { options.Filters.Add<TFilter>(); });

		return builder;
	}
}
