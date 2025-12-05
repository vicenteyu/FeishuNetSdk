// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="PostApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>向数据表中添加或更新记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 向数据表中添加或更新记录 响应体
/// <para>向数据表中添加或更新记录</para>
/// <para>接口ID：7574027220335872967</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/records_post</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2frecords_post</para>
/// </summary>
public record PostApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsResponseDto
{
    /// <summary>
    /// <para>按照记录顺序创建或更新的记录 ID 列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("record_ids")]
    public string[] RecordIds { get; set; } = [];
}
