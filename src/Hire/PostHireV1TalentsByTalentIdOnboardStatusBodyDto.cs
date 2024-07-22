// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1TalentsByTalentIdOnboardStatusBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新人才在职状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新人才在职状态 请求体
/// <para>更新人才的在职状态。仅适用于未通过招聘系统内的投递入职的候选人；通过该接口标记在职的候选人，仅可通过该接口标记离职</para>
/// <para>接口ID：7236665938900877340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/onboard_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fonboard_status</para>
/// </summary>
public record PostHireV1TalentsByTalentIdOnboardStatusBodyDto
{
    /// <summary>
    /// <para>操作类型 1:入职 2:离职</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：入职</item>
    /// <item>2：离职</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("operation")]
    public int? Operation { get; set; }

    /// <summary>
    /// <para>毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1676548784889</para>
    /// </summary>
    [JsonPropertyName("onboard_time")]
    public string? OnboardTime { get; set; }

    /// <summary>
    /// <para>毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1676548784890</para>
    /// </summary>
    [JsonPropertyName("overboard_time")]
    public string? OverboardTime { get; set; }
}
