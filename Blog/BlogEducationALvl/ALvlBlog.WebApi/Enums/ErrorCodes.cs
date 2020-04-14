using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALvlBlog.WebApi.Enums
{
    public enum ErrorCodes
    {
        Success = 0,
        General = 1,
        InvalidArticleId = 2,
        InvalidAuthorName = 3

    }
}