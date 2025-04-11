// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 新建记录 请求体
/// <para>在对象中新建记录</para>
/// <para>接口ID：7384730094872952860</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fcreate</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBodyDto
{
    /// <summary>
    /// <para>创建对象使用的数据，键为字段 API 名称，值为字段值，格式可参考字段值格式</para>
    /// <para>必填：是</para>
    /// <para>示例值：{\"book_name\":\"test\"}</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("record")]
    public string Record { get; set; } = string.Empty;
}
