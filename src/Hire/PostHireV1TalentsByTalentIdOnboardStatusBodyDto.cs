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
/// <para>更新人才的在职状态，可进行的操作包括入职与离职。</para>
/// <para>## 注意事项</para>
/// <para>- 进行入职、离职操作后，「飞书招聘」- 「人才库」-「人才详情页」等场景会相应展示已入职、已离职标签</para>
/// <para>- 已入职的人才不能进行入职操作，已离职的人才不能进行入职操作</para>
/// <para>接口ID：7236665938900877340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/onboard_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fonboard_status</para>
/// </summary>
public record PostHireV1TalentsByTalentIdOnboardStatusBodyDto
{
    /// <summary>
    /// <para>操作类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：入职</item>
    /// <item>2：离职</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("operation")]
    public int Operation { get; set; }

    /// <summary>
    /// <para>入职时间，毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1676548784889</para>
    /// </summary>
    [JsonPropertyName("onboard_time")]
    public string? OnboardTime { get; set; }

    /// <summary>
    /// <para>离职时间，毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1676548784890</para>
    /// </summary>
    [JsonPropertyName("overboard_time")]
    public string? OverboardTime { get; set; }
}
