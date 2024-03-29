﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimeList_AspNetCore_EF.Core.Entities
{
    [Table("animes")]
    public partial class Anime
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("type")]
        public AnimationType Type { get; set; }
        [Column("episodes")]
        public int Episodes{ get; set; }
        [Column("watched_episodes")]
        public int WatchedEpisodes{ get; set; }
        [Column("start_date")]
        public DateTime? StartDate { get; set; }
        [Column("finish_date")]
        public DateTime? FinishDate{ get; set; }
        [Column("score")]
        public int? Score { get; set; }
        [Column("status")]
        public Status WatchingStatus { get; set; }




    }
}
