// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
// ************************************************************************
// <copyright file="PostWikiV2SpacesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建知识空间 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建知识空间 请求体
/// <para>此接口用于创建知识空间</para>
/// <para>接口ID：7023947709203922948</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace%2fcreate</para>
/// </summary>
public record PostWikiV2SpacesBodyDto
{
    /// <summary>
    /// <para>知识空间名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：知识空间</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>知识空间描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：知识空间描述</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>表示知识空间的分享状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：open</para>
    /// <para>最大长度：99</para>
    /// <para>最小长度：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>open：打开</item>
    /// <item>closed：关闭</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("open_sharing")]
    public string? OpenSharing { get; set; }
}
