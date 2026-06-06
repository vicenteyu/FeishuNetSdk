// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PostOkrV2ObjectivesByObjectiveIdAlignmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建目标对齐关系 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 创建目标对齐关系 响应体
/// <para>为指定目标与另一个目标创建对齐关系，在 OKR 结构中建立层级对齐。</para>
/// <para>接口ID：7644764969658289100</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-objective-alignment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-objective-alignment%2fcreate</para>
/// </summary>
public record PostOkrV2ObjectivesByObjectiveIdAlignmentsResponseDto
{
    /// <summary>
    /// <para>对齐 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7342342398472398473</para>
    /// </summary>
    [JsonPropertyName("alignment_id")]
    public string? AlignmentId { get; set; }
}
