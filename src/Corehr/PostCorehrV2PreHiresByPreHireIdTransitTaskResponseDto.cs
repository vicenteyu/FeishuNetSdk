// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresByPreHireIdTransitTaskResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>流转入职任务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 流转入职任务 响应体
/// <para>配置入职流程后，可通过本接口流转进行中的任务</para>
/// <para>接口ID：7357756972752732162</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/transit_task</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2ftransit_task</para>
/// </summary>
public record PostCorehrV2PreHiresByPreHireIdTransitTaskResponseDto
{
    /// <summary>
    /// <para>是否成功流转任务</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}
