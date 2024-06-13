namespace FeishuNetSdk.Attendance;
/// <summary>
/// 写入审批结果 请求体
/// <para>由于部分企业使用的是自己的审批系统，而不是飞书审批系统，因此员工的请假、加班等数据无法流入到飞书考勤系统中，导致员工在请假时间段内依然收到打卡提醒，并且被记为缺卡。</para>
/// <para>对于这些只使用飞书考勤系统，而未使用飞书审批系统的企业，可以通过考勤开放接口的形式，将三方审批结果数据回写到飞书考勤系统中。</para>
/// <para>接口ID：7108645368100274178</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_approval%2fcreate</para>
/// </summary>
public record PostAttendanceV1UserApprovalsBodyDto
{
    /// <summary>
    /// <para>审批信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_approval")]
    public PostAttendanceV1UserApprovalsBodyDtoUserApproval? UserApproval { get; set; }

    /// <summary>
    /// <para>审批信息</para>
    /// </summary>
    public record PostAttendanceV1UserApprovalsBodyDtoUserApproval
    {
        /// <summary>
        /// <para>审批提交人 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：abd754f7</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批作用日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：20210104</para>
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; } = string.Empty;

        /// <summary>
        /// <para>外出信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("outs")]
        public UserOut[]? Outs { get; set; }

        /// <summary>
        /// <para>外出信息</para>
        /// </summary>
        public record UserOut
        {
            /// <summary>
            /// <para>外出类型唯一 ID，代表一种假期类型，长度小于 14</para>
            /// <para>* 此ID对应假期类型(即: i18n_names)，因此需要保证唯一</para>
            /// <para>必填：是</para>
            /// <para>示例值：9496E43696967658A512969523E89870</para>
            /// </summary>
            [JsonPropertyName("uniq_id")]
            public string UniqId { get; set; } = string.Empty;

            /// <summary>
            /// <para>外出时长单位</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：天</item>
            /// <item>2：小时</item>
            /// <item>3：半天</item>
            /// <item>4：半小时</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("unit")]
            public int Unit { get; set; }

            /// <summary>
            /// <para>外出时长（单位：秒）</para>
            /// <para>必填：是</para>
            /// <para>示例值：28800</para>
            /// </summary>
            [JsonPropertyName("interval")]
            public int Interval { get; set; }

            /// <summary>
            /// <para>开始时间，时间格式为 yyyy-MM-dd HH:mm:ss</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-04 09:00:00</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string StartTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>结束时间，时间格式为 yyyy-MM-dd HH:mm:ss</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-04 19:00:00</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string EndTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>外出多语言展示，格式为 map，key 为 ["ch"、"en"、"ja"]，其中 ch 代表中文、en 代表英语、ja 代表日语</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("i18n_names")]
            public UserOutI18nNames I18nNames { get; set; } = new();

            /// <summary>
            /// <para>外出多语言展示，格式为 map，key 为 ["ch"、"en"、"ja"]，其中 ch 代表中文、en 代表英语、ja 代表日语</para>
            /// </summary>
            public record UserOutI18nNames
            {
                /// <summary>
                /// <para>中文描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：中文描述</para>
                /// </summary>
                [JsonPropertyName("ch")]
                public string? Ch { get; set; }

                /// <summary>
                /// <para>英语描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：English description</para>
                /// </summary>
                [JsonPropertyName("en")]
                public string? En { get; set; }

                /// <summary>
                /// <para>日语描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：日本語の説明</para>
                /// </summary>
                [JsonPropertyName("ja")]
                public string? Ja { get; set; }
            }

            /// <summary>
            /// <para>默认语言类型，由于飞书客户端支持中、英、日三种语言，当用户切换语言时，如果假期名称没有所对应的语言，会使用默认语言的名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：ch</para>
            /// </summary>
            [JsonPropertyName("default_locale")]
            public string DefaultLocale { get; set; } = string.Empty;

            /// <summary>
            /// <para>外出理由</para>
            /// <para>必填：是</para>
            /// <para>示例值：外出办事</para>
            /// </summary>
            [JsonPropertyName("reason")]
            public string Reason { get; set; } = string.Empty;

            /// <summary>
            /// <para>外出记录的唯一幂等键，用于避免外出记录重复创建，可以填入三方的外出记录id</para>
            /// <para>必填：否</para>
            /// <para>示例值：1233432312</para>
            /// </summary>
            [JsonPropertyName("idempotent_id")]
            public string? IdempotentId { get; set; }
        }

        /// <summary>
        /// <para>请假信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leaves")]
        public UserLeave[]? Leaves { get; set; }

        /// <summary>
        /// <para>请假信息</para>
        /// </summary>
        public record UserLeave
        {
            /// <summary>
            /// <para>假期类型唯一 ID，代表一种假期类型，长度小于 14</para>
            /// <para>* 此ID对应假期类型(即: i18n_names)，因此需要保证唯一</para>
            /// <para>必填：否</para>
            /// <para>示例值：6852582717813440527</para>
            /// </summary>
            [JsonPropertyName("uniq_id")]
            public string? UniqId { get; set; }

            /// <summary>
            /// <para>假期时长单位</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：天</item>
            /// <item>2：小时</item>
            /// <item>3：半天</item>
            /// <item>4：半小时</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("unit")]
            public int Unit { get; set; }

            /// <summary>
            /// <para>假期时长（单位：秒），暂未开放提供，待后续提供</para>
            /// <para>必填：是</para>
            /// <para>示例值：28800</para>
            /// </summary>
            [JsonPropertyName("interval")]
            public int Interval { get; set; }

            /// <summary>
            /// <para>开始时间，时间格式为 yyyy-MM-dd HH:mm:ss</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-04 09:00:00</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string StartTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>结束时间，时间格式为 yyyy-MM-dd HH:mm:ss</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-04 19:00:00</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string EndTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>假期多语言展示，格式为 map，key 为 ["ch"、"en"、"ja"]，其中 ch 代表中文、en 代表英语、ja 代表日语</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("i18n_names")]
            public UserLeaveI18nNames I18nNames { get; set; } = new();

            /// <summary>
            /// <para>假期多语言展示，格式为 map，key 为 ["ch"、"en"、"ja"]，其中 ch 代表中文、en 代表英语、ja 代表日语</para>
            /// </summary>
            public record UserLeaveI18nNames
            {
                /// <summary>
                /// <para>中文描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：中文描述</para>
                /// </summary>
                [JsonPropertyName("ch")]
                public string? Ch { get; set; }

                /// <summary>
                /// <para>英语描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：English description</para>
                /// </summary>
                [JsonPropertyName("en")]
                public string? En { get; set; }

                /// <summary>
                /// <para>日语描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：日本語の説明</para>
                /// </summary>
                [JsonPropertyName("ja")]
                public string? Ja { get; set; }
            }

            /// <summary>
            /// <para>默认语言类型，由于飞书客户端支持中、英、日三种语言，当用户切换语言时，如果假期名称没有所对应的语言，会使用默认语言的名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：ch</para>
            /// <para>可选值：<list type="bullet">
            /// <item>ch：中文</item>
            /// <item>en：英文</item>
            /// <item>ja：日文</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("default_locale")]
            public string DefaultLocale { get; set; } = string.Empty;

            /// <summary>
            /// <para>请假理由，必选字段</para>
            /// <para>必填：是</para>
            /// <para>示例值：家里有事</para>
            /// </summary>
            [JsonPropertyName("reason")]
            public string Reason { get; set; } = string.Empty;

            /// <summary>
            /// <para>请假记录的唯一幂等键，用于避免请假记录重复创建，可以填入三方的请假记录id</para>
            /// <para>必填：否</para>
            /// <para>示例值：1233432312</para>
            /// </summary>
            [JsonPropertyName("idempotent_id")]
            public string? IdempotentId { get; set; }
        }

        /// <summary>
        /// <para>加班信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("overtime_works")]
        public UserOvertimeWork[]? OvertimeWorks { get; set; }

        /// <summary>
        /// <para>加班信息</para>
        /// </summary>
        public record UserOvertimeWork
        {
            /// <summary>
            /// <para>加班时长</para>
            /// <para>必填：是</para>
            /// <para>示例值：1.5</para>
            /// </summary>
            [JsonPropertyName("duration")]
            public float Duration { get; set; }

            /// <summary>
            /// <para>加班时长单位</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：天</item>
            /// <item>2：小时</item>
            /// <item>3：半天</item>
            /// <item>4：半小时</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("unit")]
            public int Unit { get; set; }

            /// <summary>
            /// <para>加班日期类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：2</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：工作日</item>
            /// <item>2：休息日</item>
            /// <item>3：节假日</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("category")]
            public int Category { get; set; }

            /// <summary>
            /// <para>加班规则类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：不关联加班规则</item>
            /// <item>1：调休</item>
            /// <item>2：加班费</item>
            /// <item>3：关联加班规则，没有调休或加班费</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public int Type { get; set; }

            /// <summary>
            /// <para>开始时间，时间格式为 yyyy-MM-dd HH:mm:ss</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-09 09:00:00</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string StartTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>结束时间，时间格式为 yyyy-MM-dd HH:mm:ss</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-10 13:00:00</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string EndTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>加班事由</para>
            /// <para>必填：否</para>
            /// <para>示例值：推进项目进度</para>
            /// </summary>
            [JsonPropertyName("reason")]
            public string? Reason { get; set; }

            /// <summary>
            /// <para>加班记录的唯一幂等键，用于避免加班记录重复创建，可以填入三方的加班记录id</para>
            /// <para>必填：否</para>
            /// <para>示例值：1233432312</para>
            /// </summary>
            [JsonPropertyName("idempotent_id")]
            public string? IdempotentId { get; set; }
        }

        /// <summary>
        /// <para>出差信息。</para>
        /// <para>目前仅支持全天出差（未满全天则按全天计入）。如果你需要支持半天出差，请咨询飞书技术支持。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("trips")]
        public UserTrip[]? Trips { get; set; }

        /// <summary>
        /// <para>出差信息。</para>
        /// <para>目前仅支持全天出差（未满全天则按全天计入）。如果你需要支持半天出差，请咨询飞书技术支持。</para>
        /// </summary>
        public record UserTrip
        {
            /// <summary>
            /// <para>开始时间，时间格式为 yyyy-MM-dd HH:mm:ss</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-04 09:00:00</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string StartTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>结束时间，时间格式为 yyyy-MM-dd HH:mm:ss</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-04 19:00:00</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string EndTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>出差理由</para>
            /// <para>必填：是</para>
            /// <para>示例值：培训</para>
            /// </summary>
            [JsonPropertyName("reason")]
            public string Reason { get; set; } = string.Empty;

            /// <summary>
            /// <para>审批通过时间，时间格式为 yyyy-MM-dd HH:mm:ss</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-04 12:00:00</para>
            /// </summary>
            [JsonPropertyName("approve_pass_time")]
            public string ApprovePassTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>审批申请时间，时间格式为 yyyy-MM-dd HH:mm:ss</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-04 11:00:00</para>
            /// </summary>
            [JsonPropertyName("approve_apply_time")]
            public string ApproveApplyTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>出差记录的唯一幂等键，用于避免出差记录重复创建，可以填入三方的出差记录id</para>
            /// <para>必填：否</para>
            /// <para>示例值：1233432312</para>
            /// </summary>
            [JsonPropertyName("idempotent_id")]
            public string? IdempotentId { get; set; }
        }

        /// <summary>
        /// <para>此字段不再使用，以用户匹配的考勤组时区为准</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }
    }
}
