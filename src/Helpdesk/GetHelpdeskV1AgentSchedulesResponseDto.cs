namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 查询全部客服工作日程 响应体
/// <para>该接口用于获取所有客服信息。</para>
/// <para>接口ID：6955768425688350723</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent-schedules/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_schedule%2flist</para>
/// </summary>
public record GetHelpdeskV1AgentSchedulesResponseDto
{
    /// <summary>
    /// <para>客服列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("agent_schedules")]
    public AgentSchedule[]? AgentSchedules { get; set; }

    /// <summary>
    /// <para>客服列表</para>
    /// </summary>
    public record AgentSchedule
    {
        /// <summary>
        /// <para>客服状态, 1 - online客服, 2 - offline(手动)客服, 3 - off duty(下班)自动处于非服务时间段</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>客服信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agent")]
        public AgentUser? Agent { get; set; }

        /// <summary>
        /// <para>客服信息</para>
        /// </summary>
        public record AgentUser
        {
            /// <summary>
            /// <para>客服 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_ea651a5c09e2d01af8acd34059f5359b</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>avatar url</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://avatar-url.com/test.png</para>
            /// </summary>
            [JsonPropertyName("avatar_url")]
            public string? AvatarUrl { get; set; }

            /// <summary>
            /// <para>客服名字</para>
            /// <para>必填：否</para>
            /// <para>示例值：test-user</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>email</para>
            /// <para>必填：否</para>
            /// <para>示例值：test@bytedance.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>部门</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试部门</para>
            /// </summary>
            [JsonPropertyName("department")]
            public string? Department { get; set; }

            /// <summary>
            /// <para>公司名</para>
            /// <para>必填：否</para>
            /// <para>示例值：test-company</para>
            /// </summary>
            [JsonPropertyName("company_name")]
            public string? CompanyName { get; set; }
        }

        /// <summary>
        /// <para>工作日程列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("schedule")]
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
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>结束时间, format 00:00 - 23:59</para>
            /// <para>必填：否</para>
            /// <para>示例值：24:00</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>星期几, 1 - Monday, 2 - Tuesday, 3 - Wednesday, 4 - Thursday, 5 - Friday, 6 - Saturday, 7 - Sunday, 9 - Everday, 10 - Weekday, 11 - Weekend</para>
            /// <para>必填：否</para>
            /// <para>示例值：9</para>
            /// </summary>
            [JsonPropertyName("weekday")]
            public int? Weekday { get; set; }
        }

        /// <summary>
        /// <para>客服技能</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agent_skills")]
        public AgentSkillLessInfo[]? AgentSkills { get; set; }

        /// <summary>
        /// <para>客服技能</para>
        /// </summary>
        public record AgentSkillLessInfo
        {
            /// <summary>
            /// <para>客服技能 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：agent-skill-id</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>客服技能名</para>
            /// <para>必填：否</para>
            /// <para>示例值：agent-skill</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>是默认技能</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_default")]
            public bool? IsDefault { get; set; }
        }
    }
}
