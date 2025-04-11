// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceObjectsOqlQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>执行 OQL 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 执行 OQL 响应体
/// <para>在应用内执行 OQL 语句</para>
/// <para>接口ID：7384730094873002012</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/oql_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object%2foql_query</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceObjectsOqlQueryResponseDto
{
    /// <summary>
    /// <para>每一列的标题</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("columns")]
    public string[] Columns { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>每一行的值，以「key-value」的形式返回</para>
    /// <para>必填：是</para>
    /// <para>示例值：[ { \"_name\": \"Sample Text\", \"_id\": 1234567890 } ]</para>
    /// </summary>
    [JsonPropertyName("rows")]
    public string Rows { get; set; } = string.Empty;
}
