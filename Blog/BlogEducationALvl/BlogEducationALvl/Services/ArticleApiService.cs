using BlogEducationALvl.Responses;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogEducationALvl.Services
{
    public interface IArticleApiService
    {
        ArticleResponse GetArticles();
    }
    public class ArticleApiService : IArticleApiService
    {
        private readonly RestClient _restClient;
        public ArticleApiService()
        {
            _restClient = new RestClient("http://local.blog");
        }
        public ArticleResponse GetArticles()
        {
            var apiUrl = "api/article";
            var request = new RestRequest(apiUrl);
            var responseData = _restClient.Execute<ArticleResponse>(request, Method.GET).Data;

            return responseData;
        }
    }
}