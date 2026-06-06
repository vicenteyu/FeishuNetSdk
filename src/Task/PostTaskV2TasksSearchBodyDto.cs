// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PostTaskV2TasksSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 搜索任务 请求体
/// <para>通过任务关键词搜索任务的信息，包括任务名称、任务链接、任务ID、任务描述</para>
/// <para>接口ID：7645347118866533319</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fsearch</para>
/// </summary>
public record PostTaskV2TasksSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键字</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试任务</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// <para>搜索过滤器，包括 任务创建人、负责人、完成状态、截止时间范围、关注人。默认为空，不做过滤</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public TaskSearchFilter? Filter { get; set; }

    /// <summary>
    /// <para>搜索过滤器，包括 任务创建人、负责人、完成状态、截止时间范围、关注人。默认为空，不做过滤</para>
    /// </summary>
    public record TaskSearchFilter
    {
        /// <summary>
        /// <para>创建人 IDs</para>
        /// <para>必填：否</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("creator_ids")]
        public string[]? CreatorIds { get; set; }

        /// <summary>
        /// <para>负责人 IDs</para>
        /// <para>必填：否</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("assignee_ids")]
        public string[]? AssigneeIds { get; set; }

        /// <summary>
        /// <para>完成状态，设置为true只返回已完成任务，设置为false只返回未完成任务，未设置时不筛选</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_completed")]
        public bool? IsCompleted { get; set; }

        /// <summary>
        /// <para>截止时间，无需同时设置，但开始时间需要小于结束时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("due_time")]
        public TimeRange? DueTime { get; set; }

        /// <summary>
        /// <para>截止时间，无需同时设置，但开始时间需要小于结束时间</para>
        /// </summary>
        public record TimeRange
        {
            /// <summary>
            /// <para>范围内的起始时间 (ISO 8601)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>范围内的结束时间 (ISO 8601)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }
        }

        /// <summary>
        /// <para>关注人 IDs</para>
        /// <para>必填：否</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("follower_ids")]
        public string[]? FollowerIds { get; set; }
    }
}
