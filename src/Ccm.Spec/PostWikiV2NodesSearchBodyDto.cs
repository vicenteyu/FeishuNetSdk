// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-09-19
// ************************************************************************
// <copyright file="PostWikiV2NodesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索 Wiki 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 搜索 Wiki 请求体
/// <para>搜索 Wiki，用户通过关键词查询 Wiki，只能查找自己可见的 wiki</para>
/// <para>**注：** Wiki 存在，但用户搜索不到并不一定是搜索有问题，可能是用户没有查看该 Wiki 的权限</para>
/// <para>接口ID：6927492937392324635</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/search_wiki</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEzN0YjLxcDN24SM3QjN%2fsearch_wiki</para>
/// </summary>
public record PostWikiV2NodesSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键词，长度不超过50个字符</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;

    /// <summary>
    /// <para>文档所属的知识空间ID，为空搜索全部知识空间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("space_id")]
    public string? SpaceId { get; set; }

    /// <summary>
    /// <para>不为空搜索该节点及其所有子节点，为空搜索所有 wiki（使用 node_id 过滤必须传入 space_id）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("node_id")]
    public string? NodeId { get; set; }
}
