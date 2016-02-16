using System;
using System.Collections.Generic;

namespace Steam.Models.DOTA2
{
    public class MatchHistoryMatchModel
    {
        public long MatchId { get; set; }

        public int MatchSequenceNumber { get; set; }

        public DateTime StartTime { get; set; }

        public int LobbyType { get; set; }

        public int RadiantTeamId { get; set; }

        public int DireTeamId { get; set; }

        public IReadOnlyCollection<MatchHistoryPlayerModel> Players { get; set; }
    }
}