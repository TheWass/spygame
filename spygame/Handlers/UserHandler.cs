using System.Collections.Generic;

namespace spygame.Handlers
{
    public static class UserHandler
    {
        /// <summary>
        /// Dictionary of connected players. Key = connectionID, value = playerName
        /// </summary>
        public static Dictionary<string, string> ConnectedPlayers = new Dictionary<string, string>();
    }
}
