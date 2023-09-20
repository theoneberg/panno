using Microsoft.AspNetCore.Mvc.Filters;

namespace Panno;

/// <summary>
/// Marker interface for notification filters.
/// </summary>
public interface INotificationFilter : IAsyncResultFilter
{
}
