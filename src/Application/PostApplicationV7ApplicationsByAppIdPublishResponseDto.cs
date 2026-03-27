// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="PostApplicationV7ApplicationsByAppIdPublishResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>提交发布自建应用 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 提交发布自建应用 响应体
/// <para>自建应用提交应用发布，如果当前自建应用没有待发布的版本，则会自动创建一个版本，如果有待发布的版本，则直接提交该版本。</para>
/// <para>接口ID：7621030901518552023</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/application-publish/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapplication-publish%2fcreate</para>
/// </summary>
public record PostApplicationV7ApplicationsByAppIdPublishResponseDto
{
    /// <summary>
    /// <para>应用版本ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：oav_d317f090b7258ad0372aa53963cda70d</para>
    /// </summary>
    [JsonPropertyName("version_id")]
    public string? VersionId { get; set; }

    /// <summary>
    /// <para>应用版本号</para>
    /// <para>必填：否</para>
    /// <para>示例值：1.1.1</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
