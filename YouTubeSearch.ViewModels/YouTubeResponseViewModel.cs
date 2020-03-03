using System;
using System.Collections.Generic;

namespace YouTubeSearch.ViewModels
{
    public class YouTubeResponseViewModel
    {
        public string Kind { get; set; }
        public string Etag { get; set; }
        public string NextPageToken { get; set; }
        public string RegionCode { get; set; }
        public int? TotalResults { get; set; }
        public List<ItemViewModel> Items { get; set; } = new List<ItemViewModel>();
    }

    public class ItemViewModel
    {
        public string ChanelTitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string MediumThumbnailUrl { get; set; }

    }
}
