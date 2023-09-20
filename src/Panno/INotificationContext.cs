namespace Panno;

public interface INotificationContext
{
	/// <summary>
	/// List of notifications in the context.
	/// </summary>
	IReadOnlyList<Notification> Notifications { get; }

	bool HasNotifications { get; }
	
	/// <summary>
	/// Add a notification to the context.
	/// </summary>
	/// <param name="code">Notification code.</param>
	/// <param name="message">Notification message.</param>
	void Add(string code, string message);

	/// <summary>
	/// Add a notification to the context.
	/// </summary>
	/// <param name="notification">Notification.</param>
	void Add(Notification notification);

	/// <summary>
	/// Add a list of notifications to the context.
	/// </summary>
	/// <param name="notifications">Notification list</param>
	void AddRange(IEnumerable<Notification> notifications);
}
