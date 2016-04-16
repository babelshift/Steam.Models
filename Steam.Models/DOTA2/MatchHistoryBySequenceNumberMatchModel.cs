using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.DOTA2
{
    public class MatchHistoryBySequenceNumberMatchModel
    {
        public IList<MatchHistoryBySequenceNumberMatchPlayerModel> Players { get; set; }
        
        public bool RadiantWin { get; set; }
        
        public int Duration { get; set; }
        
        public DateTime StartTime { get; set; }
        
        public long MatchId { get; set; }
        
        public int MatchSequenceNumber { get; set; }
        
        public int RadiantTowerStatus { get; set; }
        
        public int DireTowerStatus { get; set; }
        
        public int RadiantBarracksStatus { get; set; }
        
        public int DireBarracksStatus { get; set; }
        
        public int Cluster { get; set; }
        
        public long FirstBloodTime { get; set; }
        
        public int LobbyType { get; set; }
        
        public int HumanPlayers { get; set; }
        
        public int LeagueId { get; set; }
        
        public int PositiveVotes { get; set; }
        
        public int NegativeVotes { get; set; }
        
        public int GameMode { get; set; }
        
        public int Flags { get; set; }
        
        public int Engine { get; set; }
        
        public int RadiantScore { get; set; }
        
        public int DireScore { get; set; }
    }
}
