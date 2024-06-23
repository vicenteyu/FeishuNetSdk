// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostReportV1RulesByRuleIdViewsRemoveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>移除规则看板 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Report;
/// <summary>
/// 移除规则看板 请求体
/// <para>移除规则看板</para>
/// <para>接口ID：6993276991760056323</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/report-v1/rule-view/remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2freport%2freport-v1%2frule-view%2fremove</para>
/// </summary>
public record PostReportV1RulesByRuleIdViewsRemoveBodyDto
{
    /// <summary>
    /// <para>列表为空删除规则下全用户视图，列表不为空删除指定用户视图，大小限制200。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_d6a5b5a55c77ca0b5b6c6ca0dd628c85","ou_d6a5b5a55c77ca0b5b6c6ca0dd628c55"]</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }
}
