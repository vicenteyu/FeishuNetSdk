// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-06-26
// ************************************************************************
// <copyright file="PostHireV1ApplicationsByApplicationIdTerminateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>终止投递 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 终止投递 请求体
/// <para>根据投递 ID 修改投递状态为「已终止」。</para>
/// <para>接口ID：6964286393804832796</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/terminate</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fterminate</para>
/// </summary>
public record PostHireV1ApplicationsByApplicationIdTerminateBodyDto
{
    /// <summary>
    /// <para>终止原因的类型</para>
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
    /// <para>终止的具体原因的id列表，可通过[获取终止投递原因](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/termination_reason/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：["6891560630172518670"]</para>
    /// </summary>
    [JsonPropertyName("termination_reason_list")]
    public string[]? TerminationReasonList { get; set; }

    /// <summary>
    /// <para>终止备注</para>
    /// <para>必填：否</para>
    /// <para>示例值：不符合期望</para>
    /// </summary>
    [JsonPropertyName("termination_reason_note")]
    public string? TerminationReasonNote { get; set; }
}
