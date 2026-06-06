// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PostOkrV2ObjectivesByObjectiveIdKeyResultsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>在目标下创建关键结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 在目标下创建关键结果 响应体
/// <para>在指定目标下创建一个新的关键结果。使用富文本结构定义关键结果内容，设置截止时间和打分。</para>
/// <para>接口ID：7644764969658239948</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-objective-key_result/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-objective-key_result%2fcreate</para>
/// </summary>
public record PostOkrV2ObjectivesByObjectiveIdKeyResultsResponseDto
{
    /// <summary>
    /// <para>关键结果 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7342342398472398473</para>
    /// </summary>
    [JsonPropertyName("key_result_id")]
    public string? KeyResultId { get; set; }
}
