using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Mirrors <code>DOMCharacterDataModified</code> event.
	/// </summary>
	[Event(ProtocolName.DOM.CharacterDataModified)]
	public class CharacterDataModifiedEvent
	{
		/// <summary>
		/// Gets or sets Id of the node that has changed.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets New text value.
		/// </summary>
		public string CharacterData { get; set; }
	}
}
