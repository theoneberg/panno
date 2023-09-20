using Microsoft.Extensions.DependencyInjection;

namespace Panno;

public static class ServiceExtensions
{
	/// <summary>
	/// Add Panno`s services.
	/// </summary>
	/// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
	public static INotificationBuilder AddPanno(this IServiceCollection services)
	{
		var builder = new NotificationBuilder(services);

		builder.Services.AddScoped<INotificationContext, NotificationContext>();

		return builder;
	}
}
