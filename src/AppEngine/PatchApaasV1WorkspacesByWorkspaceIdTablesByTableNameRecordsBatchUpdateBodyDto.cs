// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="PatchApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量更新数据表中的记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 批量更新数据表中的记录 请求体
/// <para>批量更新数据表中的记录</para>
/// <para>接口ID：7574027220335905735</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/records_batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2frecords_batch_update</para>
/// </summary>
public record PatchApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBatchUpdateBodyDto
{
    /// <summary>
    /// <para>要更新的数据记录列表，单次支持最多 500条，每行 record 都必须包含主键 _id，且不同行要更新的字段需保持一致</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"_id\":\"657fade8-394d-4d86-aa35-0129e3bd7614\",\"age\":10}]</para>
    /// </summary>
    [JsonPropertyName("records")]
    public string Records { get; set; } = string.Empty;
}
