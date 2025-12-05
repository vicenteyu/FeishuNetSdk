// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="PatchApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量更新数据表中的记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 批量更新数据表中的记录 响应体
/// <para>批量更新数据表中的记录</para>
/// <para>接口ID：7574027220335905735</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/records_batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2frecords_batch_update</para>
/// </summary>
public record PatchApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBatchUpdateResponseDto
{
    /// <summary>
    /// <para>更新的记录唯一ID列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("record_ids")]
    public string[] RecordIds { get; set; } = [];
}
