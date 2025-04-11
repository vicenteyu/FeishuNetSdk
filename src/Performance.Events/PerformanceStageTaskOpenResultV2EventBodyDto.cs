// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="PerformanceStageTaskOpenResultV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>绩效结果开通 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance.Events;
/// <summary>
/// 绩效结果开通 事件体
/// <para>当员工的绩效结果开通时，订阅这个事件的应用会收到该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=performance&amp;version=v2&amp;resource=stage_task&amp;event=open_result)</para>
/// <para>接口ID：7351374599659831300</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/stage_task/events/open_result</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fstage_task%2fevents%2fopen_result</para>
/// </summary>
public record PerformanceStageTaskOpenResultV2EventBodyDto() : EventBodyDto("performance.stage_task.open_result_v2")
{
    /// <summary>
    /// <para>新开通绩效结果的被评估人列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `9999999`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public OpenResult[]? Items { get; set; }

    /// <summary></summary>
    public record OpenResult
    {
        /// <summary>
        /// <para>员工 ID，用户 ID 类型请参考：[用户资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/field-overview)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public UserIdSuffix? UserId { get; set; }

        /// <summary>
        /// <para>绩效评估周期 ID，详情可查看：[获取周期](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("semester_id")]
        public string? SemesterId { get; set; }

        /// <summary>
        /// <para>绩效评估项目 ID，详情可查看：[获取项目配置](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/activity/query)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string? ActivityId { get; set; }

        /// <summary>
        /// <para>结果开通时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_time")]
        public string? OpenTime { get; set; }
    }
}
