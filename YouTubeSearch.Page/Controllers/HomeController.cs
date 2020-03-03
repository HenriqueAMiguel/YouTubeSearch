using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YouTubeSearch.Page.Models;

namespace YouTubeSearch.Page.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Service.YoutubeServices _youtubeServices;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _youtubeServices = new Service.YoutubeServices();
        }

        public IActionResult Index()
        {
            var model = new ViewModels.YouTubeRequestViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ViewModels.YouTubeRequestViewModel model)
        {
            model.YouTubeResponse = _youtubeServices.BuscaVideos(model.Q);

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
