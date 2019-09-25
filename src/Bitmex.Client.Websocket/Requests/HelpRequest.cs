using Bitmex.Client.Websocket.Messages;

namespace Bitmex.Client.Websocket.Requests
{
    /// <summary>
    /// Raw ping request to get pong response
    /// </summary>
    public class HelpRequest : RequestBase
    {
        /// <inheritdoc />
        public override MessageType Operation => MessageType.Help;

        /// <inheritdoc />
        public override bool IsRaw => true;
    }
}
