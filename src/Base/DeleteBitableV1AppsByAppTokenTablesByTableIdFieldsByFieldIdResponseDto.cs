// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除字段 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 删除字段 响应体
/// <para>删除多维表格数据表中的一个字段。</para>
/// <para>接口ID：6960166873968525315</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-field/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-field%2fdelete</para>
/// </summary>
public record DeleteBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdResponseDto
{
    /// <summary>
    /// <para>被删除的字段的 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：fldPTb0U2y</para>
    /// </summary>
    [JsonPropertyName("field_id")]
    public string? FieldId { get; set; }

    /// <summary>
    /// <para>是否删除</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }
}
