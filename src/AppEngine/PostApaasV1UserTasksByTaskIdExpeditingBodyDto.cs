// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostApaasV1UserTasksByTaskIdExpeditingBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>催办人工任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 催办人工任务 请求体
/// <para>对任务当前的处理人发起一次催办</para>
/// <para>接口ID：7446337145820348420</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/user_task/expediting</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2fexpediting</para>
/// </summary>
public record PostApaasV1UserTasksByTaskIdExpeditingBodyDto
{
    /// <summary>
    /// <para>操作人kunlunUserID,可通过Apaas用户管理页面获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：123</para>
    /// </summary>
    [JsonPropertyName("operator_user_id")]
    public string OperatorUserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>催办人的kunlunID列表,可通过Apaas用户管理页面获取</para>
    /// <para>必填：是</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("expediting_user_ids")]
    public string[] ExpeditingUserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>催办理由</para>
    /// <para>必填：否</para>
    /// <para>示例值：催办理由</para>
    /// </summary>
    [JsonPropertyName("opinion")]
    public string? Opinion { get; set; }
}
