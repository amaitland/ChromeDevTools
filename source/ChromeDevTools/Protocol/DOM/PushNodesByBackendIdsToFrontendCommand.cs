using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Requests that a batch of nodes is sent to the caller given their backend node ids.
	/// </summary>
	[Command(ProtocolName.DOM.PushNodesByBackendIdsToFrontend)]
	public class PushNodesByBackendIdsToFrontendCommand
	{
		/// <summary>
		/// Gets or sets The array of backend node ids.
		/// </summary>
		public long[] BackendNodeIds { get; set; }
	}
}
