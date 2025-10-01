// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-25
//
// Last Modified By : yxr
// Last Modified On : 2025-09-25
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresTransformOnboardingTaskResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>流转入职任务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 流转入职任务 响应体
/// <para>处于进行中的入职流程，可通过本接口实现手动开启、提交或审批入职任务</para>
/// <para>- 当任务处于「手动开启」时，可通过本接口手动开启任务，将任务状态流转到「进行中」</para>
/// <para>- 当任务处于「进行中」时，可通过本接口提交任务，将任务流转到「审批中」或「已完成」</para>
/// <para>- 当任务处于「审批中」时，可通过本接口审批任务，将任务流转到「已完成」或「已拒绝」</para>
/// <para>- 当任务处于「已拒绝」时，可通过本接口提交任务，将任务流转到「审批中」</para>
/// <para>接口ID：7525488347772682242</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/transform_onboarding_task</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2ftransform_onboarding_task</para>
/// </summary>
public record PostCorehrV2PreHiresTransformOnboardingTaskResponseDto
{
    /// <summary>
    /// <para>是否成功流转任务，流转成功时返回true，流转失败时返回false</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}
