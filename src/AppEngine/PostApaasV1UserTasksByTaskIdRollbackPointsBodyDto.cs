// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostApaasV1UserTasksByTaskIdRollbackPointsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询人工任务可退回的位置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查询人工任务可退回的位置 请求体
/// <para>查询当前任务可以退回的位置</para>
/// <para>接口ID：7446337145820381188</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/user_task/rollback_points</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2frollback_points</para>
/// </summary>
public record PostApaasV1UserTasksByTaskIdRollbackPointsBodyDto
{
    /// <summary>
    /// <para>操作人kunlunUserID,可通过Apaas用户管理页面获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：1234</para>
    /// </summary>
    [JsonPropertyName("operator_user_id")]
    public string OperatorUserId { get; set; } = string.Empty;
}
