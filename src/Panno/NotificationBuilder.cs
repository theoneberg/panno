using Microsoft.Extensions.DependencyInjection;

namespace Panno;

public interface INotificationBuilder
{
	IServiceCollection Services { get; }
}

public class NotificationBuilder : INotificationBuilder
{
	public IServiceCollection Services { get; }

	public NotificationBuilder(IServiceCollection services)
		=> Services = services;
}
