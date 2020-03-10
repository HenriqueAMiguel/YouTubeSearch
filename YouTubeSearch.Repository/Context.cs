using Microsoft.EntityFrameworkCore;
using System;

namespace YouTubeSearch.Repository
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        
        public DbSet<Models.PesquisaYouTube> PesquisasYouTube { get; set; }
        public DbSet<Models.ItemPesquisaYouTube> ItemsPesquisaYouTube { get; set; }
    }
}
