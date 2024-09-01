// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ApplicationApplicationFeedbackCreatedV6EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增应用反馈 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Events;
/// <summary>
/// 新增应用反馈 事件体
/// <para>当应用收到新反馈时，触发该事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=application&amp;version=v6&amp;resource=application.feedback&amp;event=created)</para>
/// <para>接口ID：7072687744306626562</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/event/created-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-feedback%2fevents%2fcreated</para>
/// </summary>
public record ApplicationApplicationFeedbackCreatedV6EventBodyDto() : EventBodyDto("application.application.feedback.created_v6")
{
    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public UserIdSuffix? UserId { get; set; }

    /// <summary>
    /// <para>被反馈应用 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string? AppId { get; set; }

    /// <summary>
    /// <para>反馈提交时间，格式为yyyy-mm-dd hh:mm:ss</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("feedback_time")]
    public string? FeedbackTime { get; set; }

    /// <summary>
    /// <para>反馈用户的租户名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant_name")]
    public string? TenantName { get; set; }

    /// <summary>
    /// <para>反馈类型（枚举值，1：故障反馈，2：产品建议）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("feedback_type")]
    public int? FeedbackType { get; set; }

    /// <summary>
    /// <para>故障类型列表：1: 黑屏 2: 白屏 3: 无法打开小程序 4: 卡顿 5: 小程序闪退 6: 页面加载慢 7: 死机 8: 其他异常</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("fault_type")]
    public int[]? FaultType { get; set; }

    /// <summary>
    /// <para>故障时间，格式为yyyy-mm-dd hh:mm:ss</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("fault_time")]
    public string? FaultTime { get; set; }

    /// <summary>
    /// <para>反馈来源：1： 小程序 2：网页应用 3：机器人 4：webSDK</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("source")]
    public int? Source { get; set; }

    /// <summary>
    /// <para>用户填写的联系方式</para>
    /// <para>**字段权限要求（满足任一）**：</para>
    /// <para>- contact:user.email:readonly : 获取用户邮箱信息</para>
    /// <para>- contact:user.phone:readonly : 获取用户手机号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("contact")]
    public string? Contact { get; set; }

    /// <summary>
    /// <para>反馈详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>反馈图片url列表，url 过期时间三天</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("images")]
    public string[]? Images { get; set; }

    /// <summary>
    /// <para>应用反馈 ID，应用反馈记录唯一标识</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("feedback_id")]
    public string? FeedbackId { get; set; }

    /// <summary>
    /// <para>反馈页面路径</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("feedback_path")]
    public string? FeedbackPath { get; set; }
}
