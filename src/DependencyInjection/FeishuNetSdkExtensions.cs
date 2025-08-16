// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-08-16
// ************************************************************************
// <copyright file="FeishuNetSdkExtensions.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
using FeishuNetSdk;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
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
        private static readonly Action<WebApiClientCore.HttpApiOptions> defaultHttpApiOptions = option =>
        {
            option.JsonSerializeOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            option.KeyValueSerializeOptions.IgnoreNullValues = true;
        };

        private static readonly Action<HttpClient> defaultHttpClientOptions = option =>
        {
            option.Timeout = TimeSpan.FromMinutes(5);
        };

        /// <summary>
        /// 使用参数方式注册SDK
        /// </summary>
        /// <param name="services"></param>
        /// <param name="AppId">应用Id</param>
        /// <param name="AppSecret">应用密钥</param>
        /// <param name="EncryptKey">事件订阅 解密的密钥</param>
        /// <param name="VerificationToken">事件订阅 验证应用的密钥</param>
        /// <param name="EnableLogging">启用日志 （true = 启用， false = 关闭， 默认 = 启用）</param>
        /// <param name="IgnoreStatusException">忽略状态异常错误（true = 忽略， false = 启用， 默认 = 忽略）</param>
        /// <param name="httpApiOptions">HttpApi选项</param>
        /// <param name="httpClientOptions">HttpClient选项</param>
        /// <returns></returns>
        public static IServiceCollection AddFeishuNetSdk(this IServiceCollection services,
            string AppId,
            string AppSecret,
            string? EncryptKey = null,
            string? VerificationToken = null,
            bool EnableLogging = true,
            bool IgnoreStatusException = true,
            Action<WebApiClientCore.HttpApiOptions>? httpApiOptions = null,
            Action<HttpClient>? httpClientOptions = null)
        {
            services.Configure((FeishuNetSdkOptions options) =>
            {
                options.AppId = AppId;
                options.AppSecret = AppSecret;
                options.EncryptKey = EncryptKey;
                options.VerificationToken = VerificationToken;
                options.EnableLogging = EnableLogging;
                options.IgnoreStatusException = IgnoreStatusException;
            });
            return services.AddFeishuNetSdk(httpApiOptions, httpClientOptions);
        }

        /// <summary>
        /// 使用配置文件方式注册SDK
        /// </summary>
        public static IServiceCollection AddFeishuNetSdk(this IServiceCollection services,
            IConfigurationSection config,
            Action<WebApiClientCore.HttpApiOptions>? httpApiOptions = null,
            Action<HttpClient>? httpClientOptions = null)
        {
            services.Configure<FeishuNetSdkOptions>(config);
            return services.AddFeishuNetSdk(httpApiOptions, httpClientOptions);
        }

        /// <summary>
        /// 使用委托方式注册SDK
        /// </summary>
        public static IServiceCollection AddFeishuNetSdk(this IServiceCollection services,
            Action<FeishuNetSdkOptions> configureOptions,
            Action<WebApiClientCore.HttpApiOptions>? httpApiOptions = null,
            Action<HttpClient>? httpClientOptions = null)
        {
            services.Configure(configureOptions);
            return services.AddFeishuNetSdk(httpApiOptions, httpClientOptions);
        }

        /// <summary>
        /// 注册SDK
        /// </summary>
        private static IServiceCollection AddFeishuNetSdk(this IServiceCollection services,
            Action<WebApiClientCore.HttpApiOptions>? httpApiOptions = null,
            Action<HttpClient>? httpClientOptions = null)
        {
            services.AddWebApiClient()
                .UseJsonFirstApiActionDescriptor();

            var finalHttpApiOptions = httpApiOptions ?? defaultHttpApiOptions;
            var finalHttpClientOptions = httpClientOptions ?? defaultHttpClientOptions;

            services.AddHttpApi<IFeishuApi>(finalHttpApiOptions).ConfigureHttpClient(finalHttpClientOptions);
            services.AddHttpApi<IFeishuAppApi>(finalHttpApiOptions).ConfigureHttpClient(finalHttpClientOptions);
            services.AddHttpApi<IFeishuTenantApi>(finalHttpApiOptions).ConfigureHttpClient(finalHttpClientOptions);
            services.AddHttpApi<IFeishuUserApi>(finalHttpApiOptions).ConfigureHttpClient(finalHttpClientOptions);

            services.TryAddSingleton<IEventCallbackServiceProvider, EventCallbackServiceProvider>();

            using var serviceProvider = services.BuildServiceProvider();
            var options = serviceProvider.GetRequiredService<IOptions<FeishuNetSdkOptions>>();

            services.AddTokenProvider<IFeishuTenantApi, TenantAccessTokenProvider>(serviceProvider =>
            {
                return new TenantAccessTokenProvider(serviceProvider, options.Value);
            });

            services.AddTokenProvider<IFeishuAppApi, AppAccessTokenProvider>(serviceProvider =>
            {
                return new AppAccessTokenProvider(serviceProvider, options.Value);
            });

            var eventServiceProvider = serviceProvider.GetRequiredService<IEventCallbackServiceProvider>();
            var handlers = eventServiceProvider.FindAllHandlers();
            foreach (var eventHandlerDescriptor in handlers)
                services.Add(new ServiceDescriptor(eventHandlerDescriptor.EventHandlerType,
                    eventHandlerDescriptor.EventHandlerType, ServiceLifetime.Transient));

            return services;
        }
    }
}
