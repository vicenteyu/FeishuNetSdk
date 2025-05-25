// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCompensationV1ItemCategoriesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取薪资项分类信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量获取薪资项分类信息 响应体
/// <para>批量获取薪资项分类信息</para>
/// <para>接口ID：7314129756769763332</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/compensation-component-and-metric/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fitem_category%2flist</para>
/// </summary>
public record GetCompensationV1ItemCategoriesResponseDto : IPageableResponse<GetCompensationV1ItemCategoriesResponseDto.ItemCategory>
{
    /// <summary>
    /// <para>薪资项分类信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ItemCategory[]? Items { get; set; }

    /// <summary>
    /// <para>薪资项分类信息列表</para>
    /// </summary>
    public record ItemCategory
    {
        /// <summary>
        /// <para>薪资项分类ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：4532312334</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资项分类名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：基本薪资类</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>薪资项多语言分类</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("i18n_names")]
        public I18nContent[]? I18nNames { get; set; }

        /// <summary>
        /// <para>薪资项多语言分类</para>
        /// </summary>
        public record I18nContent
        {
            /// <summary>
            /// <para>语言版本，例如：“zh-CN”、“en-US”</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn</para>
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// <para>语言名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：中文名称</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：2314123434</para>
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
