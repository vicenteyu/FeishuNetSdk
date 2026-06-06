// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="DeleteOkrV2AlignmentsByAlignmentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除 OKR 对齐 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 删除 OKR 对齐 响应体
/// <para>删除两个目标之间现有的 OKR 对齐关系。移除对齐连接的同时保留目标本身。</para>
/// <para>接口ID：7644764969658420172</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-alignment/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-alignment%2fdelete</para>
/// </summary>
public record DeleteOkrV2AlignmentsByAlignmentIdResponseDto
{
    /// <summary>
    /// <para>对齐 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7342342398472398473</para>
    /// </summary>
    [JsonPropertyName("alignment_id")]
    public string? AlignmentId { get; set; }
}
