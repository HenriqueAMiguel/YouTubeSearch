using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YouTubeSearch.ViewModels
{
    public class YouTubeRequestViewModel
    {
        public string Part { get; set; }
        [Display(Name = "Pesquisa: ")]
        public string Q { get; set; }
        public string Type { get; set; }
        public YouTubeResponseViewModel YouTubeResponse { get; set; } = new YouTubeResponseViewModel();
    }
}
