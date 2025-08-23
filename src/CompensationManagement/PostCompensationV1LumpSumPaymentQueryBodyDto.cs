// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCompensationV1LumpSumPaymentQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询一次性支付授予记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 查询一次性支付授予记录 请求体
/// <para>根据筛选条件查询一次性支付授予记录</para>
/// <para>接口ID：7429528484932780060</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/lump_sum_payment/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2flump_sum_payment%2fquery</para>
/// </summary>
public record PostCompensationV1LumpSumPaymentQueryBodyDto
{
    /// <summary>
    /// <para>一次性支付记录 id，可通过本接口获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("ids")]
    public string[]? Ids { get; set; }

    /// <summary>
    /// <para>一次性支付记录 unique_id，unique_id 在创建时由上游指定</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("unique_ids")]
    public string[]? UniqueIds { get; set; }

    /// <summary>
    /// <para>员工id，具体类型由入参中的 user_id_type 指定</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }

    /// <summary>
    /// <para>薪酬项 id（通过[【查询薪酬项】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/item/list)) 接口进行查询）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("item_ids")]
    public string[]? ItemIds { get; set; }

    /// <summary>
    /// <para>创建时间大于等于值（东八区）</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-04-01 12:34:56</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("create_time_gte")]
    public string? CreateTimeGte { get; set; }

    /// <summary>
    /// <para>创建时间小于等于（东八区）</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-04-01 12:34:56</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("create_time_lte")]
    public string? CreateTimeLte { get; set; }

    /// <summary>
    /// <para>更新时间大于等于值（东八区）</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-04-01 12:34:56</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("modify_time_gte")]
    public string? ModifyTimeGte { get; set; }

    /// <summary>
    /// <para>更新时间小于等于值（东八区）</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-04-01 12:34:56</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("modify_time_lte")]
    public string? ModifyTimeLte { get; set; }

    /// <summary>
    /// <para>合同主体 id（通过[【查询合同主体】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list) 接口进行查询）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("company_ids")]
    public string[]? CompanyIds { get; set; }

    /// <summary>
    /// <para>任职公司 id（通过[【查询任职公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list) 接口进行查询）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("service_company_ids")]
    public string[]? ServiceCompanyIds { get; set; }

    /// <summary>
    /// <para>部门 id（部门id仅支持people_corehr_department_id，通过[【查询部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)接口进行查询）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[]? DepartmentIds { get; set; }

    /// <summary>
    /// <para>序列 id（通过 [【查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)接口进行查询）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_family_ids")]
    public string[]? JobFamilyIds { get; set; }

    /// <summary>
    /// <para>职级 id（通过 [【查询职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)接口进行查询）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_level_ids")]
    public string[]? JobLevelIds { get; set; }

    /// <summary>
    /// <para>工作地点 id（通过 [【查询工作地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list) 接口进行查询）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("work_location_ids")]
    public string[]? WorkLocationIds { get; set; }

    /// <summary>
    /// <para>员工类型 id（可通过 [【查询员工类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/list) 接口进行查询）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("employee_type_ids")]
    public string[]? EmployeeTypeIds { get; set; }

    /// <summary>
    /// <para>员工入职日期大于等于值</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-04-01</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("onboard_date_gte")]
    public string? OnboardDateGte { get; set; }

    /// <summary>
    /// <para>员工入职日期小于等于值</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-04-01</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("onboard_date_lte")]
    public string? OnboardDateLte { get; set; }

    /// <summary>
    /// <para>员工离职日期大于等于值</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-04-01</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("offboard_date_gte")]
    public string? OffboardDateGte { get; set; }

    /// <summary>
    /// <para>员工离职日期小于等于值</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-04-01</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("offboard_date_lte")]
    public string? OffboardDateLte { get; set; }
}
