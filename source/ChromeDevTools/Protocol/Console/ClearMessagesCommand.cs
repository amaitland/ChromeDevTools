using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Clears console messages collected in the browser.
	/// </summary>
	[Command(ProtocolName.Console.ClearMessages)]
	public class ClearMessagesCommand
	{
	}
}
