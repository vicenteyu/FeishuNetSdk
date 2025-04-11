// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-09-27
// ************************************************************************
// <copyright file="PostPerformanceV2RevieweesQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取被评估人信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取被评估人信息 请求体
/// <para>获取绩效周期中被圈定到项目中的被评估人信息，包括未启动的项目。</para>
/// <para>接口ID：7380276358332678145</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/reviewee/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freviewee%2fquery</para>
/// </summary>
public record PostPerformanceV2RevieweesQueryBodyDto
{
    /// <summary>
    /// <para>周期 ID，可通过[获取周期列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)</para>
    /// <para>接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6992035450862224940</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string SemesterId { get; set; } = string.Empty;

    /// <summary>
    /// <para>用户 ID，与入参 `user_id_type` 类型一致，查询指定的被评估人信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }

    /// <summary>
    /// <para>项目 ID 列表，可通过[获取项目列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/activity/query)</para>
    /// <para>接口获取，查询指定的项目下的被评估人信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("activity_ids")]
    public string[]? ActivityIds { get; set; }
}
