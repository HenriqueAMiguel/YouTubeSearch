using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System.Collections.Generic;
using YouTubeSearch.ViewModels;

namespace YouTubeSearch.Service
{
    public class YoutubeServices
    {
        public YouTubeResponseViewModel BuscaVideos(string pesquisa)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "Chave aqui",
                ApplicationName = "Chave de API 1"
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = pesquisa;
            searchListRequest.Order = SearchResource.ListRequest.OrderEnum.Relevance;
            searchListRequest.MaxResults = 30;
            searchListRequest.Type = "video";

            var searchListResponse = searchListRequest.Execute();

            var responseViewModel = new YouTubeResponseViewModel
            {
                Etag = searchListResponse.ETag,
                Kind = searchListResponse.Kind,
                NextPageToken = searchListResponse.NextPageToken,
                RegionCode = searchListResponse.RegionCode,
                TotalResults = searchListResponse.PageInfo.TotalResults,
                Items = new List<ItemViewModel>()
            };

            foreach(var item in searchListResponse.Items)
            {
                responseViewModel.Items.Add(new ItemViewModel
                {
                    Description = item.Snippet.Description,
                    MediumThumbnailUrl = item.Snippet.Thumbnails.Medium.Url,
                    PublishedAt = item.Snippet.PublishedAt.Value,
                    Title = item.Snippet.Title,
                    ChanelTitle = item.Snippet.ChannelTitle
                });
            }


            return responseViewModel;
        }
    }
}
