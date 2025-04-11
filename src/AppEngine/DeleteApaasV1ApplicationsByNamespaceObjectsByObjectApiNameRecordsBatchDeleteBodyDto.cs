// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="DeleteApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 批量删除记录 请求体
/// <para>一次删除多条对象中的记录</para>
/// <para>接口ID：7384730094873083932</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fbatch_delete</para>
/// </summary>
public record DeleteApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchDeleteBodyDto
{
    /// <summary>
    /// <para>记录 ID 列表，操作记录数上限为 500</para>
    /// <para>必填：是</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("ids")]
    public string[] Ids { get; set; } = Array.Empty<string>();
}
