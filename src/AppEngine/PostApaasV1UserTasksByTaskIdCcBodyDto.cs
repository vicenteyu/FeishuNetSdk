// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostApaasV1UserTasksByTaskIdCcBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>抄送人工任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 抄送人工任务 请求体
/// <para>对当前的任务进行一次抄送</para>
/// <para>接口ID：7446337145820332036</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/cc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2fcc</para>
/// </summary>
public record PostApaasV1UserTasksByTaskIdCcBodyDto
{
    /// <summary>
    /// <para>抄送人的kunlunID列表,可通过Apaas用户管理页面获取</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("cc_user_ids")]
    public string[] CcUserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>操作人kunlunUserID,可通过Apaas用户管理页面获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：1234</para>
    /// </summary>
    [JsonPropertyName("operator_user_id")]
    public string OperatorUserId { get; set; } = string.Empty;
}
