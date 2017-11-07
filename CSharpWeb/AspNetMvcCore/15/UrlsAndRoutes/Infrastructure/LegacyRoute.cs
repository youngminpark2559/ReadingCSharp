﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add LegacyRoute.cs which implements IRouter, to create a custom route class.

namespace UrlsAndRoutes.Infrastructure
{
    public class LegacyRoute : IRouter
    {
        private string[] urls;

        public LegacyRoute(params string[] targetUrls)
        {
            this.urls = targetUrls;
        }

        public Task RouteAsync(RouteContext context)
        {
            string requestedUrl = context.HttpContext.Request.Path
                .Value.TrimEnd('/');
            if (urls.Contains(requestedUrl, StringComparer.OrdinalIgnoreCase))
            {
                context.Handler = async ctx => {
                    HttpResponse response = ctx.Response;
                    byte[] bytes = Encoding.ASCII.GetBytes($"URL: {requestedUrl}");
                    await response.Body.WriteAsync(bytes, 0, bytes.Length);
                };
            }
            return Task.CompletedTask;
        }

        public VirtualPathData GetVirtualPath(VirtualPathContext context)
        {
            return null;
        }
    }
}