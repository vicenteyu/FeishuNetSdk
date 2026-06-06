// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="DeleteOkrV2KeyResultsByKeyResultIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除关键结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 删除关键结果 响应体
/// <para>删除目标下指定的关键结果。此操作将永久删除该关键结果及其关联的所有数据，包括进展记录和量化指标。</para>
/// <para>接口ID：7644764969658551244</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-key_result/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-key_result%2fdelete</para>
/// </summary>
public record DeleteOkrV2KeyResultsByKeyResultIdResponseDto
{
    /// <summary>
    /// <para>关键结果 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7342342398472398473</para>
    /// </summary>
    [JsonPropertyName("key_result_id")]
    public string? KeyResultId { get; set; }
}
