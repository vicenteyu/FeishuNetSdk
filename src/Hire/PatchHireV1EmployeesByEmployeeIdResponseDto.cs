// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-28
// ************************************************************************
// <copyright file="PatchHireV1EmployeesByEmployeeIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新员工状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新员工状态 响应体
/// <para>根据员工 ID 更新员工招聘系统内的转正、离职状态。</para>
/// <para>接口ID：6959374328975900674</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2femployee%2fpatch</para>
/// </summary>
public record PatchHireV1EmployeesByEmployeeIdResponseDto
{
    /// <summary>
    /// <para>员工信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employee")]
    public PatchHireV1EmployeesByEmployeeIdResponseDtoEmployee? Employee { get; set; }

    /// <summary>
    /// <para>员工信息</para>
    /// </summary>
    public record PatchHireV1EmployeesByEmployeeIdResponseDtoEmployee
    {
        /// <summary>
        /// <para>员工ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7095600054216542508</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递ID，详情请查看：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7073372582620416300</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>入职状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
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
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未转正</item>
        /// <item>2：已转正</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("conversion_status")]
        public int? ConversionStatus { get; set; }

        /// <summary>
        /// <para>实际入职时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonPropertyName("onboard_time")]
        public long? OnboardTime { get; set; }

        /// <summary>
        /// <para>预期转正时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonPropertyName("expected_conversion_time")]
        public long? ExpectedConversionTime { get; set; }

        /// <summary>
        /// <para>实际转正时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1637596800000</para>
        /// </summary>
        [JsonPropertyName("actual_conversion_time")]
        public long? ActualConversionTime { get; set; }

        /// <summary>
        /// <para>离职时间，毫秒时间戳</para>
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
        /// <para>办公地点，详情请查看：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
        /// <para>必填：否</para>
        /// <para>示例值：CT_2</para>
        /// </summary>
        [JsonPropertyName("onboard_city_code")]
        public string? OnboardCityCode { get; set; }

        /// <summary>
        /// <para>入职部门ID，与入参中的`department_id_type`类型一致，详情请查看：[获取单个部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6966123381141866028</para>
        /// </summary>
        [JsonPropertyName("department")]
        public string? Department { get; set; }

        /// <summary>
        /// <para>直属上级用户ID，与入参`user_id_type`类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou-xxx</para>
        /// </summary>
        [JsonPropertyName("leader")]
        public string? Leader { get; set; }

        /// <summary>
        /// <para>序列ID，与入参`job_family_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6937934036379650311</para>
        /// </summary>
        [JsonPropertyName("sequence")]
        public string? Sequence { get; set; }

        /// <summary>
        /// <para>职级ID，与入参`job_level_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：7006234385490345986</para>
        /// </summary>
        [JsonPropertyName("level")]
        public string? Level { get; set; }

        /// <summary>
        /// <para>员工类型ID，与入参`employee_type_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("employee_type")]
        public string? EmployeeType { get; set; }

        /// <summary>
        /// <para>招聘需求ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：123123123213</para>
        /// </summary>
        [JsonPropertyName("job_requirement_id")]
        public string? JobRequirementId { get; set; }
    }
}
