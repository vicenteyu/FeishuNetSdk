// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceObjectsOqlQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>执行 OQL 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 执行 OQL 请求体
/// <para>在应用内执行 OQL 语句</para>
/// <para>接口ID：7384730094873002012</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/application-object/oql_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object%2foql_query</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceObjectsOqlQueryBodyDto
{
    /// <summary>
    /// <para>待执行的 OQL 语句</para>
    /// <para>必填：是</para>
    /// <para>示例值：SELECT _id, _name FROM _user WHERE _type = $1 AND _accountStatus = $user_status LIMIT 10</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;

    /// <summary>
    /// <para>用于指定 OQL 语句中匿名参数的具体值</para>
    /// <para>必填：否</para>
    /// <para>示例值：[\"_employee\"]</para>
    /// </summary>
    [JsonPropertyName("args")]
    public string? Args { get; set; }

    /// <summary>
    /// <para>用于指定 OQL 语句中具名参数的具体值</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"user_status\" : \"_used\"}</para>
    /// </summary>
    [JsonPropertyName("named_args")]
    public string? NamedArgs { get; set; }
}
