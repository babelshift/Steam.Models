namespace Steam.Models
{
    public class GameClientResultModel
    {
        public bool Success { get; set; }

        public int DeployVersion { get; set; }

        public int ActiveVersion { get; set; }
    }
}