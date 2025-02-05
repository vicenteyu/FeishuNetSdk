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
/// <para>根据投递 ID 操作候选人入职并创建员工，后续可通过 [通过员工 ID 获取入职信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/employee/get) 接口获取入职信息。</para>
/// <para>接口ID：6964286393804800028</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/transfer_onboard</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2ftransfer_onboard</para>
/// </summary>
public record PostHireV1ApplicationsByApplicationIdTransferOnboardBodyDto
{
    /// <summary>
    /// <para>实际入职时间，毫秒时间戳（int64类型），不能晚于当前时间，不传则默认为当前时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1616428800000</para>
    /// </summary>
    [JsonPropertyName("actual_onboard_time")]
    public long? ActualOnboardTime { get; set; }

    /// <summary>
    /// <para>预期转正时间，毫秒时间戳（int64类型），不传则默认为0</para>
    /// <para>必填：否</para>
    /// <para>示例值：1616428800000</para>
    /// </summary>
    [JsonPropertyName("expected_conversion_time")]
    public long? ExpectedConversionTime { get; set; }

    /// <summary>
    /// <para>招聘需求 ID，可通过接口 [获取招聘需求列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/list) 获取。是否必须传入取决于管理员在系统后台「招聘需求关联设置」的配置。入职完成后招聘需求的「已入职」人数会加1</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956402</para>
    /// </summary>
    [JsonPropertyName("job_requirement_id")]
    public string? JobRequirementId { get; set; }

    /// <summary>
    /// <para>操作人ID，与入参 `user_id_type` 类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：7326856229396906012</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// <para>候选人办公地点 ID，将用于候选人内推奖规则判断，数据源可通过接口[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)</para>
    /// <para>获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：CT_2</para>
    /// </summary>
    [JsonPropertyName("onboard_city_code")]
    public string? OnboardCityCode { get; set; }

    /// <summary>
    /// <para>候选人入职部门 ID ，将用于候选人内推奖规则判断，可通过接口[搜索部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/search)获取，与入参 `department_id_type ` 类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：6966123381141866028</para>
    /// </summary>
    [JsonPropertyName("department")]
    public string? Department { get; set; }

    /// <summary>
    /// <para>候选人直属上级 UserID ，将用于候选人内推奖规则判断，与入参 `user_id_type` 类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：7326856229396906012</para>
    /// </summary>
    [JsonPropertyName("leader")]
    public string? Leader { get; set; }

    /// <summary>
    /// <para>候选人序列 ID ，将用于候选人内推奖规则判断，与入参 `job_family_id_type ` 类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：7006234385490345986</para>
    /// </summary>
    [JsonPropertyName("sequence")]
    public string? Sequence { get; set; }

    /// <summary>
    /// <para>候选人职级 ID ，将用于候选人内推奖规则判断，与入参 `job_level_id_type ` 类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：6937934036379650311</para>
    /// </summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>
    /// <para>候选人入职人员类型 ID，将用于候选人内推奖规则判断，与入参 `employee_type_id_type ` 类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：cSbrHjS5Ogiwq0Zu-cKz1g==</para>
    /// </summary>
    [JsonPropertyName("employee_type")]
    public string? EmployeeType { get; set; }
}
