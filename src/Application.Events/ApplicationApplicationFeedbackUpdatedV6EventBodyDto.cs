// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ApplicationApplicationFeedbackUpdatedV6EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>反馈更新 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Events;
/// <summary>
/// 反馈更新 事件体
/// <para>当反馈的处理状态被更新时，触发该事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=application&amp;version=v6&amp;resource=application.feedback&amp;event=updated)</para>
/// <para>接口ID：7072687744306577410</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/event/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-feedback%2fevents%2fupdated</para>
/// </summary>
public record ApplicationApplicationFeedbackUpdatedV6EventBodyDto() : EventBodyDto("application.application.feedback.updated_v6")
{
    /// <summary>
    /// <para>反馈id列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("feedback_ids")]
    public string[]? FeedbackIds { get; set; }

    /// <summary>
    /// <para>反馈处理状态（枚举值，0: 未处理 1: 已处理 2: 处理中 3: 已关闭）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>应用的 app_id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string? AppId { get; set; }

    /// <summary>
    /// <para>反馈处理时间，格式为yyyy-mm-dd hh:mm:ss</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("update_time")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// <para>操作者用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }
}
