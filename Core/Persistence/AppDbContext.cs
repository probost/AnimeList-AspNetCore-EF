using AnimeList_AspNetCore_EF.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Mozilla;

namespace WebApplicationMvcEfCore.Core.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Anime> Animes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=4c2_probostvojtech_db1;uid=probostvojtech;password=123456");
        }
    }
}
