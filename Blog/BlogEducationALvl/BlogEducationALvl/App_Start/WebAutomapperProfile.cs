using AutoMapper;
using BlogBL.BLModels;
using BlogEducationALvl.Models;
using BlogEducationALvl.Responses;

namespace BlogEducationALvl.App_Start
{
    public class WebAutomapperProfile : Profile
    {
        public WebAutomapperProfile()
        {
            CreateMap<ArticleModel, ArticleBL>().ReverseMap();
            CreateMap<ArticleModel, ArticleData>().ReverseMap();
        }
    }
}