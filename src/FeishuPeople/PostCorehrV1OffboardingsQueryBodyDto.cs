// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV1OffboardingsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询员工离职原因列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询员工离职原因列表 请求体
/// <para>查询「飞书人事」-「离职设置」中的离职原因。</para>
/// <para>接口ID：7097044451155197956</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fquery</para>
/// </summary>
public record PostCorehrV1OffboardingsQueryBodyDto
{
    /// <summary>
    /// <para>是否启用</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// <para>离职原因唯一标识列表，用于过滤，最大20个</para>
    /// <para>必填：否</para>
    /// <para>示例值：["reason_for_offboarding_option"]</para>
    /// </summary>
    [JsonPropertyName("offboarding_reason_unique_identifier")]
    public string[]? OffboardingReasonUniqueIdentifier { get; set; }
}
