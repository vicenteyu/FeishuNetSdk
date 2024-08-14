// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1EcoBackgroundChecksCancelBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>终止背调订单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 终止背调订单 请求体
/// <para>调用此接口将会将背调订单状态变成已终止，已终止订单将将无法通过[更新背调订单进度](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check/update_progress)和[回传背调订单的最终结果](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check/update_result)修改订单进度和最终结果。 调用此接口前，建议先调用[更新背调订单进度](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check/update_progress)接口将订单进度更新为「已终止」。</para>
/// <para>接口ID：7195815979079598081</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/cancel</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check%2fcancel</para>
/// </summary>
public record PostHireV1EcoBackgroundChecksCancelBodyDto
{
    /// <summary>
    /// <para>背调 ID。可通过[创建背调](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check/events/created)事件获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6931286400470354183</para>
    /// </summary>
    [JsonPropertyName("background_check_id")]
    public string BackgroundCheckId { get; set; } = string.Empty;
}
