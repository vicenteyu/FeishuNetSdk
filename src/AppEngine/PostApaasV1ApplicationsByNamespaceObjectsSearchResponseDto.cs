// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceObjectsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 搜索记录 响应体
/// <para>在应用内搜索记录</para>
/// <para>接口ID：7384730094873051164</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object%2fsearch</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceObjectsSearchResponseDto
{
    /// <summary>
    /// <para>搜索结果列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：[]</para>
    /// </summary>
    [JsonPropertyName("records")]
    public string? Records { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 HasMore 为 true 时，会同时返回新的 NextPageToken</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvYmplY3RzX3BhZ2VfdG9rZW4iOlt7Im9ial9pZCI6MTc2OTI4NzM5M</para>
    /// </summary>
    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    /// <summary>
    /// <para>对象信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("objects")]
    public ObjectMeta[]? Objects { get; set; }

    /// <summary>
    /// <para>对象信息</para>
    /// </summary>
    public record ObjectMeta
    {
        /// <summary>
        /// <para>对象信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("object")]
        public ObjectMetaObject? Object { get; set; }

        /// <summary>
        /// <para>对象信息</para>
        /// </summary>
        public record ObjectMetaObject
        {
            /// <summary>
            /// <para>对象 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1764024447556775</para>
            /// <para>最大值：9223372036854775807</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("id")]
            public int? Id { get; set; }

            /// <summary>
            /// <para>对象 API 名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("api_name")]
            public string? ApiName { get; set; }

            /// <summary>
            /// <para>对象名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"zh_cn":"text"}</para>
            /// </summary>
            [JsonPropertyName("label")]
            public I18nLanguage<string>? Label { get; set; }

            /// <summary>
            /// <para>对象配置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("settings")]
            public ObjectSettings? Settings { get; set; }

            /// <summary>
            /// <para>对象配置</para>
            /// </summary>
            public record ObjectSettings
            {
                /// <summary>
                /// <para>展示名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：_id</para>
                /// <para>最大长度：512</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("display_name")]
                public string? DisplayName { get; set; }

                /// <summary>
                /// <para>允许搜索字段</para>
                /// <para>必填：否</para>
                /// <para>最大长度：512</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("allow_search_fields")]
                public string[]? AllowSearchFields { get; set; }

                /// <summary>
                /// <para>展示字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("search_layout")]
                public ObjectSearchLayout? SearchLayout { get; set; }

                /// <summary>
                /// <para>展示字段</para>
                /// </summary>
                public record ObjectSearchLayout
                {
                    /// <summary>
                    /// <para>展示字段</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：1024</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("display_fields")]
                    public string[]? DisplayFields { get; set; }
                }
            }
        }

        /// <summary>
        /// <para>字段信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：512</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("fields")]
        public ObjectField[]? Fields { get; set; }

        /// <summary>
        /// <para>字段信息</para>
        /// </summary>
        public record ObjectField
        {
            /// <summary>
            /// <para>字段 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：1764024447525960</para>
            /// <para>最大值：9223372036854775807</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("id")]
            public int? Id { get; set; }

            /// <summary>
            /// <para>API 名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>最大长度：256</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("api_name")]
            public string? ApiName { get; set; }

            /// <summary>
            /// <para>字段类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：string</para>
            /// <para>最大长度：256</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>字段名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"zh_cn":"text"}</para>
            /// </summary>
            [JsonPropertyName("label")]
            public I18nLanguage<string>? Label { get; set; }
        }
    }
}
