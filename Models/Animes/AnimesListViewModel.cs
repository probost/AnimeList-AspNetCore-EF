using AnimeList_AspNetCore_EF.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnimeList_AspNetCore_EF.Models.Animes
{
    public class AnimesListViewModel
    {
        public AnimesListViewModel() { }
        public AnimesListViewModel(List<Anime> animes)
        {
            Animes = animes;
        }
        public List<Anime> Animes { get; set; }
    }
}

    
