using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when HTTP request has failed to load.
	/// </summary>
	[Event(ProtocolName.Network.LoadingFailed)]
	public class LoadingFailedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Resource type.
		/// </summary>
		public Page.ResourceType Type { get; set; }
		/// <summary>
		/// Gets or sets User friendly error message.
		/// </summary>
		public string ErrorText { get; set; }
		/// <summary>
		/// Gets or sets True if loading was canceled.
		/// </summary>
		public bool Canceled { get; set; }
	}
}
