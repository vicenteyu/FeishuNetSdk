// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HireEcoBackgroundCheckCanceledV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>终止背调 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Events;
/// <summary>
/// 终止背调 事件体
/// <para>飞书招聘客户在招聘系统内终止背调后，系统会推送「终止背调」事件给对应的背调服务商，服务商可根据此事件获取背调 ID，完成服务商内部的订单取消等后续操作。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=hire&amp;version=v1&amp;resource=eco_background_check&amp;event=canceled)</para>
/// <para>接口ID：7195815979079614465</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check/events/canceled</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check%2fevents%2fcanceled</para>
/// </summary>
public record HireEcoBackgroundCheckCanceledV1EventBodyDto() : EventBodyDto("hire.eco_background_check.canceled_v1")
{
    /// <summary>
    /// <para>背调 ID，招聘系统内唯一，可通过[创建背调](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check/events/created)事件获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("background_check_id")]
    public string? BackgroundCheckId { get; set; }

    /// <summary>
    /// <para>终止原因</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("termination_reason")]
    public string? TerminationReason { get; set; }
}
