// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2024-09-07
// ************************************************************************
// <copyright file="FeishuNetSdkEndpointExtension.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>提供飞书事件回调地址服务的扩展</summary>
// ************************************************************************
using FeishuNetSdk.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

#pragma warning disable IDE0130
namespace Microsoft.Extensions.DependencyInjection
#pragma warning restore IDE0130
{
    /// <summary>
    /// 启用飞书事件回调地址服务
    /// </summary>
    public static class FeishuNetSdkEndpointExtension
    {
        /// <summary>
        /// 事件回调监听地址
        /// </summary>
        /// <param name="app"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static IEndpointRouteBuilder UseFeishuEndpoint(this IEndpointRouteBuilder app, string pattern)
        {
            app.MapPost(pattern, async (IEventCallbackServiceProvider provider, ILogger<WebApplication> logger, [FromBody] object input) =>
            {
                logger.LogInformation("FeishuEndpoint: {json}", input);
                var result = await provider.HandleAsync(input);
                logger.LogInformation("EventHandle: {json}", JsonSerializer.Serialize(result));

                if (result?.Success != true)
                    return Results.Problem(result?.Error);

                if (result?.Dto != null)
                    return Results.Json(result.Dto, serializerOptions);

                return Results.Ok();
            });

            return app;
        }

        private static readonly JsonSerializerOptions serializerOptions = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }
}