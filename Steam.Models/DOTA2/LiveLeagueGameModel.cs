using System.Collections.Generic;

namespace Steam.Models.DOTA2
{
    public class LiveLeagueGameModel
    {
        public IReadOnlyCollection<LiveLeagueGamePlayerInfoModel> Players { get; set; }

        public LiveLeagueGameTeamRadiantInfoModel RadiantTeam { get; set; }

        public LiveLeagueGameTeamDireInfoModel DireTeam { get; set; }

        public long LobbyId { get; set; }

        public long MatchId { get; set; }

        public int Spectators { get; set; }

        public int SeriesId { get; set; }

        public int GameNumber { get; set; }

        public int LeagueId { get; set; }

        public double StreamDelaySeconds { get; set; }

        public int RadiantSeriesWins { get; set; }

        public int DireSeriesWins { get; set; }

        public int SeriesType { get; set; }

        public int LeagueSeriesId { get; set; }

        public int LeagueGameId { get; set; }

        public string StageName { get; set; }

        public DotaLeagueTier LeagueTier { get; set; }

        public LiveLeagueGameScoreboardModel Scoreboard { get; set; }
    }
}