// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="FeishuNetSdkExtensions.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
using FeishuNetSdk;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

#pragma warning disable IDE0130
namespace Microsoft.Extensions.DependencyInjection
#pragma warning restore IDE0130
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
            services.AddWebApiClient()
                .UseJsonFirstApiActionDescriptor();

            services.AddHttpApi<IFeishuApi>();
            services.AddHttpApi<IFeishuAppApi>();
            services.AddHttpApi<IFeishuTenantApi>(option => option.KeyValueSerializeOptions.IgnoreNullValues = true);
            services.AddHttpApi<IFeishuUserApi>(option => option.KeyValueSerializeOptions.IgnoreNullValues = true);

            services.AddTokenProvider<IFeishuTenantApi, TenantAccessTokenProvider>(serviceProvider =>
            {
                return new TenantAccessTokenProvider(serviceProvider, options);
            });

            services.AddTokenProvider<IFeishuAppApi, AppAccessTokenProvider>(serviceProvider =>
            {
                return new AppAccessTokenProvider(serviceProvider, options);
            });

            return services;
        }
    }
}
