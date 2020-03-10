using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeSearch.Models
{
    public class ItemPesquisaYouTube
    {
        public int Id { get; set; }
        public string ChanelTitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string MediumThumbnailUrl { get; set; }
    }
}
