// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-01-11
//
// Last Modified By : yxr
// Last Modified On : 2026-01-11
// ************************************************************************
// <copyright file="PostSearchV2DocWikiSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索文档 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Search;
/// <summary>
/// 搜索文档 响应体
/// <para>该接口用于根据搜索关键词（query）对当前用户可见的云文档进行搜索</para>
/// <para>接口ID：7589313298248600535</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/search-v2/doc_wiki/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdoc_wiki%2fsearch</para>
/// </summary>
public record PostSearchV2DocWikiSearchResponseDto : IPageableResponse<PostSearchV2DocWikiSearchResponseDto.DocResUnit>
{
    /// <summary>
    /// <para>匹配结果总数（辅助分页参考）</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// <para>最大值：9999999</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>搜索结果列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("res_units")]
    public DocResUnit[]? ResUnits { get; set; }

    /// <summary>
    /// <para>搜索结果列表</para>
    /// </summary>
    public record DocResUnit
    {
        /// <summary>
        /// <para>标题高亮</para>
        /// <para>必填：否</para>
        /// <para>示例值：&lt;h&gt;飞书文档&lt;/h&gt;使用指南</para>
        /// </summary>
        [JsonPropertyName("title_highlighted")]
        public string? TitleHighlighted { get; set; }

        /// <summary>
        /// <para>摘要高亮</para>
        /// <para>必填：否</para>
        /// <para>示例值：本文介绍&lt;h&gt;飞书文档&lt;/h&gt;的创建、编辑与分享功能</para>
        /// </summary>
        [JsonPropertyName("summary_highlighted")]
        public string? SummaryHighlighted { get; set; }

        /// <summary>
        /// <para>结果类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：DOC</para>
        /// <para>可选值：<list type="bullet">
        /// <item>DOC：doc实体</item>
        /// <item>WIKI：wiki类型</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("entity_type")]
        public string? EntityType { get; set; }

        /// <summary>
        /// <para>文档搜索元信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"title_highlighted":"&lt;h&gt;飞书文档&lt;/h&gt;使用指南","summary_highlighted":"本文介绍&lt;h&gt;飞书文档&lt;/h&gt;的创建、编辑与分享功能","entity_type":"DOC","result_meta":"{"type":SHORTCUT,"update_time":1766567613}"}</para>
        /// </summary>
        [JsonPropertyName("result_meta")]
        public DocMeta? ResultMeta { get; set; }

        /// <summary>
        /// <para>文档搜索元信息</para>
        /// </summary>
        public record DocMeta
        {
            /// <summary>
            /// <para>文档类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：SHORTCUT</para>
            /// <para>可选值：<list type="bullet">
            /// <item>DOC：文档</item>
            /// <item>SHEET：表格</item>
            /// <item>BITABLE：多维表格</item>
            /// <item>MINDNOTE：思维导图</item>
            /// <item>FILE：文件</item>
            /// <item>WIKI：维基</item>
            /// <item>DOCX：新版文档</item>
            /// <item>FOLDER：space文件夹</item>
            /// <item>CATALOG：wiki2.0文件夹</item>
            /// <item>SLIDES：新版本幻灯片</item>
            /// <item>SHORTCUT：快捷方式</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("doc_types")]
            public string? DocTypes { get; set; }

            /// <summary>
            /// <para>更新时间戳（秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1766567446</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>文档链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://www.feishu.cn/docs/dox-1234567890abcdef</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>所有者名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("owner_name")]
            public string? OwnerName { get; set; }

            /// <summary>
            /// <para>所有者OpenID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou-7890123456abcdef</para>
            /// </summary>
            [JsonPropertyName("owner_id")]
            public string? OwnerId { get; set; }

            /// <summary>
            /// <para>是否跨租户</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_cross_tenant")]
            public bool? IsCrossTenant { get; set; }

            /// <summary>
            /// <para>文档创建时间戳（秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1766567446</para>
            /// <para>最大值：9223372036854776</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>上次打开时间戳（秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1766567446</para>
            /// <para>最大值：9223372036854776</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("last_open_time")]
            public int? LastOpenTime { get; set; }

            /// <summary>
            /// <para>最后一次编辑用户OpenID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou-1122334455aabbcc</para>
            /// </summary>
            [JsonPropertyName("edit_user_id")]
            public string? EditUserId { get; set; }

            /// <summary>
            /// <para>最后一次编辑用户名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：李四</para>
            /// </summary>
            [JsonPropertyName("edit_user_name")]
            public string? EditUserName { get; set; }

            /// <summary>
            /// <para>文档token</para>
            /// <para>必填：否</para>
            /// <para>示例值：dox_9876543210fedcba</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string? Token { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：token_1234567890fedcba</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DocResUnit[]? Items => ResUnits;
}
