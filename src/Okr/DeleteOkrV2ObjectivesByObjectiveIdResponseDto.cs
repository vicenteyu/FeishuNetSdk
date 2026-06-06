// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="DeleteOkrV2ObjectivesByObjectiveIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除 OKR 目标 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 删除 OKR 目标 响应体
/// <para>从 OKR 周期中删除已存在的目标，将目标及其关联的关键结果从 OKR 结构中移除。</para>
/// <para>接口ID：7644764969658452940</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-objective/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-objective%2fdelete</para>
/// </summary>
public record DeleteOkrV2ObjectivesByObjectiveIdResponseDto
{
    /// <summary>
    /// <para>目标 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7342342398472398473</para>
    /// </summary>
    [JsonPropertyName("objective_id")]
    public string? ObjectiveId { get; set; }
}
