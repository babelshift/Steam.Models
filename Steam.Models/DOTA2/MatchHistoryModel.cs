using System.Collections.Generic;

namespace Steam.Models.DOTA2
{
    public class MatchHistoryModel
    {
        public int Status { get; set; }

        public int NumResults { get; set; }

        public int TotalResults { get; set; }

        public int ResultsRemaining { get; set; }

        public IReadOnlyCollection<MatchHistoryMatchModel> Matches { get; set; }
    }
}