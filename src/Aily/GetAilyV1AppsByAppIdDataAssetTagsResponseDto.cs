// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-23
//
// Last Modified By : yxr
// Last Modified On : 2024-10-23
// ************************************************************************
// <copyright file="GetAilyV1AppsByAppIdDataAssetTagsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取数据知识分类列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 获取数据知识分类列表 响应体
/// <para>获取 Aily 助手的数据知识分类列表</para>
/// <para>接口ID：7424752773160812548</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/data-knowledge/data-knowledge-management/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-data_asset_tag%2flist</para>
/// </summary>
public record GetAilyV1AppsByAppIdDataAssetTagsResponseDto : IPageableResponse<GetAilyV1AppsByAppIdDataAssetTagsResponseDto.DataAssetTag>
{
    /// <summary>
    /// <para>数据知识分类列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public DataAssetTag[]? Items { get; set; }

    /// <summary>
    /// <para>数据知识分类列表</para>
    /// </summary>
    public record DataAssetTag
    {
        /// <summary>
        /// <para>数据知识分类名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：spring_5862e4fea8__c__asset_tag_aadg2b5ql4gbs</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("data_asset_tag_id")]
        public string? DataAssetTagId { get; set; }

        /// <summary>
        /// <para>数据知识分类ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：电影</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
