using AutoMapper;
using BlogBL.BLModels;
using BlogEducationALvl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogEducationALvl.App_Start
{
    public class WebAutomapperProfile : Profile
    {
        public WebAutomapperProfile()
        {
            CreateMap<ArticleModel, ArticleBL>().ReverseMap();
            CreateMap<IList<ArticleModel>, IList<ArticleBL>>().ReverseMap();

        }
    }
}