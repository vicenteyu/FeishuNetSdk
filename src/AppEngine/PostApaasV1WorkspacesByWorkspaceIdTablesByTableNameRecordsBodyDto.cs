// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="PostApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>向数据表中添加或更新记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 向数据表中添加或更新记录 请求体
/// <para>向数据表中添加或更新记录</para>
/// <para>接口ID：7574027220335872967</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/records_post</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2frecords_post</para>
/// </summary>
public record PostApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBodyDto
{
    /// <summary>
    /// <para>要插入的数据记录列表，单次支持最多 500 条</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"name\":\"王一一\",\"gender\":\"male\",\"age\":10},{\"name\":\"王二二\",\"gender\":\"female\",\"age\":10}]</para>
    /// </summary>
    [JsonPropertyName("records")]
    public string Records { get; set; } = string.Empty;
}
