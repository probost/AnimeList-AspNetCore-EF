namespace AnimeList_AspNetCore_EF.Core.Entities
{
    public partial class Anime
    {
        public enum Status
        {
            Watching  = 1,
            Completed = 2,
            OnHold = 3,
            Dropped = 4,
            PlanToWatch= 5
        } 
    }
}
