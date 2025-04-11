// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量编辑记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 批量编辑记录 请求体
/// <para>一次编辑多条对象中的记录</para>
/// <para>接口ID：7384730094872969244</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fbatch_update</para>
/// </summary>
public record PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchUpdateBodyDto
{
    /// <summary>
    /// <para>记录详情列表，格式为 List&lt;Map&lt;string, ANY&gt;&gt;，操作记录数上限为 500 条</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"_id\":\"1798681438085228\",\"book_count\":\"5\",\"book_name\":\"name4\"}]</para>
    /// </summary>
    [JsonPropertyName("records")]
    public string Records { get; set; } = string.Empty;
}
