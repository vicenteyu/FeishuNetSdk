using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 更新客服工作日程 请求体
/// <para>该接口用于更新客服的日程。</para>
/// <para>接口ID：6955768425688514563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent-schedules/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent-schedules%2fpatch</para>
/// </summary>
public record PatchHelpdeskV1AgentsByAgentIdSchedulesBodyDto
{
    /// <summary>
    /// <para>工作日程列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("agent_schedule")]
    public AgentScheduleUpdateInfo? AgentSchedule { get; set; }

    /// <summary>
    /// <para>工作日程列表</para>
    /// </summary>
    public record AgentScheduleUpdateInfo
    {
        /// <summary>
        /// <para>工作日程列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("schedule")]
        public WeekdaySchedule[]? Schedules { get; set; }

        /// <summary>
        /// <para>工作日程列表</para>
        /// </summary>
        public record WeekdaySchedule
        {
            /// <summary>
            /// <para>开始时间, format 00:00 - 23:59</para>
            /// <para>必填：否</para>
            /// <para>示例值：00:00</para>
            /// </summary>
            [JsonProperty("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>结束时间, format 00:00 - 23:59</para>
            /// <para>必填：否</para>
            /// <para>示例值：24:00</para>
            /// </summary>
            [JsonProperty("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>星期几, 1 - Monday, 2 - Tuesday, 3 - Wednesday, 4 - Thursday, 5 - Friday, 6 - Saturday, 7 - Sunday, 9 - Everday, 10 - Weekday, 11 - Weekend</para>
            /// <para>必填：否</para>
            /// <para>示例值：9</para>
            /// </summary>
            [JsonProperty("weekday")]
            public int? Weekday { get; set; }
        }

        /// <summary>
        /// <para>客服技能 ids</para>
        /// <para>必填：否</para>
        /// <para>示例值：[“test-skill-id”]</para>
        /// </summary>
        [JsonProperty("agent_skill_ids")]
        public string[]? AgentSkillIds { get; set; }
    }
}
