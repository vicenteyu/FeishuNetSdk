// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询记录列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查询记录列表 响应体
/// <para>获取对象中符合指定条件的记录列表</para>
/// <para>接口ID：7384730094873067548</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/application-object-record/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fbatch_query</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchQueryResponseDto
{
    /// <summary>
    /// <para>符合条件的记录列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{}]</para>
    /// </summary>
    [JsonPropertyName("items")]
    public string Items { get; set; } = string.Empty;

    /// <summary>
    /// <para>符合条件的记录数</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>下一页的起始位置 Token ，访问至末尾时不返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：null</para>
    /// </summary>
    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
