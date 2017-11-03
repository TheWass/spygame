using System.Collections.Generic;

namespace spygame.Models
{
    public class GameModel
    {
        public Dictionary<CardModel, int> cardPool;
        public Dictionary<int, List<PlayerModel>> teamMembers;

    }
}
