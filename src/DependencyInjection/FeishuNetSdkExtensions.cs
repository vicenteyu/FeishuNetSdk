using FeishuNetSdk;
using FeishuNetSdk.Attributes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using WebApiClientCore.Extensions.OAuths;
using WebApiClientCore.Extensions.OAuths.Exceptions;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 提供注册SDK的扩展
    /// </summary>
    public static class FeishuNetSdkExtensions
    {
        /// <summary>
        /// 使用配置文件方式注册SDK
        /// </summary>
        public static IServiceCollection AddFeishuNetSdk(this IServiceCollection services,
            IConfiguration config)
        {
            services.Configure<FeishuNetSdkOptions>(config);
            var provider = services.BuildServiceProvider()
                .GetRequiredService<IOptionsMonitor<FeishuNetSdkOptions>>();
            return services.AddFeishuNetSdk(provider.CurrentValue);
        }

        /// <summary>
        /// 使用委托方式注册SDK
        /// </summary>
        public static IServiceCollection AddFeishuNetSdk(this IServiceCollection services,
            Action<FeishuNetSdkOptions> configureOptions)
        {
            var options = new FeishuNetSdkOptions();
            configureOptions(options);
            return services.AddFeishuNetSdk(options).Configure(configureOptions);
        }

        /// <summary>
        /// 注册SDK
        /// </summary>
        private static IServiceCollection AddFeishuNetSdk(this IServiceCollection services,
            FeishuNetSdkOptions options)
        {
            services.AddWebApiClient().UseSourceGeneratorHttpApiActivator();
            services.AddHttpApi<IFeishuApi>();
            services.AddHttpApi<IFeishuAppApi>();
            services.AddHttpApi<IFeishuTenantApi>(option => option.KeyValueSerializeOptions.IgnoreNullValues = true);
            services.AddHttpApi<IFeishuUserApi>(option => option.KeyValueSerializeOptions.IgnoreNullValues = true);

            services.AddTokenProvider<IFeishuTenantApi>(async provider =>
            {
                var token = await provider.GetRequiredService<IFeishuApi>()
                    .PostAuthV3TenantAccessTokenInternalAsync(
                        new FeishuNetSdk.Auth.Spec
                            .PostAuthV3TenantAccessTokenInternalBodyDto
                        {
                            AppId = options.AppId,
                            AppSecret = options.AppSecret
                        });
                //当返回码异常，抛出异常
                if (token.Code != 0)
                    throw new TokenException(token.Msg);
                return new TokenResult
                {
                    Access_token = token.TenantAccessToken,
                    Expires_in = token.Expire
                };
            });

            services.AddTokenProvider<IFeishuAppApi>(async provider =>
            {
                var token = await provider.GetRequiredService<IFeishuApi>()
                    .PostAuthV3AppAccessTokenInternalAsync(
                        new FeishuNetSdk.Auth.Spec
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
                    Expires_in = token.Expire
                };
            });

            return services;
        }
    }
}
