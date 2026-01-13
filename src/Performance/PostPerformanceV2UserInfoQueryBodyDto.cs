// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-01-13
//
// Last Modified By : yxr
// Last Modified On : 2026-01-13
// ************************************************************************
// <copyright file="PostPerformanceV2UserInfoQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取绩效周期的人员信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取绩效周期的人员信息 请求体
/// <para>获取指定绩效周期下，被评估人在评估时的部门、序列、职级等人员信息。</para>
/// <para>接口ID：7477768482569650178</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/reviewee/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fuser_info%2fquery</para>
/// </summary>
public record PostPerformanceV2UserInfoQueryBodyDto
{
    /// <summary>
    /// <para>评估周期 ID 列表，semester_id 可通过[【获取周期】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：6992035450862224940</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string SemesterId { get; set; } = string.Empty;

    /// <summary>
    /// <para>人员 ID 列表，ID 类型与user_id_type 的取值一致</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = [];
}
