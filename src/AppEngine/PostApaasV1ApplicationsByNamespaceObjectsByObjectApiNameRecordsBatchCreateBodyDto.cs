// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量新建记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 批量新建记录 请求体
/// <para>一次新建多条对象中的记录</para>
/// <para>接口ID：7384730094872985628</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fbatch_create</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchCreateBodyDto
{
    /// <summary>
    /// <para>记录详情列表，格式为 List&lt;Map&lt;string, ANY&gt;&gt;，操作记录数上限为 500 条</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"book_name\":\"name21\",\"book_count\":2}]</para>
    /// </summary>
    [JsonPropertyName("records")]
    public string Records { get; set; } = string.Empty;
}
