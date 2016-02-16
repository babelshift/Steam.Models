namespace Steam.Models.CSGO
{
    public class ServerStatusMatchmakingModel
    {
        public string Scheduler { get; set; }

        public int OnlineServers { get; set; }

        public int OnlinePlayers { get; set; }

        public int SearchingPlayers { get; set; }

        public int SearchSecondsAverage { get; set; }
    }
}