// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-24
// ************************************************************************
// <copyright file="PutCorehrV2ProcessesByProcessIdApproversByApproverIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过/拒绝审批任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 通过/拒绝审批任务 请求体
/// <para>对于单个审批任务进行通过（提交）或拒绝操作。对于多人或签节点，一个审批任务通过则整个节点通过；对于多人会签节点，所有审批任务通过则节点通过。在通过（提交）时，若表单中有必填字段，支持写入表单字段。</para>
/// <para>接口ID：7340625370520797187</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process-approver/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-approver%2fupdate</para>
/// </summary>
public record PutCorehrV2ProcessesByProcessIdApproversByApproverIdBodyDto
{
    /// <summary>
    /// <para>将审批任务修改为同意/拒绝</para>
    /// <para>必填：是</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>2：拒绝</item>
    /// <item>3：通过</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// <para>用户id，按user_id_type类型传递。如果system_approval为false，则必填审批任务“approver_id”对应的原审批人的user_id；为true时非必填。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_91791271921729102012</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>是否为系统身份审批。</para>
    /// <para>true - 使用系统身份审批，若使用系统身份，将代替approver_id对应的原审批人进行审批，原审批人将失去审批任务的查看权限；false - 按照所传的人员身份审批</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("system_approval")]
    public bool? SystemApproval { get; set; }

    /// <summary>
    /// <para>通过原因，长度限制为500</para>
    /// <para>**默认值**：""</para>
    /// <para>必填：否</para>
    /// <para>示例值：原因自定义字符串</para>
    /// <para>最大长度：500</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>
    /// <para>表单数据</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("field_values_v2")]
    public ProcessFormVariableV2[]? FieldValuesV2s { get; set; }

    /// <summary>
    /// <para>表单数据</para>
    /// </summary>
    public record ProcessFormVariableV2
    {
        /// <summary>
        /// <para>变量唯一标识，可通过[获取流程表单数据](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process-form_variable_data/get)查询变量</para>
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
            /// <para>对象值</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-a761814f6bc3f14bd3b00905ec1d7c6f</para>
            /// </summary>
            [JsonPropertyName("object_value")]
            public FieldVariableValueToObject? ObjectValue { get; set; }

            /// <summary>
            /// <para>对象值</para>
            /// </summary>
            public record FieldVariableValueToObject
            {
                /// <summary>
                /// <para>飞书人事主数据对象唯一标识。</para>
                /// <para>例如：</para>
                /// <para>wk_api_name为"job"时，wk_id代表职务ID。详请可参考[查询单个职务（V2）](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/get)</para>
                /// <para>wk_api_name为"job_level"时，wk_id代表职级ID。详情可参考[查询单个职级](https://open.larkoffice.com/document/server-docs/corehr-v1/job-management/job_level/get)</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326263210149383</para>
                /// </summary>
                [JsonPropertyName("wk_id")]
                public string? WkId { get; set; }

                /// <summary>
                /// <para>飞书人事元数据对象的唯一标识。</para>
                /// <para>例如：</para>
                /// <para>职务的wk_api_name为"job"；职级的wk_api_name为"job_level"；</para>
                /// <para>如需获取更多对象信息，可查询[获取飞书人事对象列表](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/list_object_api_name)接口</para>
                /// <para>必填：否</para>
                /// <para>示例值：country_region_subdivision</para>
                /// </summary>
                [JsonPropertyName("wk_api_name")]
                public string? WkApiName { get; set; }
            }

            /// <summary>
            /// <para>部门id，根据查询参数department_id_type类型选择对应的部门id。</para>
            /// <para>可通过[搜索部门信息](https://open.larkoffice.com/document/server-docs/corehr-v1/organization-management/department/search) 或 [批量查询部门（ V2）](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)接口查询详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-a761814f6bc3f14bd3b00905ec1d7c6f</para>
            /// </summary>
            [JsonPropertyName("department_value")]
            public string? DepartmentValue { get; set; }

            /// <summary>
            /// <para>员工类型字段值，为用户id，根据入参选择的user_id_type类型返回的用户id。</para>
            /// <para>可通过[搜索员工信息](https://open.larkoffice.com/document/server-docs/corehr-v1/employee/search) 或 [批量查询员工信息](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口查询详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
            /// </summary>
            [JsonPropertyName("employment_value")]
            public string? EmploymentValue { get; set; }

            /// <summary>
            /// <para>数组类型值，里面包含多个值，每个元素都对应sub_values中的key</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("list_values")]
            public string[]? ListValues { get; set; }
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
            /// <para>用于关联list_values和record_values类型变量值中的key</para>
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
                    /// <para>飞书人事主数据对象唯一标识。</para>
                    /// <para>例如：</para>
                    /// <para>wk_api_name为"job"时，wk_id代表职务ID。详请可参考[查询单个职务（V2）](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/get)</para>
                    /// <para>wk_api_name为"job_level"时，wk_id代表职级ID。详情可参考[查询单个职级](https://open.larkoffice.com/document/server-docs/corehr-v1/job-management/job_level/get)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6863326263210149383</para>
                    /// </summary>
                    [JsonPropertyName("wk_id")]
                    public string? WkId { get; set; }

                    /// <summary>
                    /// <para>飞书人事元数据对象的唯一标识。</para>
                    /// <para>例如：</para>
                    /// <para>职务的wk_api_name为"job"；职级的wk_api_name为"job_level"；</para>
                    /// <para>如需获取更多对象信息，可查询[获取飞书人事对象列表](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/list_object_api_name)接口</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：country_region_subdivision</para>
                    /// </summary>
                    [JsonPropertyName("wk_api_name")]
                    public string? WkApiName { get; set; }
                }

                /// <summary>
                /// <para>部门id，根据查询参数department_id_type类型选择对应的部门id。</para>
                /// <para>可通过[搜索部门信息](https://open.larkoffice.com/document/server-docs/corehr-v1/organization-management/department/search) 或 [批量查询部门（ V2）](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)接口查询详情。</para>
                /// <para>必填：否</para>
                /// <para>示例值：od-a761814f6bc3f14bd3b00905ec1d7c6f</para>
                /// </summary>
                [JsonPropertyName("department_value")]
                public string? DepartmentValue { get; set; }

                /// <summary>
                /// <para>员工类型字段值，为用户id，根据入参选择的user_id_type类型返回的用户id。</para>
                /// <para>可通过[搜索员工信息](https://open.larkoffice.com/document/server-docs/corehr-v1/employee/search) 或 [批量查询员工信息](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口查询详情。</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_c57053dad6eea0aea4696c48433d8562</para>
                /// </summary>
                [JsonPropertyName("employment_value")]
                public string? EmploymentValue { get; set; }

                /// <summary>
                /// <para>数组类型值，里面包含多个值，每个元素都对应sub_values中的key</para>
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
