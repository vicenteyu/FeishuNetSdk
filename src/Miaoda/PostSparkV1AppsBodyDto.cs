// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="PostSparkV1AppsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建妙搭应用 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 创建妙搭应用 请求体
/// <para>创建妙搭应用</para>
/// <para>接口ID：7642228089434950837</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fcreate</para>
/// </summary>
public record PostSparkV1AppsBodyDto
{
    /// <summary>
    /// <para>应用名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：智能客服助手</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>应用类型</para>
    /// <para>可选值：HTML</para>
    /// <para>必填：否</para>
    /// <para>示例值：HTML</para>
    /// </summary>
    [JsonPropertyName("app_type")]
    public string? AppType { get; set; }

    /// <summary>
    /// <para>应用描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：提供7×24小时智能对话服务，支持常见问题自动解答与工单流转</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>应用图标地址</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://example.com/app-icons/customer-service.png</para>
    /// </summary>
    [JsonPropertyName("icon_url")]
    public string? IconUrl { get; set; }
}
