// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 新建记录 响应体
/// <para>在对象中新建记录</para>
/// <para>接口ID：7384730094872952860</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fcreate</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsResponseDto
{
    /// <summary>
    /// <para>记录 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：1764024447556775</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
