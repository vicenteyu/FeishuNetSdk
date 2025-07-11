// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-07-11
// ************************************************************************
// <copyright file="PostDirectoryV1DepartmentsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建部门 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 创建部门 请求体
/// <para>本接口用于用于在企业通讯录中创建新部门，支持设置部门名称、父部门、负责人等信息。</para>
/// <para>接口ID：7359428154233536516</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fcreate</para>
/// </summary>
public record PostDirectoryV1DepartmentsBodyDto
{
    /// <summary>
    /// <para>创建部门</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("department")]
    public CreateDepartment Department { get; set; } = new();

    /// <summary>
    /// <para>创建部门</para>
    /// </summary>
    public record CreateDepartment
    {
        /// <summary>
        /// <para>标识租户内一个唯一的部门，支持自定义，未自定义时系统自动生成。ID支持修改。注意：</para>
        /// <para>1. 除需要满足正则规则外，同时不能以od-开头</para>
        /// <para>2. 正则校验：^[a-zA-Z0-9][a-zA-Z0-9_\-@.]{0,63}$</para>
        /// <para>必填：否</para>
        /// <para>示例值：eersdf</para>
        /// </summary>
        [JsonPropertyName("custom_department_id")]
        public string? CustomDepartmentId { get; set; }

        /// <summary>
        /// <para>部门名称，最多可输入 100 字</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18nText? Name { get; set; }

        /// <summary>
        /// <para>部门名称，最多可输入 100 字</para>
        /// </summary>
        public record I18nText
        {
            /// <summary>
            /// <para>默认值</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三 **数据校验规则**： 长度范围：1-64 字符</para>
            /// </summary>
            [JsonPropertyName("default_value")]
            public string DefaultValue { get; set; } = string.Empty;

            /// <summary>
            /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
            /// <para>必填：否</para>
            /// <para>示例值：{ "zh_cn": "中文", "ja_jp": "ja_jp_name", "en_us": "en_us_name" }</para>
            /// </summary>
            [JsonPropertyName("i18n_value")]
            public object? I18nValue { get; set; }
        }

        /// <summary>
        /// <para>父部门ID，与department_id_type类型保持一致</para>
        /// <para>。如果父部门为根部门，该参数值为 “0”</para>
        /// <para>必填：否</para>
        /// <para>示例值：h121900</para>
        /// </summary>
        [JsonPropertyName("parent_department_id")]
        public string? ParentDepartmentId { get; set; }

        /// <summary>
        /// <para>部门负责人</para>
        /// <para>必填：否</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("leaders")]
        public DepartmentLeader[]? Leaders { get; set; }

        /// <summary>
        /// <para>部门负责人</para>
        /// </summary>
        public record DepartmentLeader
        {
            /// <summary>
            /// <para>部门负责人类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：主</item>
            /// <item>2：副</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("leader_type")]
            public int LeaderType { get; set; }

            /// <summary>
            /// <para>部门负责人ID，与employee_id_type类型保持一致</para>
            /// <para>必填：是</para>
            /// <para>示例值：u273y71</para>
            /// </summary>
            [JsonPropertyName("leader_id")]
            public string LeaderId { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>在上级部门下的排序权重，返回结果按order_weight降序排列</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("order_weight")]
        public string? OrderWeight { get; set; }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enabled_status")]
        public bool? EnabledStatus { get; set; }

        /// <summary>
        /// <para>部门自定义字段值</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("custom_field_values")]
        public CustomFieldValue[]? CustomFieldValues { get; set; }

        /// <summary>
        /// <para>部门自定义字段值</para>
        /// </summary>
        public record CustomFieldValue
        {
            /// <summary>
            /// <para>自定义字段类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：多行文本</item>
            /// <item>2：网页链接</item>
            /// <item>3：枚举选项</item>
            /// <item>4：人员</item>
            /// <item>9：电话</item>
            /// <item>10：多选枚举类型(目前仅支持文本类型)</item>
            /// <item>11：人员列表</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("field_type")]
            public string? FieldType { get; set; }

            /// <summary>
            /// <para>文本字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("text_value")]
            public I18nText? TextValue { get; set; }

            /// <summary>
            /// <para>文本字段值</para>
            /// </summary>
            public record I18nText
            {
                /// <summary>
                /// <para>默认值</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("default_value")]
                public string DefaultValue { get; set; } = string.Empty;

                /// <summary>
                /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
                /// <para>必填：否</para>
                /// <para>示例值：{ "zh_cn": "中文", "ja_jp": "ja_jp_name", "en_us": "en_us_name" }</para>
                /// </summary>
                [JsonPropertyName("i18n_value")]
                public object? I18nValue { get; set; }
            }

            /// <summary>
            /// <para>网页链接字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("url_value")]
            public CustomFieldValueUrlValue? UrlValue { get; set; }

            /// <summary>
            /// <para>网页链接字段值</para>
            /// </summary>
            public record CustomFieldValueUrlValue
            {
                /// <summary>
                /// <para>网页标题</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("link_text")]
                public I18nText LinkText { get; set; } = new();

                /// <summary>
                /// <para>网页标题</para>
                /// </summary>
                public record I18nText
                {
                    /// <summary>
                    /// <para>默认值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("default_value")]
                    public string DefaultValue { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：{"zh_cn":"张三"}</para>
                    /// </summary>
                    [JsonPropertyName("i18n_value")]
                    public object? I18nValue { get; set; }
                }

                /// <summary>
                /// <para>移动端网页链接</para>
                /// <para>必填：是</para>
                /// <para>示例值：https://m.bytedance.com/afnasjfna</para>
                /// </summary>
                [JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;

                /// <summary>
                /// <para>桌面端网页链接</para>
                /// <para>必填：是</para>
                /// <para>示例值：http://www.fs.cn</para>
                /// </summary>
                [JsonPropertyName("pcurl")]
                public string Pcurl { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>枚举字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("enum_value")]
            public CustomFieldValueEnumValue? EnumValue { get; set; }

            /// <summary>
            /// <para>枚举字段值</para>
            /// </summary>
            public record CustomFieldValueEnumValue
            {
                /// <summary>
                /// <para>选项结果ID</para>
                /// <para>必填：是</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("enum_ids")]
                public string[] EnumIds { get; set; } = Array.Empty<string>();

                /// <summary>
                /// <para>选项类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：文本</item>
                /// <item>2：图片</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("enum_type")]
                public string EnumType { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>人员字段值</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("user_values")]
            public UserValue[]? UserValues { get; set; }

            /// <summary>
            /// <para>人员字段值</para>
            /// </summary>
            public record UserValue
            {
                /// <summary>
                /// <para>人员ID，与employee_id_type类型保持一致</para>
                /// <para>必填：是</para>
                /// <para>最大长度：100</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("ids")]
                public string[] Ids { get; set; } = Array.Empty<string>();
            }

            /// <summary>
            /// <para>电话字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("phone_value")]
            public CustomFieldValuePhoneValue? PhoneValue { get; set; }

            /// <summary>
            /// <para>电话字段值</para>
            /// </summary>
            public record CustomFieldValuePhoneValue
            {
                /// <summary>
                /// <para>电话号</para>
                /// <para>必填：是</para>
                /// <para>示例值：18812345678</para>
                /// </summary>
                [JsonPropertyName("phone_number")]
                public string PhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// <para>分机号</para>
                /// <para>必填：否</para>
                /// <para>示例值：234234234 长度范围：0-99字符</para>
                /// </summary>
                [JsonPropertyName("extension_number")]
                public string? ExtensionNumber { get; set; }
            }

            /// <summary>
            /// <para>自定义字段key</para>
            /// <para>必填：否</para>
            /// <para>示例值：C-1000001</para>
            /// </summary>
            [JsonPropertyName("field_key")]
            public string? FieldKey { get; set; }
        }
    }
}
