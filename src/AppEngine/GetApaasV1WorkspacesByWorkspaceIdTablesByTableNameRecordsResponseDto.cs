// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="GetApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询数据表数据记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查询数据表数据记录 响应体
/// <para>查询数据表数据记录</para>
/// <para>接口ID：7574027220335856583</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/records_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2frecords_get</para>
/// </summary>
public record GetApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string PageToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>符合条件的记录总数</para>
    /// <para>必填：是</para>
    /// <para>示例值：2</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; set; }

    /// <summary>
    /// <para>数据记录列表，格式为数组序列化后的 JSONString</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"name\":\"王一一\",\"gender\":\"male\",\"age\":10},{\"name\":\"王二二\",\"gender\":\"female\",\"age\":10}]</para>
    /// </summary>
    [JsonPropertyName("items")]
    public string Items { get; set; } = string.Empty;
}
