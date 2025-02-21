// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-02-21
//
// Last Modified By : yxr
// Last Modified On : 2025-02-21
// ************************************************************************
// <copyright file="PostHireV1ApplicationsByApplicationIdCancelOnboardBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>取消候选人入职 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 取消候选人入职 请求体
/// <para>取消待入职状态的候选人入职。</para>
/// <para>## 注意事项</para>
/// <para>- 本接口适用于对待入职阶段的候选人取消入职。对于已入职的候选人，取消入职请使用[更新入职状态](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/employee/patch)</para>
/// <para>对候选人进行离职操作。</para>
/// <para>- 对于集成了飞书人事的租户，候选人在飞书人事创建待入职记录后，只能在飞书人事取消入职，不可使用本接口取消入职。</para>
/// <para>接口ID：6989078472837152771</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/cancel_onboard</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fcancel_onboard</para>
/// </summary>
public record PostHireV1ApplicationsByApplicationIdCancelOnboardBodyDto
{
    /// <summary>
    /// <para>终止类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：我们拒绝了候选人</item>
    /// <item>22：候选人拒绝了我们</item>
    /// <item>27：其他</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("termination_type")]
    public int TerminationType { get; set; }

    /// <summary>
    /// <para>终止的具体原因的id列表，详细信息请参考[获取终止投递原因](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/termination_reason/list)</para>
    /// <para>必填：否</para>
    /// <para>示例值：11111</para>
    /// </summary>
    [JsonPropertyName("termination_reason_id_list")]
    public string[]? TerminationReasonIdList { get; set; }

    /// <summary>
    /// <para>备注</para>
    /// <para>必填：否</para>
    /// <para>示例值：候选人经历不匹配</para>
    /// </summary>
    [JsonPropertyName("termination_reason_notes")]
    public string? TerminationReasonNotes { get; set; }
}
