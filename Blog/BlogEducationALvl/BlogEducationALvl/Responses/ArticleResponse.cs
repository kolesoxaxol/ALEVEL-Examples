using System;
using System.Collections.Generic;

namespace BlogEducationALvl.Responses
{
    public class ArticleData
    {
        public int Id { get; set; }
        public string bigtitle { get; set; }
        public string smalltitle { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public int AuthorId { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
    }

    public class ArticleResponse
    {
        public List<ArticleData> Data { get; set; }
        public int Code { get; set; }
        public object Message { get; set; }
    }
}