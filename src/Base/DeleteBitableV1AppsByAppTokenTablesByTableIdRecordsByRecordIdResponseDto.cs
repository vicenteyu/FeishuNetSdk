// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 删除记录 响应体
/// <para>删除多维表格数据表中的一条记录。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有多维表格的编辑等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>接口ID：6952707657162555394</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fdelete</para>
/// </summary>
public record DeleteBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdResponseDto
{
    /// <summary>
    /// <para>是否成功删除</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>
    /// <para>删除的记录 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：recpCsf4ME</para>
    /// </summary>
    [JsonPropertyName("record_id")]
    public string? RecordId { get; set; }
}
