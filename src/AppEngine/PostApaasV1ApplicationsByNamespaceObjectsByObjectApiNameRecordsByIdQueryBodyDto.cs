// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取记录详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 获取记录详情 请求体
/// <para>获取对象中指定的记录详情</para>
/// <para>接口ID：7384730094873018396</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/application-object-record/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fquery</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdQueryBodyDto
{
    /// <summary>
    /// <para>需要获取的字段，使用字段唯一标识符进行查询，关联字段可使用 . 进行下钻</para>
    /// <para>必填：否</para>
    /// <para>最大长度：256</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("select")]
    public string[]? Select { get; set; }
}
