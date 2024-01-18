namespace FeishuNetSdk.Attendance;
/// <summary>
/// 获取审批通过数据 响应体
/// <para>获取员工在某段时间内的请假、加班、外出和出差四种审批的通过数据。</para>
/// <para>接口ID：7108645368100257794</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_approval/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_approval%2fquery</para>
/// </summary>
public record PostAttendanceV1UserApprovalsQueryResponseDto
{
    /// <summary>
    /// <para>审批结果列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_approvals")]
    public UserApproval[]? UserApprovals { get; set; }

    /// <summary>
    /// <para>审批结果列表</para>
    /// </summary>
    public record UserApproval
    {
        /// <summary>
        /// <para>审批用户 ID</para>
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
            /// <para>审批实例 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6737202939523236113</para>
            /// </summary>
            [JsonPropertyName("approval_id")]
            public string? ApprovalId { get; set; }

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
            /// <para>开始时间，时间格式为 yyyy-MM-dd HH:mm:ss。</para>
            /// <para>时间按照审批发起人当前考勤组的时区进行取值，如果发起人已离职，则默认为 0 时区。</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-04 09:00:00</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string StartTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>结束时间，时间格式为 yyyy-MM-dd HH:mm:ss。</para>
            /// <para>时间按照审批发起人当前考勤组的时区进行取值，如果发起人已离职，则默认为 0 时区。</para>
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
            /// <para>审批通过时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-01-04 12:00:00</para>
            /// </summary>
            [JsonPropertyName("approve_pass_time")]
            public string? ApprovePassTime { get; set; }

            /// <summary>
            /// <para>审批申请时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-01-04 11:00:00</para>
            /// </summary>
            [JsonPropertyName("approve_apply_time")]
            public string? ApproveApplyTime { get; set; }
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
            /// <para>审批实例 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6737202939523236113</para>
            /// </summary>
            [JsonPropertyName("approval_id")]
            public string? ApprovalId { get; set; }

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
            /// <para>开始时间，时间格式为 yyyy-MM-dd HH:mm:ss。</para>
            /// <para>时间按照审批发起人当前考勤组的时区进行取值，如果发起人已离职，则默认为 0 时区。</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-04 09:00:00</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string StartTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>结束时间，时间格式为 yyyy-MM-dd HH:mm:ss。</para>
            /// <para>时间按照审批发起人当前考勤组的时区进行取值，如果发起人已离职，则默认为 0 时区。</para>
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
            /// <para>审批通过时间，时间格式为 yyyy-MM-dd HH:mm:ss</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-01-04 12:00:00</para>
            /// </summary>
            [JsonPropertyName("approve_pass_time")]
            public string? ApprovePassTime { get; set; }

            /// <summary>
            /// <para>审批申请时间，时间格式为 yyyy-MM-dd HH:mm:ss</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-01-04 11:00:00</para>
            /// </summary>
            [JsonPropertyName("approve_apply_time")]
            public string? ApproveApplyTime { get; set; }
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
            /// <para>审批实例 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6737202939523236113</para>
            /// </summary>
            [JsonPropertyName("approval_id")]
            public string? ApprovalId { get; set; }

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
            /// <para>开始时间，时间格式为 yyyy-MM-dd HH:mm:ss。</para>
            /// <para>时间按照审批发起人当前考勤组的时区进行取值，如果发起人已离职，则默认为 0 时区。</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-09 09:00:00</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string StartTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>结束时间，时间格式为 yyyy-MM-dd HH:mm:ss。</para>
            /// <para>时间按照审批发起人当前考勤组的时区进行取值，如果发起人已离职，则默认为 0 时区。</para>
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
        }

        /// <summary>
        /// <para>出差信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("trips")]
        public UserTrip[]? Trips { get; set; }

        /// <summary>
        /// <para>出差信息</para>
        /// </summary>
        public record UserTrip
        {
            /// <summary>
            /// <para>审批实例 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6737202939523236113</para>
            /// </summary>
            [JsonPropertyName("approval_id")]
            public string? ApprovalId { get; set; }

            /// <summary>
            /// <para>开始时间，时间格式为 yyyy-MM-dd HH:mm:ss。</para>
            /// <para>时间按照审批发起人当前考勤组的时区进行取值，如果发起人已离职，则默认为 0 时区。</para>
            /// <para>必填：是</para>
            /// <para>示例值：2021-01-04 09:00:00</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string StartTime { get; set; } = string.Empty;

            /// <summary>
            /// <para>结束时间，时间格式为 yyyy-MM-dd HH:mm:ss。</para>
            /// <para>时间按照审批发起人当前考勤组的时区进行取值，如果发起人已离职，则默认为 0 时区。</para>
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
        }

        /// <summary>
        /// <para>计算时间所用的时区信息，为空是0时区</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Shanghai</para>
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }
    }
}
