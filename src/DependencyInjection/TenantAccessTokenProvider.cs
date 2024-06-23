// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="TenantAccessTokenProvider.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
using Microsoft.Extensions.DependencyInjection;
using WebApiClientCore.Extensions.OAuths;
using WebApiClientCore.Extensions.OAuths.Exceptions;
using WebApiClientCore.Extensions.OAuths.TokenProviders;

namespace FeishuNetSdk
{
    internal class TenantAccessTokenProvider : TokenProvider
    {
        private readonly FeishuNetSdkOptions _options;
        public TenantAccessTokenProvider(IServiceProvider services, FeishuNetSdkOptions options) : base(services)
        {
            _options = options;
        }

        protected override Task<TokenResult?> RefreshTokenAsync(IServiceProvider serviceProvider, string refresh_token)
        {
            return RequestTokenAsync(serviceProvider);
        }

        protected override async Task<TokenResult?> RequestTokenAsync(IServiceProvider serviceProvider)
        {
            var token = await serviceProvider.GetRequiredService<IFeishuApi>()
                         .PostAuthV3TenantAccessTokenInternalAsync(
                             new Auth.Spec
                                 .PostAuthV3TenantAccessTokenInternalBodyDto
                             {
                                 AppId = _options.AppId,
                                 AppSecret = _options.AppSecret
                             });
            //当返回码异常，抛出异常
            if (token.Code != 0)
                throw new TokenException(token.Msg);

            return new TokenResult
            {
                Access_token = token.TenantAccessToken,
                Expires_in = token.Expire
            };
        }
    }
}