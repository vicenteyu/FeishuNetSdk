// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="AppAccessTokenProvider.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
using Microsoft.Extensions.DependencyInjection;
using WebApiClientCore.Extensions.OAuths;
using WebApiClientCore.Extensions.OAuths.Exceptions;
using WebApiClientCore.Extensions.OAuths.TokenProviders;

namespace FeishuNetSdk.Services
{
    internal class AppAccessTokenProvider(IServiceProvider services, FeishuNetSdkOptions options) : TokenProvider(services)
    {
        protected override Task<TokenResult?> RefreshTokenAsync(IServiceProvider serviceProvider, string refresh_token)
        {
            return RequestTokenAsync(serviceProvider);
        }

        protected override async Task<TokenResult?> RequestTokenAsync(IServiceProvider serviceProvider)
        {
            var token = await serviceProvider.GetRequiredService<IFeishuApi>()
                    .PostAuthV3AppAccessTokenInternalAsync(
                        new Auth.Spec
                            .PostAuthV3AppAccessTokenInternalBodyDto
                        {
                            AppId = options.AppId,
                            AppSecret = options.AppSecret
                        });
            //当返回码异常，抛出异常
            if (token.Code != 0)
                throw new TokenException(token.Msg);
            return new TokenResult
            {
                Access_token = token.AppAccessToken,
                Expires_in = token.Expire - FeishuNetSdkOptions.ExpirationTimeTolerancePeriod
            };
        }
    }
}
