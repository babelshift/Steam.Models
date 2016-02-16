using System.Collections.Generic;

namespace Steam.Models.SteamCommunity
{
    public class RecentlyPlayedGamesResultModel
    {
        public int TotalCount { get; set; }

        public IReadOnlyCollection<RecentlyPlayedGameModel> RecentlyPlayedGames { get; set; }
    }
}