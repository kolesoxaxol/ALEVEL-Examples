using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALvlBlog.WebApi.Models
{
    public class ArticleModel
    {
        //public Article()
        //{
        //    Comments = new List<Comment>()
        //}

        public int Id { get; set; }
        [JsonProperty("bigtitle")]
        public string Title { get; set; }
        [JsonProperty("smalltitle")]
        public string SubTitle { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public int AuthorId { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }


    }
}