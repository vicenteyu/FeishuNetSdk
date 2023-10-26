using Newtonsoft.Json;
namespace FeishuNetSdk.Search.Spec;
/// <summary>
/// 修改数据源 请求体
/// <para>更新一个已经存在的数据源。</para>
/// <para>接口ID：6953505452630179843</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/data_source/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdata_source%2fpatch</para>
/// </summary>
public record PatchSearchV2DataSourcesByDataSourceIdBodyDto
{
    /// <summary>
    /// <para>数据源的展示名称</para>
    /// <para>**示例值**："客服工单"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>数据源状态，0-已上线，1-未上线</para>
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
    /// <para>**示例值**："搜索客服工单"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>数据源在 search tab 上的展示图标路径</para>
    /// <para>**示例值**："https://www.xxx.com/open.jpg"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("icon_url")]
    public string? IconUrl { get; set; }

    /// <summary>
    /// <para>数据源名称多语言配置，json格式，key为语言locale，value为对应文案，例如{"zh_cn":"测试数据源", "en_us":"Test DataSource"}</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("i18n_name")]
    public I18nMeta? I18nName { get; set; }

    /// <summary>
    /// <para>数据源描述多语言配置，json格式，key为语言locale，value为对应文案，例如{"zh_cn":"搜索测试数据源相关数据", "en_us":"Search data from Test DataSource"}</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("i18n_description")]
    public I18nMeta? I18nDescription { get; set; }

    /// <summary></summary>
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
}
