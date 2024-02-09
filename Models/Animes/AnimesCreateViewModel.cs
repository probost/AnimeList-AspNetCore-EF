using static AnimeList_AspNetCore_EF.Core.Entities.Anime;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimeList_AspNetCore_EF.Models.Animes
{
    public class AnimesCreateViewModel
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public string Episodes { get; set; }
        public string WatchedEpisodes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int Score { get; set; }
        public Status WatchingStatus { get; set; }
    }
}
