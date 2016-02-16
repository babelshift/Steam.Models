using System.Collections.Generic;

namespace Steam.Models.SteamCommunity
{
    public class OwnedGamesResultModel
    {
        public int GameCount { get; set; }

        public IReadOnlyCollection<OwnedGameModel> OwnedGames { get; set; }
    }
}