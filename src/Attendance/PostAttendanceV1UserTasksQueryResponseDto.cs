using Newtonsoft.Json;
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询打卡结果 响应体
/// <para>获取企业内员工的实际打卡结果，包括上班打卡结果和下班打卡结果。</para>
/// <para>接口ID：7044467124773421057</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task%2fquery</para>
/// </summary>
public record PostAttendanceV1UserTasksQueryResponseDto
{
    /// <summary>
    /// <para>打卡任务列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_task_results")]
    public UserTask[]? UserTaskResults { get; set; }

    /// <summary>
    /// <para>打卡任务列表</para>
    /// </summary>
    public record UserTask
    {
        /// <summary>
        /// <para>打卡记录 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6709359313699356941</para>
        /// </summary>
        [JsonProperty("result_id")]
        public string ResultId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：abd754f7</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户姓名</para>
        /// <para>必填：是</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonProperty("employee_name")]
        public string EmployeeName { get; set; } = string.Empty;

        /// <summary>
        /// <para>日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：20190819</para>
        /// </summary>
        [JsonProperty("day")]
        public int Day { get; set; }

        /// <summary>
        /// <para>考勤组 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6737202939523236110</para>
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// <para>班次 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6753520403404030215</para>
        /// </summary>
        [JsonProperty("shift_id")]
        public string ShiftId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户考勤记录</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("records")]
        public TaskResult[] Records { get; set; } = Array.Empty<TaskResult>();

        /// <summary>
        /// <para>用户考勤记录</para>
        /// </summary>
        public record TaskResult
        {
            /// <summary>
            /// <para>上班打卡记录 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：6709359313699356941</para>
            /// </summary>
            [JsonProperty("check_in_record_id")]
            public string CheckInRecordId { get; set; } = string.Empty;

            /// <summary>
            /// <para>上班打卡记录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("check_in_record")]
            public UserFlow? CheckInRecord { get; set; }

            /// <summary>
            /// <para>上班打卡记录</para>
            /// </summary>
            public record UserFlow
            {
                /// <summary>
                /// <para>用户 ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：abd754f7</para>
                /// </summary>
                [JsonProperty("user_id")]
                public string UserId { get; set; } = string.Empty;

                /// <summary>
                /// <para>记录创建者 ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：abd754f7</para>
                /// </summary>
                [JsonProperty("creator_id")]
                public string CreatorId { get; set; } = string.Empty;

                /// <summary>
                /// <para>打卡位置名称信息</para>
                /// <para>必填：是</para>
                /// <para>示例值：西溪八方城</para>
                /// </summary>
                [JsonProperty("location_name")]
                public string LocationName { get; set; } = string.Empty;

                /// <summary>
                /// <para>打卡时间，精确到秒的时间戳</para>
                /// <para>必填：是</para>
                /// <para>示例值：1611476284</para>
                /// </summary>
                [JsonProperty("check_time")]
                public string CheckTime { get; set; } = string.Empty;

                /// <summary>
                /// <para>打卡备注</para>
                /// <para>必填：是</para>
                /// <para>示例值：上班打卡</para>
                /// </summary>
                [JsonProperty("comment")]
                public string Comment { get; set; } = string.Empty;

                /// <summary>
                /// <para>打卡记录 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6709359313699356941</para>
                /// </summary>
                [JsonProperty("record_id")]
                public string? RecordId { get; set; }

                /// <summary>
                /// <para>打卡 Wi-Fi 的 SSID</para>
                /// <para>必填：否</para>
                /// <para>示例值：b0:b8:67:5c:1d:72</para>
                /// </summary>
                [JsonProperty("ssid")]
                public string? Ssid { get; set; }

                /// <summary>
                /// <para>打卡 Wi-Fi 的 MAC 地址</para>
                /// <para>必填：否</para>
                /// <para>示例值：b0:b8:67:5c:1d:72</para>
                /// </summary>
                [JsonProperty("bssid")]
                public string? Bssid { get; set; }

                /// <summary>
                /// <para>是否为外勤打卡</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonProperty("is_field")]
                public bool? IsField { get; set; }

                /// <summary>
                /// <para>是否为 Wi-Fi 打卡</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonProperty("is_wifi")]
                public bool? IsWifi { get; set; }

                /// <summary>
                /// <para>记录生成方式</para>
                /// <para>必填：否</para>
                /// <para>示例值：7</para>
                /// <para>可选值：<list type="bullet">
                /// <item>0：用户打卡</item>
                /// <item>1：管理员修改</item>
                /// <item>2：用户补卡</item>
                /// <item>3：系统自动生成</item>
                /// <item>4：下班免打卡</item>
                /// <item>5：考勤机</item>
                /// <item>6：极速打卡</item>
                /// <item>7：考勤开放平台导入</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("type")]
                public int? Type { get; set; }

                /// <summary>
                /// <para>打卡照片列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("photo_urls")]
                public string[]? PhotoUrls { get; set; }

                /// <summary>
                /// <para>打卡结果</para>
                /// <para>必填：否</para>
                /// <para>示例值：Invalid</para>
                /// <para>可选值：<list type="bullet">
                /// <item>NoNeedCheck：无需打卡</item>
                /// <item>SystemCheck：系统打卡（已弃用）</item>
                /// <item>Normal：正常</item>
                /// <item>Early：早退</item>
                /// <item>Late：迟到</item>
                /// <item>SeriousLate：严重迟到</item>
                /// <item>Lack：缺卡</item>
                /// <item>Invalid：无效</item>
                /// <item>None：无状态</item>
                /// <item>Todo：尚未打卡</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("check_result")]
                public string? CheckResult { get; set; }
            }

            /// <summary>
            /// <para>下班打卡记录 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：6709359313699356942</para>
            /// </summary>
            [JsonProperty("check_out_record_id")]
            public string CheckOutRecordId { get; set; } = string.Empty;

            /// <summary>
            /// <para>下班打卡记录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("check_out_record")]
            public UserFlow? CheckOutRecord { get; set; }

            /// <summary>
            /// <para>上班打卡结果</para>
            /// <para>必填：是</para>
            /// <para>示例值：SystemCheck</para>
            /// <para>可选值：<list type="bullet">
            /// <item>NoNeedCheck：无需打卡</item>
            /// <item>SystemCheck：系统打卡（已弃用）</item>
            /// <item>Normal：正常</item>
            /// <item>Early：早退</item>
            /// <item>Late：迟到</item>
            /// <item>Lack：缺卡</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("check_in_result")]
            public string CheckInResult { get; set; } = string.Empty;

            /// <summary>
            /// <para>下班打卡结果</para>
            /// <para>必填：是</para>
            /// <para>示例值：SystemCheck</para>
            /// <para>可选值：<list type="bullet">
            /// <item>NoNeedCheck：无需打卡</item>
            /// <item>SystemCheck：系统打卡（已弃用）</item>
            /// <item>Normal：正常</item>
            /// <item>Early：早退</item>
            /// <item>Late：迟到</item>
            /// <item>Lack：缺卡</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("check_out_result")]
            public string CheckOutResult { get; set; } = string.Empty;

            /// <summary>
            /// <para>上班打卡结果补充</para>
            /// <para>必填：是</para>
            /// <para>示例值：None</para>
            /// <para>可选值：<list type="bullet">
            /// <item>None：无</item>
            /// <item>ManagerModification：管理员修改</item>
            /// <item>CardReplacement：补卡通过</item>
            /// <item>ShiftChange：换班</item>
            /// <item>Travel：出差</item>
            /// <item>Leave：请假</item>
            /// <item>GoOut：外出</item>
            /// <item>CardReplacementApplication：补卡申请中</item>
            /// <item>FieldPunch：外勤打卡</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("check_in_result_supplement")]
            public string CheckInResultSupplement { get; set; } = string.Empty;

            /// <summary>
            /// <para>下班打卡结果补充</para>
            /// <para>必填：是</para>
            /// <para>示例值：None</para>
            /// <para>可选值：<list type="bullet">
            /// <item>None：无</item>
            /// <item>ManagerModification：管理员修改</item>
            /// <item>CardReplacement：补卡通过</item>
            /// <item>ShiftChange：换班</item>
            /// <item>Travel：出差</item>
            /// <item>Leave：请假</item>
            /// <item>GoOut：外出</item>
            /// <item>CardReplacementApplication：补卡申请中</item>
            /// <item>FieldPunch：外勤打卡</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("check_out_result_supplement")]
            public string CheckOutResultSupplement { get; set; } = string.Empty;

            /// <summary>
            /// <para>上班打卡时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1609722000</para>
            /// </summary>
            [JsonProperty("check_in_shift_time")]
            public string? CheckInShiftTime { get; set; }

            /// <summary>
            /// <para>下班打卡时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1609754400</para>
            /// </summary>
            [JsonProperty("check_out_shift_time")]
            public string? CheckOutShiftTime { get; set; }

            /// <summary>
            /// <para>班次类型，0正常，1加班班次</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonProperty("task_shift_type")]
            public int? TaskShiftType { get; set; }
        }
    }

    /// <summary>
    /// <para>无效用户 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("invalid_user_ids")]
    public string[]? InvalidUserIds { get; set; }

    /// <summary>
    /// <para>没有权限用户 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("unauthorized_user_ids")]
    public string[]? UnauthorizedUserIds { get; set; }
}
