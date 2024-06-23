// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1ApplicationsByApplicationIdTransferOnboardBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>操作候选人入职 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 操作候选人入职 请求体
/// <para>根据投递 ID 操作候选人入职并创建员工。投递须处于「待入职」阶段，可通过「转移阶段」接口变更投递状态。</para>
/// <para>接口ID：6964286393804800028</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/transfer_onboard</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2ftransfer_onboard</para>
/// </summary>
public record PostHireV1ApplicationsByApplicationIdTransferOnboardBodyDto
{
    /// <summary>
    /// <para>实际入职时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1616428800000</para>
    /// </summary>
    [JsonPropertyName("actual_onboard_time")]
    public int? ActualOnboardTime { get; set; }

    /// <summary>
    /// <para>预期转正时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1616428800000</para>
    /// </summary>
    [JsonPropertyName("expected_conversion_time")]
    public int? ExpectedConversionTime { get; set; }

    /// <summary>
    /// <para>招聘需求 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956402</para>
    /// </summary>
    [JsonPropertyName("job_requirement_id")]
    public string? JobRequirementId { get; set; }

    /// <summary>
    /// <para>操作人 UserID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou-xxx</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// <para>候选人办公地点 ID ，枚举可通过接口「获取地址列表」获取，将用于候选人内推奖规则判断</para>
    /// <para>必填：否</para>
    /// <para>示例值：CT_2</para>
    /// </summary>
    [JsonPropertyName("onboard_city_code")]
    public string? OnboardCityCode { get; set; }

    /// <summary>
    /// <para>候选人入职部门 ID ，枚举可通过接口「获取部门信息列表」获取，将用于候选人内推奖规则判断</para>
    /// <para>必填：否</para>
    /// <para>示例值：6966123381141866028</para>
    /// </summary>
    [JsonPropertyName("department")]
    public string? Department { get; set; }

    /// <summary>
    /// <para>候选人直属上级 UserID ，将用于候选人内推奖规则判断</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou-xxx</para>
    /// </summary>
    [JsonPropertyName("leader")]
    public string? Leader { get; set; }

    /// <summary>
    /// <para>候选人序列 ID ，枚举可通过接口「获取职务分类列表」获取，将用于候选人内推奖规则判断</para>
    /// <para>必填：否</para>
    /// <para>示例值：7006234385490345986</para>
    /// </summary>
    [JsonPropertyName("sequence")]
    public string? Sequence { get; set; }

    /// <summary>
    /// <para>候选人职级 ID ，枚举可通过接口「获取职级列表」获取，将用于候选人内推奖规则判断</para>
    /// <para>必填：否</para>
    /// <para>示例值：6937934036379650311</para>
    /// </summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>
    /// <para>候选人入职人员类型 ID，可通过接口人力资源管理平台「获取员工类型列表」获取，将用于候选人内推奖规则判断</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("employee_type")]
    public string? EmployeeType { get; set; }
}
