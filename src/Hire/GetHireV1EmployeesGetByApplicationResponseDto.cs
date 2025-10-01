// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-09-25
// ************************************************************************
// <copyright file="GetHireV1EmployeesGetByApplicationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过投递 ID 获取入职信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 通过投递 ID 获取入职信息 响应体
/// <para>通过投递 ID 获取员工入职信息。</para>
/// <para>接口ID：6959374328975867906</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/get_by_application</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2femployee%2fget_by_application</para>
/// </summary>
public record GetHireV1EmployeesGetByApplicationResponseDto
{
    /// <summary>
    /// <para>员工信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employee")]
    public GetHireV1EmployeesGetByApplicationResponseDtoEmployee? Employee { get; set; }

    /// <summary>
    /// <para>员工信息</para>
    /// </summary>
    public record GetHireV1EmployeesGetByApplicationResponseDtoEmployee
    {
        /// <summary>
        /// <para>员工 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7095600054216542508</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7073372582620416300</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>入职状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：已入职</item>
        /// <item>2：已离职</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("onboard_status")]
        public int? OnboardStatus { get; set; }

        /// <summary>
        /// <para>转正状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未转正</item>
        /// <item>2：已转正</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("conversion_status")]
        public int? ConversionStatus { get; set; }

        /// <summary>
        /// <para>实际入职时间，毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonPropertyName("onboard_time")]
        public long? OnboardTime { get; set; }

        /// <summary>
        /// <para>预期转正时间，毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonPropertyName("expected_conversion_time")]
        public long? ExpectedConversionTime { get; set; }

        /// <summary>
        /// <para>实际转正时间，毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonPropertyName("actual_conversion_time")]
        public long? ActualConversionTime { get; set; }

        /// <summary>
        /// <para>离职时间，毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonPropertyName("overboard_time")]
        public long? OverboardTime { get; set; }

        /// <summary>
        /// <para>离职原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：职业发展考虑</para>
        /// </summary>
        [JsonPropertyName("overboard_note")]
        public string? OverboardNote { get; set; }

        /// <summary>
        /// <para>办公地点 Code 码，详情请查看[「查询地点列表」](https://open.larkoffice.com/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)接口</para>
        /// <para>必填：否</para>
        /// <para>示例值：CT_2</para>
        /// </summary>
        [JsonPropertyName("onboard_city_code")]
        public string? OnboardCityCode { get; set; }

        /// <summary>
        /// <para>入职部门 ID，与入参`department_id_type `类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6966123381141866028</para>
        /// </summary>
        [JsonPropertyName("department")]
        public string? Department { get; set; }

        /// <summary>
        /// <para>直属上级 ID，与入参`user_id_type`类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou-xxx</para>
        /// </summary>
        [JsonPropertyName("leader")]
        public string? Leader { get; set; }

        /// <summary>
        /// <para>序列 ID，与入参`job_family_id_type `类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6937934036379650311</para>
        /// </summary>
        [JsonPropertyName("sequence")]
        public string? Sequence { get; set; }

        /// <summary>
        /// <para>职级 ID，与入参`job_level_id_type `类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：7006234385490345986</para>
        /// </summary>
        [JsonPropertyName("level")]
        public string? Level { get; set; }

        /// <summary>
        /// <para>员工类型 ID，与入参`employee_type_id_type `类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("employee_type")]
        public string? EmployeeType { get; set; }

        /// <summary>
        /// <para>招聘需求 ID，详情请查看：[获取招聘需求信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/list_by_id)</para>
        /// <para>必填：否</para>
        /// <para>示例值：123123123213</para>
        /// </summary>
        [JsonPropertyName("job_requirement_id")]
        public string? JobRequirementId { get; set; }

        /// <summary>
        /// <para>飞书人事的雇佣ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969595949493939291</para>
        /// </summary>
        [JsonPropertyName("external_employment_id")]
        public string? ExternalEmploymentId { get; set; }
    }
}
