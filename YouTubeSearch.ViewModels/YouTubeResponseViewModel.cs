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
        public PageInfoViewModel PageInfo { get; set; }
        public List<ItemViewModel> Items { get; set; }
    }

    public class PageInfoViewModel
    {
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }

    public class ItemViewModel
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MyProperty { get; set; }
        public SnippetViewModel Snippet { get; set; }

    }

    public class SnippetViewModel
    {
        public DateTime PublishedAt { get; set; }
        public string ChanelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ThumbnailsViewModel Thumbnails { get; set; }
    }

    public class ThumbnailsViewModel
    {
        public ThumbnailsDefaultViewModel @default { get; set; }
        public ThumbnailsMediumViewModel medium { get; set; }
        public ThumbnailsHighViewModel high { get; set; }
    }

    public class ThumbnailsDefaultViewModel
    {
        public string url { get; set; }
    }

    public class ThumbnailsMediumViewModel
    {
        public string url { get; set; }
    }

    public class ThumbnailsHighViewModel
    {
        public string url { get; set; }
    }
}
