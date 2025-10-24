// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="GetCorehrV2ProcessesByProcessIdFlowVariableDataResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取流程数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取流程数据 响应体
/// <para>根据流程实例 id（process_id）获取流程字段数据，包括业务字段和自定义字段。仅支持飞书人事、假勤相关业务流程。</para>
/// <para>接口ID：7455284757275262995</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/process-instance/flow_variable_data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess%2fflow_variable_data</para>
/// </summary>
public record GetCorehrV2ProcessesByProcessIdFlowVariableDataResponseDto
{
    /// <summary>
    /// <para>流程数据</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10000</para>
    /// </summary>
    [JsonPropertyName("field_variable_values")]
    public FieldVariableValue[]? FieldVariableValues { get; set; }

    /// <summary>
    /// <para>流程数据</para>
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
            /// <para>枚举值，这里是枚举的id</para>
            /// <para>必填：否</para>
            /// <para>示例值：home_address</para>
            /// </summary>
            [JsonPropertyName("enum_value")]
            public string? EnumValue { get; set; }

            /// <summary>
            /// <para>从 1970 开始的天数</para>
            /// <para>必填：否</para>
            /// <para>示例值：19838</para>
            /// </summary>
            [JsonPropertyName("date_value")]
            public string? DateValue { get; set; }

            /// <summary>
            /// <para>时间戳，毫秒</para>
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
            /// <para>对象值，包括对象id和对象类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("object_value")]
            public FieldVariableValueToObject? ObjectValue { get; set; }

            /// <summary>
            /// <para>对象值，包括对象id和对象类型</para>
            /// </summary>
            public record FieldVariableValueToObject
            {
                /// <summary>
                /// <para>wukong的对象唯一标识</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326263210149383</para>
                /// </summary>
                [JsonPropertyName("wk_id")]
                public string? WkId { get; set; }

                /// <summary>
                /// <para>wukong的元数据唯一标识</para>
                /// <para>必填：否</para>
                /// <para>示例值：country_region_subdivision</para>
                /// </summary>
                [JsonPropertyName("wk_api_name")]
                public string? WkApiName { get; set; }
            }

            /// <summary>
            /// <para>用户id，根据user_type选择对应的用户id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
            /// </summary>
            [JsonPropertyName("user_value")]
            public string? UserValue { get; set; }

            /// <summary>
            /// <para>部门id，根据入参选择对应的部门id</para>
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
            [JsonPropertyName("record_values")]
            public FieldVariableValueToRecord[]? RecordValues { get; set; }

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
                /// <para>变量值，对应subValues中的key</para>
                /// <para>必填：否</para>
                /// <para>示例值：key1</para>
                /// </summary>
                [JsonPropertyName("sub_value_key")]
                public string? SubValueKey { get; set; }

                /// <summary>
                /// <para>记录唯一ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326263210149383</para>
                /// </summary>
                [JsonPropertyName("record_id")]
                public string? RecordId { get; set; }
            }

            /// <summary>
            /// <para>员工类型字段值，为用户id，根据入参选择返回的用户id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("employment_value")]
            public string? EmploymentValue { get; set; }

            /// <summary>
            /// <para>数组类型值，里面包含多个值，每个元素都对应subValues中的数组下标</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("list_values")]
            public string[]? ListValues { get; set; }

            /// <summary>
            /// <para>文件类型字段值，可通过主数据的文件下载Open API下载</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("file_value")]
            public FieldVariableValueToFile? FileValue { get; set; }

            /// <summary>
            /// <para>文件类型字段值，可通过主数据的文件下载Open API下载</para>
            /// </summary>
            public record FieldVariableValueToFile
            {
                /// <summary>
                /// <para>用于主数据文件下载接口的id</para>
                /// <para>必填：否</para>
                /// <para>示例值：66867ed00740ddd4a0bad4a5_c99b5322dc744fe4b99b76426ffe5d53</para>
                /// </summary>
                [JsonPropertyName("open_file_id")]
                public string? OpenFileId { get; set; }

                /// <summary>
                /// <para>文件名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：file_name</para>
                /// </summary>
                [JsonPropertyName("file_name")]
                public string? FileName { get; set; }

                /// <summary>
                /// <para>文件大小，单位：Byte</para>
                /// <para>必填：否</para>
                /// <para>示例值：65535</para>
                /// </summary>
                [JsonPropertyName("length")]
                public int? Length { get; set; }

                /// <summary>
                /// <para>文件类型，如`application/pdf`</para>
                /// <para>必填：否</para>
                /// <para>示例值：application/pdf</para>
                /// </summary>
                [JsonPropertyName("mime_type")]
                public string? MimeType { get; set; }
            }
        }

        /// <summary>
        /// <para>在list_values和record_values中引用的变量</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("sub_values")]
        public FieldVariableSubVlaue[]? SubValues { get; set; }

        /// <summary>
        /// <para>在list_values和record_values中引用的变量</para>
        /// </summary>
        public record FieldVariableSubVlaue
        {
            /// <summary>
            /// <para>用于关联list和record类型变量值中的key</para>
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
                /// <para>枚举值，这里是枚举的id</para>
                /// <para>必填：否</para>
                /// <para>示例值：home_address</para>
                /// </summary>
                [JsonPropertyName("enum_value")]
                public string? EnumValue { get; set; }

                /// <summary>
                /// <para>从 1970 开始的天数</para>
                /// <para>必填：否</para>
                /// <para>示例值：19838</para>
                /// </summary>
                [JsonPropertyName("date_value")]
                public string? DateValue { get; set; }

                /// <summary>
                /// <para>时间戳，毫秒</para>
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
                /// <para>对象值，包括对象id和对象类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("object_value")]
                public FieldVariableValueToObject? ObjectValue { get; set; }

                /// <summary>
                /// <para>对象值，包括对象id和对象类型</para>
                /// </summary>
                public record FieldVariableValueToObject
                {
                    /// <summary>
                    /// <para>wukong的对象唯一标识</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6863326263210149383</para>
                    /// </summary>
                    [JsonPropertyName("wk_id")]
                    public string? WkId { get; set; }

                    /// <summary>
                    /// <para>wukong的元数据唯一标识</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：country_region_subdivision</para>
                    /// </summary>
                    [JsonPropertyName("wk_api_name")]
                    public string? WkApiName { get; set; }
                }

                /// <summary>
                /// <para>用户id，根据user_type选择对应的用户id</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
                /// </summary>
                [JsonPropertyName("user_value")]
                public string? UserValue { get; set; }

                /// <summary>
                /// <para>部门id，根据入参选择对应的部门id</para>
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
                [JsonPropertyName("record_values")]
                public FieldVariableValueToRecord[]? RecordValues { get; set; }

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
                    /// <para>变量值，对应subValues中的key</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：key1</para>
                    /// </summary>
                    [JsonPropertyName("sub_value_key")]
                    public string? SubValueKey { get; set; }

                    /// <summary>
                    /// <para>记录唯一ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6863326263210149383</para>
                    /// </summary>
                    [JsonPropertyName("record_id")]
                    public string? RecordId { get; set; }
                }

                /// <summary>
                /// <para>员工类型字段值，为用户id，根据入参选择返回的用户id</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
                /// <para>最大长度：10000</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("employment_value")]
                public string? EmploymentValue { get; set; }

                /// <summary>
                /// <para>数组类型值，里面包含多个值，每个元素都对应subValues中的数组下标</para>
                /// <para>必填：否</para>
                /// <para>最大长度：10000</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("list_values")]
                public string[]? ListValues { get; set; }

                /// <summary>
                /// <para>文件类型字段值，可通过主数据的文件下载Open API下载</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("file_value")]
                public FieldVariableValueToFile? FileValue { get; set; }

                /// <summary>
                /// <para>文件类型字段值，可通过主数据的文件下载Open API下载</para>
                /// </summary>
                public record FieldVariableValueToFile
                {
                    /// <summary>
                    /// <para>用于主数据文件下载接口的id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：66867ed00740ddd4a0bad4a5_c99b5322dc744fe4b99b76426ffe5d53</para>
                    /// </summary>
                    [JsonPropertyName("open_file_id")]
                    public string? OpenFileId { get; set; }

                    /// <summary>
                    /// <para>文件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：file_name</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>文件大小，单位：Byte</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：65535</para>
                    /// </summary>
                    [JsonPropertyName("length")]
                    public int? Length { get; set; }

                    /// <summary>
                    /// <para>文件类型，如`application/pdf`</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：application/pdf</para>
                    /// </summary>
                    [JsonPropertyName("mime_type")]
                    public string? MimeType { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>流程实例id</para>
    /// <para>必填：否</para>
    /// <para>示例值：7368832822481536556</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }
}
