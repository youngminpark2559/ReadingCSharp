using Microsoft.AspNetCore.Http;

//c Add UrlExtensions.cs and define PathAndQuery() extension method which extracts querystring from HttpRequest object and combines path and querystring and returns that string to caller.

namespace SportsStore.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue
                ? $"{request.Path}{request.QueryString}"
                : request.Path.ToString();
    }
}