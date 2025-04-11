// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>编辑记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 编辑记录 请求体
/// <para>编辑对象中的指定记录</para>
/// <para>接口ID：7384730094873034780</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fpatch</para>
/// </summary>
public record PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdBodyDto
{
    /// <summary>
    /// <para>创建对象使用的数据，键为字段 API 名称，值为字段值，格式可参考字段值格式</para>
    /// <para>必填：是</para>
    /// <para>示例值：{\"_id\":\"1798681438085228\",\"book_count\":\"3\",\"book_name\":\"showcase2\"}</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("record")]
    public string Record { get; set; } = string.Empty;
}
