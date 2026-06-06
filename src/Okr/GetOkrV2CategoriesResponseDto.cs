// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="GetOkrV2CategoriesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取所有 OKR 分类 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 获取所有 OKR 分类 响应体
/// <para>获取系统中所有可用的 OKR 分类的分页列表。每个分类包括 ID、名称（多语言）、颜色、类型、启用状态以及创建/更新时间戳等元数据。</para>
/// <para>接口ID：7644764969658469324</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-category/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-category%2flist</para>
/// </summary>
public record GetOkrV2CategoriesResponseDto : IPageableResponse<GetOkrV2CategoriesResponseDto.Category>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>分类列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Category[]? Items { get; set; }

    /// <summary>
    /// <para>分类列表</para>
    /// </summary>
    public record Category
    {
        /// <summary>
        /// <para>分类 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398473</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>分类的创建时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>分类的更新时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>分类类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：user</para>
        /// <para>可选值：<list type="bullet">
        /// <item>person：个人</item>
        /// <item>team：团队</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("category_type")]
        public string CategoryType { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// <para>颜色</para>
        /// <para>必填：是</para>
        /// <para>示例值：blue</para>
        /// <para>可选值：<list type="bullet">
        /// <item>blue：蓝色</item>
        /// <item>purple：紫色</item>
        /// <item>wathet：浅蓝色</item>
        /// <item>turquoise：蓝绿色</item>
        /// <item>indigo：靛青</item>
        /// <item>orange：橙色</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("color")]
        public string Color { get; set; } = string.Empty;

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public CategoryName Name { get; set; } = new();

        /// <summary>
        /// <para>名称</para>
        /// </summary>
        public record CategoryName
        {
            /// <summary>
            /// <para>中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：中文</para>
            /// <para>最大长度：70</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("zh")]
            public string? Zh { get; set; }

            /// <summary>
            /// <para>英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：英文</para>
            /// <para>最大长度：70</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("en")]
            public string? En { get; set; }

            /// <summary>
            /// <para>日文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：日文</para>
            /// <para>最大长度：70</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("ja")]
            public string? Ja { get; set; }
        }
    }
}
