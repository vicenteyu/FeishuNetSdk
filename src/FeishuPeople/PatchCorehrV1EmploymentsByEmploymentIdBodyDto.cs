// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchCorehrV1EmploymentsByEmploymentIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新雇佣信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 更新雇佣信息 请求体
/// <para>更新雇佣信息，包括工号、任职原因等</para>
/// <para>接口ID：7072588598729981980</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/employment/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployment%2fpatch</para>
/// </summary>
public record PatchCorehrV1EmploymentsByEmploymentIdBodyDto
{
    /// <summary>
    /// <para>资历起算日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("seniority_date")]
    public string? SeniorityDate { get; set; }

    /// <summary>
    /// <para>员工编号（工号）</para>
    /// <para>- 开启自动编码时不可以主动更新</para>
    /// <para>- 未开启自动编码，可主动更新：</para>
    /// <para>- 由数字或字母组成，请勿使用特殊字符</para>
    /// <para>- 请保证唯一</para>
    /// <para>必填：否</para>
    /// <para>示例值：1000000</para>
    /// </summary>
    [JsonPropertyName("employee_number")]
    public string? EmployeeNumber { get; set; }

    /// <summary>
    /// <para>雇佣类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)雇佣类型（employment_type）枚举定义获得</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_type")]
    public Enum? EmploymentType { get; set; }

    /// <summary>
    /// <para>雇佣类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)雇佣类型（employment_type）枚举定义获得</para>
    /// </summary>
    public record Enum
    {
        /// <summary>
        /// <para>枚举值</para>
        /// <para>必填：是</para>
        /// <para>示例值：employee</para>
        /// </summary>
        [JsonPropertyName("enum_name")]
        public string EnumName { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>个人信息 ID，由[【创建个人信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/person/create)时生成</para>
    /// <para>必填：否</para>
    /// <para>示例值：6919733936050406926</para>
    /// </summary>
    [JsonPropertyName("person_id")]
    public string? PersonId { get; set; }

    /// <summary>
    /// <para>是否是主雇佣信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("primary_employment")]
    public bool? PrimaryEmployment { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>字段名</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"Sandy\"</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>工作邮箱列表</para>
    /// <para>- 只有满足下面所有条件时，才在工作信息页面可见：</para>
    /// <para>- is_primary = "true"</para>
    /// <para>- is_public = "true"</para>
    /// <para>- email_usage = "work"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_email_list")]
    public Email[]? WorkEmailLists { get; set; }

    /// <summary>
    /// <para>工作邮箱列表</para>
    /// <para>- 只有满足下面所有条件时，才在工作信息页面可见：</para>
    /// <para>- is_primary = "true"</para>
    /// <para>- is_public = "true"</para>
    /// <para>- email_usage = "work"</para>
    /// </summary>
    public record Email
    {
        /// <summary>
        /// <para>邮箱号</para>
        /// <para>必填：是</para>
        /// <para>示例值：12456@test.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string EmailSuffix { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否为主要邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_primary")]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// <para>是否为公开邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// <para>邮箱用途</para>
        /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name: email</para>
        /// <para>- custom_api_name: email_usage</para>
        /// <para>- 请勿填写 home 枚举</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("email_usage")]
        public Enum? EmailUsage { get; set; }

        /// <summary>
        /// <para>邮箱用途</para>
        /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name: email</para>
        /// <para>- custom_api_name: email_usage</para>
        /// <para>- 请勿填写 home 枚举</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：work</para>
            /// </summary>
            [JsonPropertyName("enum_name")]
            public string EnumName { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
        /// </summary>
        public record ObjectFieldData
        {
            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"Sandy\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>离职原因</para>
    /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name：employment</para>
    /// <para>- custom_api_name：reason_for_offboarding</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reason_for_offboarding")]
    public Enum? ReasonForOffboarding { get; set; }

    /// <summary>
    /// <para>招聘投递 ID ，详细信息可以通过[【获取投递信息】](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6838119494196871234</para>
    /// </summary>
    [JsonPropertyName("ats_application_id")]
    public string? AtsApplicationId { get; set; }
}
