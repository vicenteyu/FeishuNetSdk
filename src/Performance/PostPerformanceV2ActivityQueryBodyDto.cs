// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2ActivityQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取项目配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取项目配置 请求体
/// <para>获取项目的信息，如项目名称、项目模式等</para>
/// <para>接口ID：7351374599659765764</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/activity/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2factivity%2fquery</para>
/// </summary>
public record PostPerformanceV2ActivityQueryBodyDto
{
    /// <summary>
    /// <para>评估周期 ID 列表，获取指定评估周期的项目 ID，semester_id 可通过[【获取周期】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)获得，如果同时传了「activity_ids」，则优先以「activity_ids」进行查询</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("semester_ids")]
    public string[]? SemesterIds { get; set; }

    /// <summary>
    /// <para>项目 ID 列表，如果同时传了「semester_ids」，则优先以「activity_ids」进行查询</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("activity_ids")]
    public string[]? ActivityIds { get; set; }
}
