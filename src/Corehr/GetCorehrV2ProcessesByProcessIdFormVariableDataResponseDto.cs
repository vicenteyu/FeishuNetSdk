// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV2ProcessesByProcessIdFormVariableDataResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取流程表单数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取流程表单数据 响应体
/// <para>根据流程实例 id（process_id）获取流程表单字段数据，包括表单里的业务字段和自定义字段。仅支持飞书人事、假勤相关业务流程。</para>
/// <para>注：[旧版 API](https://open.larkoffice.com/document/server-docs/corehr-v1/process-form_variable_data/get) 文档已移动到【历史版本】目录。</para>
/// <para>接口ID：7362022982036717571</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process-form_variable_data/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-form_variable_data%2fget</para>
/// </summary>
public record GetCorehrV2ProcessesByProcessIdFormVariableDataResponseDto
{
    /// <summary>
    /// <para>表单数据</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("field_variable_values")]
    public FieldVariableValue[]? FieldVariableValues { get; set; }

    /// <summary>
    /// <para>表单数据</para>
    /// </summary>
    public record FieldVariableValue
    {
        /// <summary>
        /// <para>变量唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：custom123</para>
        /// </summary>
        [JsonPropertyName("variable_api_name")]
        public string? VariableApiName { get; set; }

        /// <summary>
        /// <para>变量名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：日期</para>
        /// </summary>
        [JsonPropertyName("variable_name")]
        public FieldVariableValueI18n? VariableName { get; set; }

        /// <summary>
        /// <para>变量名称</para>
        /// </summary>
        public record FieldVariableValueI18n
        {
            /// <summary>
            /// <para>中文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：北京</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：Beijing</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>变量值</para>
        /// <para>必填：否</para>
        /// <para>示例值：aa</para>
        /// </summary>
        [JsonPropertyName("variable_value")]
        public FieldVariableValueTo? VariableValue { get; set; }

        /// <summary>
        /// <para>变量值</para>
        /// </summary>
        public record FieldVariableValueTo
        {
            /// <summary>
            /// <para>文本值</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试测试</para>
            /// </summary>
            [JsonPropertyName("text_value")]
            public string? TextValue { get; set; }

            /// <summary>
            /// <para>布尔值</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("bool_value")]
            public bool? BoolValue { get; set; }

            /// <summary>
            /// <para>数字值</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("number_value")]
            public string? NumberValue { get; set; }

            /// <summary>
            /// <para>枚举值，这里是枚举的 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：home_address</para>
            /// </summary>
            [JsonPropertyName("enum_value")]
            public string? EnumValue { get; set; }

            /// <summary>
            /// <para>日期值，单位：天。从 1970 年 1 月 1 日 (UTC/GMT的午夜) 开始经过的天数</para>
            /// <para>**示例值**：19688</para>
            /// <para>必填：否</para>
            /// <para>示例值：19838</para>
            /// </summary>
            [JsonPropertyName("date_value")]
            public string? DateValue { get; set; }

            /// <summary>
            /// <para>时间值，单位：ms。从 1970 年 1 月 1 日 (UTC/GMT的午夜) 开始经过的毫秒数</para>
            /// <para>**示例值**：1719549169735</para>
            /// <para>必填：否</para>
            /// <para>示例值：1714013877512</para>
            /// </summary>
            [JsonPropertyName("date_time_value")]
            public string? DateTimeValue { get; set; }

            /// <summary>
            /// <para>多语字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("i18n_value")]
            public FieldVariableValueI18n? I18nValue { get; set; }

            /// <summary>
            /// <para>多语字段值</para>
            /// </summary>
            public record FieldVariableValueI18n
            {
                /// <summary>
                /// <para>中文值</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文值</para>
                /// <para>必填：否</para>
                /// <para>示例值：Beijing</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>对象值</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("object_value")]
            public FieldVariableValueToObject? ObjectValue { get; set; }

            /// <summary>
            /// <para>对象值</para>
            /// </summary>
            public record FieldVariableValueToObject
            {
                /// <summary>
                /// <para>飞书主数据对象唯一标识。（可通过[飞书主数据概述](https://open.larkoffice.com/document/server-docs/mdm-v1/summary)了解更多信息。）</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326263210149383</para>
                /// </summary>
                [JsonPropertyName("wk_id")]
                public string? WkId { get; set; }

                /// <summary>
                /// <para>飞书元数据对象的唯一标识。可基于该字段，通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取更多相关字段的详情。</para>
                /// <para>必填：否</para>
                /// <para>示例值：country_region_subdivision</para>
                /// </summary>
                [JsonPropertyName("wk_api_name")]
                public string? WkApiName { get; set; }
            }

            /// <summary>
            /// <para>用户 id，根据查询参数 user_id_type 选择对应的用户 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
            /// </summary>
            [JsonPropertyName("user_value")]
            public string? UserValue { get; set; }

            /// <summary>
            /// <para>部门 id，根据查询参数 department_id_type 选择对应的部门 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-a761814f6bc3f14bd3b00905ec1d7c6f</para>
            /// </summary>
            [JsonPropertyName("department_value")]
            public string? DepartmentValue { get; set; }

            /// <summary>
            /// <para>记录类型字段值</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("record_value")]
            public FieldVariableValueToRecord? RecordValue { get; set; }

            /// <summary>
            /// <para>记录类型字段值</para>
            /// </summary>
            public record FieldVariableValueToRecord
            {
                /// <summary>
                /// <para>变量唯一标识</para>
                /// <para>必填：否</para>
                /// <para>示例值：city_v2</para>
                /// </summary>
                [JsonPropertyName("variable_api_name")]
                public string? VariableApiName { get; set; }

                /// <summary>
                /// <para>变量值，对应 sub_values 中的 key</para>
                /// <para>必填：否</para>
                /// <para>示例值：key1</para>
                /// </summary>
                [JsonPropertyName("variable_value")]
                public string? VariableValue { get; set; }
            }

            /// <summary>
            /// <para>员工类型字段值，为用户 id，根据入参选择返回的用户 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
            /// </summary>
            [JsonPropertyName("employment_value")]
            public string? EmploymentValue { get; set; }

            /// <summary>
            /// <para>数组类型值，里面包含多个值，每个元素都对应 sub_values 中的数组下标</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("list_values")]
            public string[]? ListValues { get; set; }
        }

        /// <summary>
        /// <para>在 list_values 和 record_values 中引用的变量</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("sub_values")]
        public FieldVariableSubVlaue[]? SubValues { get; set; }

        /// <summary>
        /// <para>在 list_values 和 record_values 中引用的变量</para>
        /// </summary>
        public record FieldVariableSubVlaue
        {
            /// <summary>
            /// <para>用于关联 list 和 record 类型变量值中的 key</para>
            /// <para>必填：否</para>
            /// <para>示例值：key1</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string? Key { get; set; }

            /// <summary>
            /// <para>变量值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public FieldVariableValueTo? Value { get; set; }

            /// <summary>
            /// <para>变量值</para>
            /// </summary>
            public record FieldVariableValueTo
            {
                /// <summary>
                /// <para>文本值</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试测试</para>
                /// </summary>
                [JsonPropertyName("text_value")]
                public string? TextValue { get; set; }

                /// <summary>
                /// <para>布尔值</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("bool_value")]
                public bool? BoolValue { get; set; }

                /// <summary>
                /// <para>数字值</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("number_value")]
                public string? NumberValue { get; set; }

                /// <summary>
                /// <para>枚举值，这里是枚举的 id</para>
                /// <para>必填：否</para>
                /// <para>示例值：home_address</para>
                /// </summary>
                [JsonPropertyName("enum_value")]
                public string? EnumValue { get; set; }

                /// <summary>
                /// <para>日期值，单位：天。从 1970 年 1 月 1 日 (UTC/GMT的午夜) 开始经过的天数</para>
                /// <para>必填：否</para>
                /// <para>示例值：19838</para>
                /// </summary>
                [JsonPropertyName("date_value")]
                public string? DateValue { get; set; }

                /// <summary>
                /// <para>时间值，单位：ms。从 1970 年 1 月 1 日 (UTC/GMT的午夜) 开始经过的毫秒数</para>
                /// <para>**示例值**：1719549169735</para>
                /// <para>必填：否</para>
                /// <para>示例值：1714013877512</para>
                /// </summary>
                [JsonPropertyName("date_time_value")]
                public string? DateTimeValue { get; set; }

                /// <summary>
                /// <para>多语字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("i18n_value")]
                public FieldVariableValueI18n? I18nValue { get; set; }

                /// <summary>
                /// <para>多语字段值</para>
                /// </summary>
                public record FieldVariableValueI18n
                {
                    /// <summary>
                    /// <para>中文值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：北京</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Beijing</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>对象值</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("object_value")]
                public FieldVariableValueToObject? ObjectValue { get; set; }

                /// <summary>
                /// <para>对象值</para>
                /// </summary>
                public record FieldVariableValueToObject
                {
                    /// <summary>
                    /// <para>飞书主数据对象唯一标识。（可通过[飞书主数据概述](https://open.larkoffice.com/document/server-docs/mdm-v1/summary)了解更多信息。）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6863326263210149383</para>
                    /// </summary>
                    [JsonPropertyName("wk_id")]
                    public string? WkId { get; set; }

                    /// <summary>
                    /// <para>飞书人事 Wukong 元数据唯一标识</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：country_region_subdivision</para>
                    /// </summary>
                    [JsonPropertyName("wk_api_name")]
                    public string? WkApiName { get; set; }
                }

                /// <summary>
                /// <para>用户 id，根据查询参数 user_id_type 选择对应的用户 id</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
                /// </summary>
                [JsonPropertyName("user_value")]
                public string? UserValue { get; set; }

                /// <summary>
                /// <para>部门 id，根据查询参数 department_id_type 选择对应的部门 id</para>
                /// <para>必填：否</para>
                /// <para>示例值：od-a761814f6bc3f14bd3b00905ec1d7c6f</para>
                /// </summary>
                [JsonPropertyName("department_value")]
                public string? DepartmentValue { get; set; }

                /// <summary>
                /// <para>记录类型字段值</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("record_value")]
                public FieldVariableValueToRecord? RecordValue { get; set; }

                /// <summary>
                /// <para>记录类型字段值</para>
                /// </summary>
                public record FieldVariableValueToRecord
                {
                    /// <summary>
                    /// <para>变量唯一标识</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：city_v2</para>
                    /// </summary>
                    [JsonPropertyName("variable_api_name")]
                    public string? VariableApiName { get; set; }

                    /// <summary>
                    /// <para>变量值，对应 sub_values 中的 key</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：key1</para>
                    /// </summary>
                    [JsonPropertyName("variable_value")]
                    public string? VariableValue { get; set; }
                }

                /// <summary>
                /// <para>员工类型字段值，为用户 id，根据入参选择返回的用户 id</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
                /// </summary>
                [JsonPropertyName("employment_value")]
                public string? EmploymentValue { get; set; }

                /// <summary>
                /// <para>数组类型值，里面包含多个值，每个元素都对应 sub_values 中的数组下标</para>
                /// <para>必填：否</para>
                /// <para>最大长度：10000</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("list_values")]
                public string[]? ListValues { get; set; }
            }
        }
    }
}
