using AnimeList_AspNetCore_EF.Core.Entities;
using Microsoft.EntityFrameworkCore;
using static AnimeList_AspNetCore_EF.Core.Entities.Anime;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimeList_AspNetCore_EF.Models.Animes
{
    public class AnimesEditViewModel
    {

        public AnimesEditViewModel() { }
        public AnimesEditViewModel(Anime anime)
        {
            Id = anime.Id;
            Title = anime.Title;
            Type = anime.Type;
            Episodes = anime.Episodes;
            WatchedEpisodes = anime.WatchedEpisodes;
            StartDate = anime.StartDate;
            FinishDate = anime.FinishDate;
            Score = anime.Score;
            WatchingStatus  = anime.WatchingStatus;
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "The Title field is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Type field is required.")]
        public AnimationType Type { get; set; }

        [Required(ErrorMessage = "The Episodes field is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Episodes must be greater than 0.")]
        public int Episodes { get; set; }

        [Required(ErrorMessage = "The Watched Episodes field is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Watched Episodes must be non-negative.")]
        public int WatchedEpisodes { get; set; }

        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FinishDate { get; set; }

        [Range(1, 10, ErrorMessage = "Score must be between 1 and 10.")]
        public int? Score { get; set; }

        [Required(ErrorMessage = "Please select a Watching Status.")]
        public Status WatchingStatus { get; set; }

    }
}

    
