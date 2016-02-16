using System.Collections.Generic;

namespace Steam.Models.SteamCommunity
{
    public class BadgesResultModel
    {
        public IReadOnlyCollection<BadgeModel> Badges { get; set; }

        public int PlayerXp { get; set; }

        public int PlayerLevel { get; set; }

        public int PlayerXpNeededToLevelUp { get; set; }

        public int PlayerXpNeededCurrentLevel { get; set; }
    }
}