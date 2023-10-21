using Newtonsoft.Json;
namespace FeishuNetSdk.Search.Spec;
/// <summary>
/// 创建数据源 请求体
/// <para>创建一个数据源。</para>
/// <para>接口ID：6953505452630212611</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/data_source/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdata_source%2fcreate</para>
/// </summary>
public record PostSearchV2DataSourcesBodyDto
{
    /// <summary>
    /// <para>data_source的展示名称</para>
    /// <para>**示例值**："客服工单"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>数据源状态，0-已上线，1-未上线。如果未填，默认是未上线状态。</para>
    /// <para>**示例值**：0</para>
    /// <para>**可选值有**：</para>
    /// <para>0:已上线,1:未上线</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：已上线</item>
    /// <item>1：未上线</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("state")]
    public int? State { get; set; }

    /// <summary>
    /// <para>对于数据源的描述</para>
    /// <para>**示例值**："搜索客服工单数据"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>数据源在 search tab 上的展示图标路径，建议使用png或jpeg格式，否则可能无法在客户端正常展示</para>
    /// <para>**示例值**："https://www.xxx.com/open.jpg"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("icon_url")]
    public string? IconUrl { get; set; }

    /// <summary>
    /// <para>数据源采用的展示模版名称</para>
    /// <para>**示例值**："search_common_card"</para>
    /// <para>**默认值**：`search_common_card`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("template")]
    public string? Template { get; set; }

    /// <summary>
    /// <para>【已废弃，如有定制需要请使用“数据范式”接口】描述哪些字段可以被搜索</para>
    /// <para>**示例值**：【已废弃，如有定制需要请使用“数据范式”接口】["field1", "field2"]</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("searchable_fields")]
    public string[]? SearchableFields { get; set; }

    /// <summary>
    /// <para>数据源的国际化展示名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("i18n_name")]
    public I18nMeta? I18nName { get; set; }

    /// <summary>
    /// <para>数据源的国际化描述</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("i18n_description")]
    public I18nMeta? I18nDescription { get; set; }

    public record I18nMeta
    {
        /// <summary>
        /// <para>国际化字段：中文</para>
        /// <para>**示例值**："任务"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("zh_cn")]
        public string? ZhCn { get; set; }

        /// <summary>
        /// <para>国际化字段：英文</para>
        /// <para>**示例值**："TODO"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("en_us")]
        public string? EnUs { get; set; }

        /// <summary>
        /// <para>国际化字段：日文</para>
        /// <para>**示例值**："タスク"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("ja_jp")]
        public string? JaJp { get; set; }
    }

    /// <summary>
    /// <para>数据源关联的 schema 标识</para>
    /// <para>**示例值**："custom_schema"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("schema_id")]
    public string? SchemaId { get; set; }
}
