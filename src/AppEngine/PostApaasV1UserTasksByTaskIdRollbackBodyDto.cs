// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostApaasV1UserTasksByTaskIdRollbackBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>退回人工任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 退回人工任务 请求体
/// <para>对当前任务进行一次退回</para>
/// <para>接口ID：7446337145820397572</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/rollback</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2frollback</para>
/// </summary>
public record PostApaasV1UserTasksByTaskIdRollbackBodyDto
{
    /// <summary>
    /// <para>操作人kunlunUserID,可通过Apaas用户管理页面获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：1234</para>
    /// </summary>
    [JsonPropertyName("operator_user_id")]
    public string OperatorUserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>退回到的任务ID，可以通过[查询人工任务可退回的点](/uAjLw4CM/ukTMukTMukTM/apaas-v1/user_task/rollback_points)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：1234</para>
    /// </summary>
    [JsonPropertyName("to_task_id")]
    public string ToTaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>退回原因</para>
    /// <para>必填：是</para>
    /// <para>示例值：退回原因</para>
    /// </summary>
    [JsonPropertyName("opinion")]
    public string Opinion { get; set; } = string.Empty;
}
