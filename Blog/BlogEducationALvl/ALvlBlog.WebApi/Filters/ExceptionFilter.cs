using ALvlBlog.WebApi.Filters.CustomExceptions;
using ALvlBlog.WebApi.Responses;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;

namespace ALvlBlog.WebApi.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is HttpResponseException)
            {
                var httpResponseException = actionExecutedContext.Exception as HttpResponseException;

                if (httpResponseException.Response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    return;
                }
            }

            var exception = actionExecutedContext.Exception as ApiException;
            var code = exception?.ErrorCode ?? Enums.ErrorCodes.General;

            actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.OK, new BaseResponse
            {
                Code = code,
                Message = exception.Message,
                InternalMessage = actionExecutedContext.Exception.Message
            },

            actionExecutedContext.ActionContext.ControllerContext.Configuration.Formatters.JsonFormatter);

        }
    }
}