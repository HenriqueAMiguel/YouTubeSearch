using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeSearch.Models
{
    public class PesquisaYouTube
    {
        public int Id { get; set; }
        public string Kind { get; set; }
        public string Etag { get; set; }
        public string NextPageToken { get; set; }
        public string RegionCode { get; set; }
        public int? TotalResults { get; set; }
        public List<ItemPesquisaYouTube> Items { get; set; }
    }
}
