using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建部门 请求体
/// <para>创建部门。</para>
/// <para>接口ID：7072646559953797122</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fdepartment%2fcreate</para>
/// </summary>
public record PostCorehrV1DepartmentsBodyDto
{
    /// <summary>
    /// <para>子类型</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("sub_type")]
    public Enum? SubType { get; set; }

    /// <summary>
    /// <para>子类型</para>
    /// </summary>
    public record Enum
    {
        /// <summary>
        /// <para>枚举值</para>
        /// <para>必填：是</para>
        /// <para>示例值：type_1</para>
        /// </summary>
        [JsonProperty("enum_name")]
        public string EnumName { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>部门负责人</para>
    /// <para>必填：否</para>
    /// <para>示例值：6893013238632416776</para>
    /// </summary>
    [JsonProperty("manager")]
    public string? Manager { get; set; }

    /// <summary>
    /// <para>是否保密</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("is_confidential")]
    public bool IsConfidential { get; set; }

    /// <summary>
    /// <para>层级关系，内层字段见实体</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("hiberarchy_common")]
    public PostCorehrV1DepartmentsBodyDtoHiberarchyCommon HiberarchyCommon { get; set; } = new();

    /// <summary>
    /// <para>层级关系，内层字段见实体</para>
    /// </summary>
    public record PostCorehrV1DepartmentsBodyDtoHiberarchyCommon
    {
        /// <summary>
        /// <para>上级组织 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719168654814483759</para>
        /// </summary>
        [JsonProperty("parent_id")]
        public string? ParentId { get; set; }

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
        /// <para>组织类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)组织类型（organization_type）枚举定义部分获得</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("type")]
        public Enum Type { get; set; } = new();

        /// <summary>
        /// <para>组织类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)组织类型（organization_type）枚举定义部分获得</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：type_1</para>
            /// </summary>
            [JsonProperty("enum_name")]
            public string EnumName { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>失效时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-0200:00:00</para>
        /// </summary>
        [JsonProperty("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：12456</para>
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("description")]
        public I18n[]? Descriptions { get; set; }

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

    /// <summary>
    /// <para>生效时间</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-05-0100:00:00</para>
    /// </summary>
    [JsonProperty("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>失效时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-05-0200:00:00</para>
    /// </summary>
    [JsonProperty("expiration_time")]
    public string? ExpirationTime { get; set; }

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

    /// <summary>
    /// <para>成本中心id</para>
    /// <para>必填：否</para>
    /// <para>示例值：7142384817131652652</para>
    /// </summary>
    [JsonProperty("cost_center_id")]
    public string? CostCenterId { get; set; }
}
