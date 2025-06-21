// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增一个数据表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增一个数据表 响应体
/// <para>新增一个数据表，支持传入数据表名称、视图名称和字段。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有多维表格的编辑等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>## 使用限制</para>
/// <para>每个多维表格中，数据表与仪表盘的总数量上限为 100。</para>
/// <para>接口ID：6960166873968541699</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fcreate</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesResponseDto
{
    /// <summary>
    /// <para>多维表格数据表的 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：tbl1AybU4ogJYXKA</para>
    /// </summary>
    [JsonPropertyName("table_id")]
    public string? TableId { get; set; }

    /// <summary>
    /// <para>默认表格视图的 ID。该字段仅在请求参数中填写了`default_view_name` 或 `fields` 字段才会返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：vew3y6oFgo</para>
    /// </summary>
    [JsonPropertyName("default_view_id")]
    public string? DefaultViewId { get; set; }

    /// <summary>
    /// <para>数据表初始字段的 ID 列表，该字段仅在请求参数中填写了 `fields` 才会返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：["fldO1Q5uD2"]</para>
    /// </summary>
    [JsonPropertyName("field_id_list")]
    public string[]? FieldIdList { get; set; }
}
