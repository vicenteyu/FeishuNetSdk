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
        /// <returns></returns>
        public static IServiceCollection AddFeishuNetSdk(this IServiceCollection services,
            string AppId,
            string AppSecret,
            string? EncryptKey = null,
            string? VerificationToken = null,
            bool EnableLogging = true,
            bool IgnoreStatusException = true)
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
            return services.AddFeishuNetSdk();
        }

        /// <summary>
        /// 使用配置文件方式注册SDK
        /// </summary>
        public static IServiceCollection AddFeishuNetSdk(this IServiceCollection services,
            IConfigurationSection config)
        {
            services.Configure<FeishuNetSdkOptions>(config);
            return services.AddFeishuNetSdk();
        }

        /// <summary>
        /// 使用委托方式注册SDK
        /// </summary>
        public static IServiceCollection AddFeishuNetSdk(this IServiceCollection services,
            Action<FeishuNetSdkOptions> configureOptions)
        {
            services.Configure(configureOptions);
            return services.AddFeishuNetSdk();
        }

        /// <summary>
        /// 注册SDK
        /// </summary>
        private static IServiceCollection AddFeishuNetSdk(this IServiceCollection services)
        {
            services.AddWebApiClient()
                .UseJsonFirstApiActionDescriptor();

            services.AddHttpApi<IFeishuApi>();
            services.AddHttpApi<IFeishuAppApi>();
            services.AddHttpApi<IFeishuTenantApi>(option => option.KeyValueSerializeOptions.IgnoreNullValues = true);
            services.AddHttpApi<IFeishuUserApi>(option => option.KeyValueSerializeOptions.IgnoreNullValues = true);

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
