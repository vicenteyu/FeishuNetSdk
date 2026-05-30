// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="PostTaskV2TaskV2TaskSubscriptionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>订阅任务变更事件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 订阅任务变更事件 响应体
/// <para>- 订阅范围</para>
/// <para>- 使用应用身份，订阅当前应用所负责的任务的变更事件</para>
/// <para>- 使用用户身份，订阅当前用户所创建、负责、关注的任务的变更事件</para>
/// <para>接口ID：7645220598528150716</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task_v2/task_subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask_v2%2ftask_subscription</para>
/// </summary>
public record PostTaskV2TaskV2TaskSubscriptionResponseDto
{
    /// <summary>
    /// <para>状态码</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    /// <para>响应信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：success</para>
    /// </summary>
    [JsonPropertyName("msg")]
    public string? Msg { get; set; }
}
