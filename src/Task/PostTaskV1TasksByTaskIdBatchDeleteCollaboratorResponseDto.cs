// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTaskV1TasksByTaskIdBatchDeleteCollaboratorResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除执行者 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 批量删除执行者 响应体
/// <para>该接口用于批量删除执行者。</para>
/// <para>接口ID：7118952533649244163</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-collaborator/batch_delete_collaborator</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fbatch_delete_collaborator</para>
/// </summary>
public record PostTaskV1TasksByTaskIdBatchDeleteCollaboratorResponseDto
{
    /// <summary>
    /// <para>实际删除的执行人用户ID列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("collaborators")]
    public string[]? Collaborators { get; set; }
}
