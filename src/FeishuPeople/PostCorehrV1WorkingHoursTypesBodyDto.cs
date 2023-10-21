using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建工时制度 请求体
/// <para>创建工时制度。</para>
/// <para>接口ID：7072647640912117762</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/working_hours_type/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fworking_hours_type%2fcreate</para>
/// </summary>
public record PostCorehrV1WorkingHoursTypesBodyDto
{
    /// <summary>
    /// <para>编码</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonProperty("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>名称</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("name")]
    public I18n[] Names { get; set; } = Array.Empty<I18n>();

    /// <summary>
    /// <para>名称</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>名称信息的语言</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonProperty("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>名称信息的内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>国家/地区 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：创建成功的工时制度信息</para>
    /// </summary>
    [JsonProperty("country_region_id_list")]
    public string[]? CountryRegionIdList { get; set; }

    /// <summary>
    /// <para>职务默认值</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("default_for_job")]
    public bool DefaultForJob { get; set; }

    /// <summary>
    /// <para>是否启用</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("active")]
    public bool Active { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>字段名</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonProperty("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"Sandy\"</para>
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; } = string.Empty;
    }
}
