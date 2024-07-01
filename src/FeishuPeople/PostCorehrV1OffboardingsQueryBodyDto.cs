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
/// <para>该接口用于查询[离职配置](https://people.feishu.cn/people/hr-settings/dimission/setting)&gt; 离职原因的选项信息，包括离职原因选项的唯一标识、名称和启用状态等信息。</para>
/// <para>接口ID：7097044451155197956</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fquery</para>
/// </summary>
public record PostCorehrV1OffboardingsQueryBodyDto
{
    /// <summary>
    /// <para>离职原因状态，为空时默认搜索所有状态的离职原因。可选项有:</para>
    /// <para>-true: 启用</para>
    /// <para>-false: 停用</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// <para>离职原因唯一标识列表，用于过滤离职原因，为空时默认搜索所有离职原因，最多支持20个</para>
    /// <para>必填：否</para>
    /// <para>示例值：["reason_for_offboarding_option"]</para>
    /// </summary>
    [JsonPropertyName("offboarding_reason_unique_identifier")]
    public string[]? OffboardingReasonUniqueIdentifier { get; set; }
}
