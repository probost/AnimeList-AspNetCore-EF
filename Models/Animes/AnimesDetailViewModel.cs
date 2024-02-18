using AnimeList_AspNetCore_EF.Core.Entities;
using NuGet.Common;

namespace AnimeList_AspNetCore_EF.Models.Animes
{
    public class AnimesDetailViewModel
    {

        public AnimesDetailViewModel() { }

        public AnimesDetailViewModel(Anime anime)
        {
            Anime = anime;
        }

        public Anime Anime{ get; set; }
    }
}
