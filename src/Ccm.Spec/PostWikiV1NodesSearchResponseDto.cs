// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostWikiV1NodesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索 Wiki 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 搜索 Wiki 响应体
/// <para>搜索 Wiki，用户通过关键词查询 Wiki，只能查找自己可见的 wiki</para>
/// <para>**注：** Wiki 存在，但用户搜索不到并不一定是搜索有问题，可能是用户没有查看该 Wiki 的权限</para>
/// <para>接口ID：6927492937392324635</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/search_wiki</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEzN0YjLxcDN24SM3QjN%2fsearch_wiki</para>
/// </summary>
public record PostWikiV1NodesSearchResponseDto
{
    /// <summary>
    /// <para>wiki 信息数组</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Item[]? Items { get; set; }

    /// <summary></summary>
    public record Item
    {
        /// <summary>
        /// <para>wiki 节点 Id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// <para>wiki 所属知识空间 Id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("space_id")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// <para>wiki 类型, 参考文档类型表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("obj_type")]
        public int? ObjType { get; set; }

        /// <summary>
        /// <para>wiki 标题</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>wiki 的访问 url</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>wiki 对应图标的 url</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("icon")]
        public string? Icon { get; set; }
    }

    /// <summary>
    /// <para>如果 has_more 为 true 则返回下一页的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有下一页数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
