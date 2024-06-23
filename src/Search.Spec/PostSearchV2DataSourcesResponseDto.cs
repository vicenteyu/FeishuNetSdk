// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSearchV2DataSourcesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建数据源 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Search.Spec;
/// <summary>
/// 创建数据源 响应体
/// <para>创建一个数据源。</para>
/// <para>接口ID：6953505452630212611</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/data_source/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdata_source%2fcreate</para>
/// </summary>
public record PostSearchV2DataSourcesResponseDto
{
    /// <summary>
    /// <para>数据源实例</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("data_source")]
    public DataSourceSuffix? DataSource { get; set; }

    /// <summary></summary>
    public record DataSourceSuffix
    {
        /// <summary>
        /// <para>数据源的唯一标识</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>data_source的展示名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>数据源状态，0-已上线，1-未上线。如果未填，默认是未上线状态。</para>
        /// <para>**可选值有**：</para>
        /// <para>0:已上线,1:未上线</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：已上线</item>
        /// <item>1：未上线</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("state")]
        public int? State { get; set; }

        /// <summary>
        /// <para>对于数据源的描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>创建时间，使用Unix时间戳，单位为“秒”</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间，使用Unix时间戳，单位为“秒”</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>是否超限</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("is_exceed_quota")]
        public bool? IsExceedQuota { get; set; }

        /// <summary>
        /// <para>数据源在 search tab 上的展示图标路径，建议使用png或jpeg格式，否则可能无法在客户端正常展示</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// <para>数据源采用的展示模版名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("template")]
        public string? Template { get; set; }

        /// <summary>
        /// <para>【已废弃，如有定制需要请使用“数据范式”接口】描述哪些字段可以被搜索</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("searchable_fields")]
        public string[]? SearchableFields { get; set; }

        /// <summary>
        /// <para>数据源的国际化展示名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public I18nMeta? I18nName { get; set; }

        /// <summary>
        /// <para>数据源的国际化描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_description")]
        public I18nMeta? I18nDescription { get; set; }

        /// <summary></summary>
        public record I18nMeta
        {
            /// <summary>
            /// <para>国际化字段：中文</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>国际化字段：英文</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }

            /// <summary>
            /// <para>国际化字段：日文</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("ja_jp")]
            public string? JaJp { get; set; }
        }

        /// <summary>
        /// <para>数据源关联的 schema 标识</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("schema_id")]
        public string? SchemaId { get; set; }
    }
}
