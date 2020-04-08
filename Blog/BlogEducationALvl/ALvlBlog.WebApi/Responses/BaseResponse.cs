using ALvlBlog.WebApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ALvlBlog.WebApi.Responses
{
    public class BaseResponse 
    {
        /// <summary>
        /// Response error code (Success by default)
        /// </summary>
        public ErrorCodes Code { get; set; } = ErrorCodes.Success;

        public string Message { get; set; }

        [IgnoreDataMember]
        public string InternalMessage { get; set; }
    }


    public class BaseResponse<T> : BaseResponse
    {
        public T Data { get; set; }
    }

}