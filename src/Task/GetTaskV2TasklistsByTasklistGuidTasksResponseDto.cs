using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 获取清单任务列表 响应体
/// <para>获取一个清单的任务列表，返回任务的摘要信息。</para>
/// <para>本接口支持分页。清单中的任务以“自定义拖拽”的顺序返回。</para>
/// <para>本接口支持简单的按照任务的完成状态或者任务的创建时间范围过滤。</para>
/// <para>接口ID：7255580838154698780</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/tasks</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2ftasks</para>
/// </summary>
public record GetTaskV2TasklistsByTasklistGuidTasksResponseDto
{
    /// <summary>
    /// <para>任务摘要数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public TaskSummary[]? Items { get; set; }

    /// <summary>
    /// <para>任务摘要数据</para>
    /// </summary>
    public record TaskSummary
    {
        /// <summary>
        /// <para>任务GUID</para>
        /// <para>必填：否</para>
        /// <para>示例值：e297ddff-06ca-4166-b917-4ce57cd3a7a0</para>
        /// </summary>
        [JsonProperty("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>任务标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：年终总结</para>
        /// <para>最大长度：10000</para>
        /// </summary>
        [JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// <para>任务完成的时间戳(ms)，为0表示未完成</para>
        /// <para>必填：否</para>
        /// <para>示例值：1675742789470</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonProperty("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// <para>任务开始时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("start")]
        public TaskSummaryStart? Start { get; set; }

        /// <summary>
        /// <para>任务开始时间</para>
        /// </summary>
        public record TaskSummaryStart
        {
            /// <summary>
            /// <para>开始时间/日期的时间戳，距1970-01-01 00:00:00的毫秒数。如果开始时间是一个日期，需要把日期转换成时间戳，并设置 is_all_day=true</para>
            /// <para>必填：否</para>
            /// <para>示例值：1675454764000</para>
            /// </summary>
            [JsonProperty("timestamp")]
            public string? Timestamp { get; set; }

            /// <summary>
            /// <para>是否开始于一个日期。如果设为true，timestamp中只有日期的部分会被解析和存储。</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("is_all_day")]
            public bool? IsAllDay { get; set; }
        }

        /// <summary>
        /// <para>任务截止时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("due")]
        public TaskSummaryDue? Due { get; set; }

        /// <summary>
        /// <para>任务截止时间</para>
        /// </summary>
        public record TaskSummaryDue
        {
            /// <summary>
            /// <para>截止时间/日期的时间戳，距1970-01-01 00:00:00的毫秒数。如果截止时间是一个日期，需要把日期转换成时间戳，并设置 is_all_day=true</para>
            /// <para>必填：否</para>
            /// <para>示例值：1675454764000</para>
            /// </summary>
            [JsonProperty("timestamp")]
            public string? Timestamp { get; set; }

            /// <summary>
            /// <para>是否截止到一个日期。如果设为true，timestamp中只有日期的部分会被解析和存储。</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("is_all_day")]
            public bool? IsAllDay { get; set; }
        }

        /// <summary>
        /// <para>任务成员列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("members")]
        public Member[]? Members { get; set; }

        /// <summary>
        /// <para>任务成员列表</para>
        /// </summary>
        public record Member
        {
            /// <summary>
            /// <para>表示member的id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
            /// <para>最大长度：100</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>成员的类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>成员角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：assignee</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonProperty("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>子任务的个数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("subtask_count")]
        public int? SubtaskCount { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：aWQ9NzEwMjMzMjMxMDE=</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
