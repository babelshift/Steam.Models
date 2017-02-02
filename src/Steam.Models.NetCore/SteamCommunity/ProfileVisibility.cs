namespace Steam.Models.SteamCommunity
{
    /// <summary>
    /// Indicates the selected privacy/visibility level of the player's Steam Community profile
    /// </summary>
    public enum ProfileVisibility
    {
        Unknown = 0,
        Private = 1,
        Public = 3,
        FriendsOnly = 8,
    }
}