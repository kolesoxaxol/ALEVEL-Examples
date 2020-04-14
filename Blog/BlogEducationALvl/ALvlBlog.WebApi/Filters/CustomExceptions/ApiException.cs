using ALvlBlog.WebApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALvlBlog.WebApi.Filters.CustomExceptions
{
    public class ApiException : Exception
    {
        public ErrorCodes ErrorCode { get; set; }

        public string AdditionalInfo { get; set; }


        public ApiException(string message, ErrorCodes errorCode = ErrorCodes.General, string additionalInfo = null) : base(message)
        {
            ErrorCode = errorCode;
            AdditionalInfo = additionalInfo;
        }

    }
}