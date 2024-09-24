// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取记录详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 获取记录详情 响应体
/// <para>获取对象中指定的记录详情</para>
/// <para>接口ID：7384730094873018396</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/application-object-record/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fquery</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdQueryResponseDto
{
    /// <summary>
    /// <para>记录详情,格式为 Map&lt;string, ANY&gt;</para>
    /// <para>必填：是</para>
    /// <para>示例值：{}</para>
    /// </summary>
    [JsonPropertyName("item")]
    public string Item { get; set; } = string.Empty;
}
