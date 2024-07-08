// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="PostPerformanceV2AdditionalInformationsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询补充信息 请求体/summary>
namespace FeishuNetSdk.Performance;
/// <summary>
/// 批量查询补充信息 请求体
/// <para>可批量查询被评估人的补充信息。</para>
/// <para>接口ID：7371009404255617028</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/additional_information/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fadditional_information%2fquery</para>
/// </summary>
public record PostPerformanceV2AdditionalInformationsQueryBodyDto
{
    /// <summary>
    /// <para>评估周期 ID 列表，semester_id 可通过【获取周期】接口获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：7348736302176534547</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string SemesterId { get; set; } = string.Empty;

    /// <summary>
    /// <para>事项 ID 列表，获取指定事项 ID 的信息。以下请求参数中「item_ids」、「external_ids」、「reviewee_user_ids」均为空时，返回该评估周期的所有补充信息。若单次请求中多个请求参数有值，按照【item_ids &gt; external_ids &gt; reviewee_user_ids】的顺序只识别第一个有值的请求参数</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("item_ids")]
    public string[]? ItemIds { get; set; }

    /// <summary>
    /// <para>外部系统的事项 ID 列表，获取对应的飞书绩效事项 ID。「item_ids」参数有值时该参数不生效</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("external_ids")]
    public string[]? ExternalIds { get; set; }

    /// <summary>
    /// <para>被评估人 ID 列表，获取周期下被评估人的事项信息。「item_ids」、「external_ids」参数有值时该参数不生效</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("reviewee_user_ids")]
    public string[]? RevieweeUserIds { get; set; }
}
