using System;
using System.Collections.Generic;
using System.Linq;

namespace spygame.Handlers
{
    public class UserHandler
    {

        private string _VIPPlayerName = string.Empty;

        /// <summary>
        /// Dictionary of connected players. Key = connectionID, value = playerName
        /// </summary>
        public Dictionary<string, string> ConnectedPlayers = new Dictionary<string, string>();

        /// <summary>
        /// Dictionary of players currently in game - key = connection id, tuple is of playername, rolemodel
        /// </summary>
        public Dictionary<string, Tuple<string, Models.CardModel>> GamePlayers = new Dictionary<string, Tuple<string, Models.CardModel>>();

        public string GetVIP() { return _VIPPlayerName; }

        public void SetVIP() { _VIPPlayerName = ConnectedPlayers.First().Value; }

        public bool IsVIP(string MaybeVIP) { return _VIPPlayerName == MaybeVIP; }

    }
}
