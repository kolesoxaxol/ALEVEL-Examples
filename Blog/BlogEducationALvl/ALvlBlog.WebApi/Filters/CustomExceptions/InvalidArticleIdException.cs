namespace ALvlBlog.WebApi.Filters.CustomExceptions
{
    public class InvalidArticleIdException : ApiException
    {
        public InvalidArticleIdException(string message, string additionalInfo) : base(message, Enums.ErrorCodes.InvalidArticleId, additionalInfo)
        { 
        }
    }
}