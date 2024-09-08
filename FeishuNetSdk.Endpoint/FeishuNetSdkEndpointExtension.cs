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
// <summary>�ṩ�����¼��ص���ַ�������չ</summary>
// ************************************************************************
using FeishuNetSdk.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

#pragma warning disable IDE0130
namespace Microsoft.Extensions.DependencyInjection
#pragma warning restore IDE0130
{
    /// <summary>
    /// ���÷����¼��ص���ַ����
    /// </summary>
    public static class FeishuNetSdkEndpointExtension
    {
        /// <summary>
        /// �¼��ص�������ַ
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
                    return Results.Json(result.Dto);

                return Results.Ok();
            });

            return app;
        }
    }
}