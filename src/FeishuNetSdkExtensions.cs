// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-11-30
// ************************************************************************
// <copyright file="FeishuNetSdkExtensions.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
global using System.Text.Json;
global using System.Text.Json.Nodes;
using FeishuNetSdk;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

#pragma warning disable IDE0130 // 命名空间与文件夹结构不匹配
namespace Microsoft.Extensions.DependencyInjection;
#pragma warning restore IDE0130 // 命名空间与文件夹结构不匹配

/// <summary>
/// 提供注册SDK的扩展
/// </summary>
public static class FeishuNetSdkExtensions
{
    /// <summary>
    /// API 客户端调用时使用的 JsonSerializerOptions。
    /// </summary>
    public static readonly JsonSerializerOptions? DefaultJsonSerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    private static readonly Action<WebApiClientCore.HttpApiOptions> defaultHttpApiOptions = option =>
    {
        option.JsonSerializeOptions.DefaultIgnoreCondition = DefaultJsonSerializerOptions.DefaultIgnoreCondition;
        option.JsonSerializeOptions.PropertyNameCaseInsensitive = DefaultJsonSerializerOptions.PropertyNameCaseInsensitive;
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
    /// <param name="appId">应用Id</param>
    /// <param name="appSecret">应用密钥</param>
    /// <param name="encryptKey">事件订阅 解密的密钥</param>
    /// <param name="verificationToken">事件订阅 验证应用的密钥</param>
    /// <param name="enableLogging">启用日志 （true = 启用， false = 关闭， 默认 = 启用）</param>
    /// <param name="ignoreStatusException">忽略状态异常错误（true = 忽略， false = 启用， 默认 = 忽略）</param>
    /// <param name="httpApiOptions">HttpApi选项</param>
    /// <param name="httpClientOptions">HttpClient选项</param>
    /// <returns></returns>
    public static IServiceCollection AddFeishuNetSdk(this IServiceCollection services,
        string appId,
        string appSecret,
        string? encryptKey = null,
        string? verificationToken = null,
        bool enableLogging = true,
        bool ignoreStatusException = true,
        Action<WebApiClientCore.HttpApiOptions>? httpApiOptions = null,
        Action<HttpClient>? httpClientOptions = null)
    {
        services.Configure((FeishuNetSdkOptions options) =>
        {
            options.AppId = appId;
            options.AppSecret = appSecret;
            options.EncryptKey = encryptKey;
            options.VerificationToken = verificationToken;
            options.EnableLogging = enableLogging;
            options.IgnoreStatusException = ignoreStatusException;
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

        services.AddTokenProvider<IFeishuTenantApi, TenantAccessTokenProvider>(serviceProvider =>
        {
            var options = serviceProvider.GetRequiredService<IOptions<FeishuNetSdkOptions>>();
            return new TenantAccessTokenProvider(serviceProvider, options.Value);
        });

        services.AddTokenProvider<IFeishuAppApi, AppAccessTokenProvider>(serviceProvider =>
        {
            var options = serviceProvider.GetRequiredService<IOptions<FeishuNetSdkOptions>>();
            return new AppAccessTokenProvider(serviceProvider, options.Value);
        });

        var handlers = EventCallbackServiceProvider.FindAllHandlers();
        foreach (var eventHandlerDescriptor in handlers)
            services.Add(new ServiceDescriptor(eventHandlerDescriptor.EventHandlerType,
                eventHandlerDescriptor.EventHandlerType, ServiceLifetime.Transient));

        return services;
    }
}
