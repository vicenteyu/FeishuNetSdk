// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-02-06
//
// Last Modified By : yxr
// Last Modified On : 2026-02-06
// ************************************************************************
// <copyright file="PostCorehrV2ProcessStartBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发起流程 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 发起流程 请求体
/// <para>发起一个流程实例，目前只支持发起自定义业务类型的流程。</para>
/// <para>接口ID：7451908159096766468</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/process-instance/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess_start%2fcreate</para>
/// </summary>
public record PostCorehrV2ProcessStartBodyDto
{
    /// <summary>
    /// <para>流程定义id</para>
    /// <para>必填：是</para>
    /// <para>示例值：people_7023711013443944467_7437160904904494892</para>
    /// </summary>
    [JsonPropertyName("flow_definition_id")]
    public string FlowDefinitionId { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起人用户ID，按user_id_type类型传递。如果system_initiator为false，则必填；为true时非必填。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_91791271921729102012</para>
    /// </summary>
    [JsonPropertyName("initiator_id")]
    public string? InitiatorId { get; set; }

    /// <summary>
    /// <para>是否为系统身份发起流程，如果为false，则initiator_id必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("system_initiator")]
    public bool? SystemInitiator { get; set; }

    /// <summary>
    /// <para>业务数据</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("flow_data")]
    public ProcessFormVariableV2[]? FlowDatas { get; set; }

    /// <summary>
    /// <para>业务数据</para>
    /// </summary>
    public record ProcessFormVariableV2
    {
        /// <summary>
        /// <para>变量唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：custom123</para>
        /// </summary>
        [JsonPropertyName("variable_api_name")]
        public string? VariableApiName { get; set; }

        /// <summary>
        /// <para>变量值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("variable_value")]
        public FieldVariableValueToForReview? VariableValue { get; set; }

        /// <summary>
        /// <para>变量值</para>
        /// </summary>
        public record FieldVariableValueToForReview
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
            /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
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
            /// <para>示例值：od-a761814f6bc3f14bd3b00905ec1d7c6f</para>
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
            /// <para>部门id，根据入参选择对应的部门id</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-a761814f6bc3f14bd3b00905ec1d7c6f</para>
            /// </summary>
            [JsonPropertyName("department_value")]
            public string? DepartmentValue { get; set; }

            /// <summary>
            /// <para>员工类型字段值，为用户id，根据入参选择返回的用户id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
            /// </summary>
            [JsonPropertyName("employment_value")]
            public string? EmploymentValue { get; set; }

            /// <summary>
            /// <para>数组类型值，里面包含多个值，每个元素都对应subValues中的key</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("list_values")]
            public string[]? ListValues { get; set; }

            /// <summary>
            /// <para>文件类型字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("file_value")]
            public FieldVariableValueToFileForWrite? FileValue { get; set; }

            /// <summary>
            /// <para>文件类型字段值</para>
            /// </summary>
            public record FieldVariableValueToFileForWrite
            {
                /// <summary>
                /// <para>通过[上传文件接口](https://open.larkoffice.com/document/server-docs/corehr-v1/employee/person/upload)获得的id</para>
                /// <para>必填：否</para>
                /// <para>示例值：66867ed00740ddd4a0bad4a5_c99b5322dc744fe4b99b76426ffe5d53</para>
                /// </summary>
                [JsonPropertyName("open_file_id")]
                public string? OpenFileId { get; set; }

                /// <summary>
                /// <para>文件名称（需带有文件后缀），如果填写，则会覆盖上传文件的名称，否则通过open_file_id获取原始名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：file_name.jpg</para>
                /// </summary>
                [JsonPropertyName("file_name")]
                public string? FileName { get; set; }

                /// <summary>
                /// <para>文件大小，单位：Byte，如果填写，则会覆盖上传文件的大小，否则通过open_file_id获取文件原始大小</para>
                /// <para>必填：否</para>
                /// <para>示例值：65535</para>
                /// <para>最大值：52428800</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("length")]
                public int? Length { get; set; }
            }

            /// <summary>
            /// <para>record类型字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("record_values")]
            public FieldVariableValueToRecord[]? RecordValues { get; set; }

            /// <summary>
            /// <para>record类型字段值</para>
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
        }

        /// <summary>
        /// <para>在list_values和record_values中引用的变量</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("sub_values")]
        public FieldVariableSubVlaueForReview[]? SubValues { get; set; }

        /// <summary>
        /// <para>在list_values和record_values中引用的变量</para>
        /// </summary>
        public record FieldVariableSubVlaueForReview
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
            public FieldVariableValueToForReview? Value { get; set; }

            /// <summary>
            /// <para>变量值</para>
            /// </summary>
            public record FieldVariableValueToForReview
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
                /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
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
                /// <para>示例值：od-a761814f6bc3f14bd3b00905ec1d7c6f</para>
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
                /// <para>部门id，根据入参选择对应的部门id</para>
                /// <para>必填：否</para>
                /// <para>示例值：od-a761814f6bc3f14bd3b00905ec1d7c6f</para>
                /// </summary>
                [JsonPropertyName("department_value")]
                public string? DepartmentValue { get; set; }

                /// <summary>
                /// <para>员工类型字段值，为用户id，根据入参选择返回的用户id</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
                /// </summary>
                [JsonPropertyName("employment_value")]
                public string? EmploymentValue { get; set; }

                /// <summary>
                /// <para>数组类型值，里面包含多个值，每个元素都对应subValues中的key</para>
                /// <para>必填：否</para>
                /// <para>最大长度：10000</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("list_values")]
                public string[]? ListValues { get; set; }

                /// <summary>
                /// <para>文件类型字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("file_value")]
                public FieldVariableValueToFileForWrite? FileValue { get; set; }

                /// <summary>
                /// <para>文件类型字段值</para>
                /// </summary>
                public record FieldVariableValueToFileForWrite
                {
                    /// <summary>
                    /// <para>通过[上传文件接口](https://open.larkoffice.com/document/server-docs/corehr-v1/employee/person/upload)获得的id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：66867ed00740ddd4a0bad4a5_c99b5322dc744fe4b99b76426ffe5d53</para>
                    /// </summary>
                    [JsonPropertyName("open_file_id")]
                    public string? OpenFileId { get; set; }

                    /// <summary>
                    /// <para>文件名称（需带有文件后缀），如果填写，则会覆盖上传文件的名称，否则通过open_file_id获取原始名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：file_name.jpg</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>文件大小，单位：Byte，如果填写，则会覆盖上传文件的大小，否则通过open_file_id获取文件原始大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：65535</para>
                    /// <para>最大值：52428800</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("length")]
                    public int? Length { get; set; }
                }

                /// <summary>
                /// <para>record类型字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("record_values")]
                public FieldVariableValueToRecord[]? RecordValues { get; set; }

                /// <summary>
                /// <para>record类型字段值</para>
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
            }
        }
    }
}
