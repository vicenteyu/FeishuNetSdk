using Newtonsoft.Json;
namespace FeishuNetSdk.Search.Spec;
/// <summary>
/// 修改数据范式 请求体
/// <para>修改数据范式。</para>
/// <para>接口ID：7100866111462211612</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/schema/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fschema%2fpatch</para>
/// </summary>
public record PatchSearchV2SchemasBySchemaIdBodyDto
{
    /// <summary>
    /// <para>数据展示相关配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("display")]
    public SchemaDisplay? Display { get; set; }

    /// <summary></summary>
    public record SchemaDisplay
    {
        /// <summary>
        /// <para>搜索数据的展示卡片</para>
        /// <para>卡片详细信息请参考 [通用模块接入指南](/document/uAjLw4CM/ukTMukTMukTM/search-v2/common-template-intergration-handbook) "请求创建数据范式"部分</para>
        /// <para>**示例值**："search_common_card"</para>
        /// <para>**可选值有**：</para>
        /// <para>search_common_card:普通 common 卡片</para>
        /// <para>必填：是</para>
        /// <para>可选值：<list type="bullet">
        /// <item>search_common_card：普通common卡片</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("card_key")]
        public string CardKey { get; set; } = string.Empty;

        /// <summary>
        /// <para>数据字段名称和展示字段名称的映射关系。如果没有设置，则只会展示 与展示字段名称同名的 数据字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("fields_mapping")]
        public SchemaDisplayFieldMapping[]? FieldsMapping { get; set; }

        /// <summary></summary>
        public record SchemaDisplayFieldMapping
        {
            /// <summary>
            /// <para>展示字段名称，与 card_key 有关，每个模版能展示的字段不同。该字段不能重复</para>
            /// <para>**示例值**："summary"</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("display_field")]
            public string DisplayField { get; set; } = string.Empty;

            /// <summary>
            /// <para>数据字段的名称。需要确保该字段对应在 schema 属性定义中的 is_returnable 为 true，否则无法展示。需要使用 ${xxx} 的规则来描述</para>
            /// <para>**示例值**："${description}"</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("data_field")]
            public string DataField { get; set; } = string.Empty;
        }
    }
}
