using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建人员类型 响应体
/// <para>创建人员类型。</para>
/// <para>接口ID：7017707615190892547</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/employee_type/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployee_type%2fcreate</para>
/// </summary>
public record PostCorehrV1EmployeeTypesResponseDto
{
    /// <summary>
    /// <para>创建成功的人员类型信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("employee_type")]
    public PostCorehrV1EmployeeTypesResponseDtoEmployeeType? EmployeeType { get; set; }

    /// <summary>
    /// <para>创建成功的人员类型信息</para>
    /// </summary>
    public record PostCorehrV1EmployeeTypesResponseDtoEmployeeType
    {
        /// <summary>
        /// <para>雇员类型ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6919732473504990727</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

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
        /// <para>是否为默认人员类型，每个租户只能定义一个默认人员类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("default_employee_type")]
        public bool DefaultEmployeeType { get; set; }

        /// <summary>
        /// <para>启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：1245</para>
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

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
}
