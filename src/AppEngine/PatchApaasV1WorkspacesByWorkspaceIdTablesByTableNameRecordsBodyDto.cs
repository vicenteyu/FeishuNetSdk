// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="PatchApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>按条件更新数据表中的记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 按条件更新数据表中的记录 请求体
/// <para>按条件更新数据表中的记录</para>
/// <para>接口ID：7574027220335889351</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/records_patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2frecords_patch</para>
/// </summary>
public record PatchApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBodyDto
{
    /// <summary>
    /// <para>要更新的数据记录信息</para>
    /// <para>必填：是</para>
    /// <para>示例值：{\"age\":10}</para>
    /// </summary>
    [JsonPropertyName("record")]
    public string Record { get; set; } = string.Empty;
}
