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
/// <para>新增一个数据表，默认仅包含索引字段，也可以指定一部分初始字段。最多支持新增 100 个数据表。</para>
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
