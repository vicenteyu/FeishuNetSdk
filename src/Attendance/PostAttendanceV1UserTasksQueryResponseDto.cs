// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostAttendanceV1UserTasksQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询打卡结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询打卡结果 响应体
/// <para>获取企业内员工的实际打卡结果，包括：</para>
/// <para>* 打卡任务列表</para>
/// <para>* 打卡记录id</para>
/// <para>* 用户信息</para>
/// <para>* 考勤组id</para>
/// <para>* 班次id</para>
/// <para>* 考勤记录</para>
/// <para>* 上班记录</para>
/// <para>* 下班记录</para>
/// <para>* 上班打卡结果</para>
/// <para>* 下班打卡结果</para>
/// <para>* 上班打卡结果补充</para>
/// <para>* 下班打卡结果补充</para>
/// <para>* 上班打卡时间</para>
/// <para>* 下班打卡时间</para>
/// <para>* 无效用户id列表</para>
/// <para>* 没有权限用户ID列表</para>
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
    [JsonPropertyName("user_task_results")]
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
        [JsonPropertyName("result_id")]
        public string ResultId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户 ID，对应employee_type</para>
        /// <para>必填：是</para>
        /// <para>示例值：abd754f7</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户姓名</para>
        /// <para>必填：是</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("employee_name")]
        public string EmployeeName { get; set; } = string.Empty;

        /// <summary>
        /// <para>日期，格式为yyyyMMdd</para>
        /// <para>必填：是</para>
        /// <para>示例值：20190819</para>
        /// </summary>
        [JsonPropertyName("day")]
        public int Day { get; set; }

        /// <summary>
        /// <para>考勤组 ID（特别说明：1代表未加入考勤组），可用于[按 ID 查询考勤组](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/group/get)</para>
        /// <para>必填：是</para>
        /// <para>示例值：6737202939523236110</para>
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// <para>班次 ID（特别说明：9代表默认班次），可用于[按 ID 查询班次](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/shift/get)</para>
        /// <para>必填：是</para>
        /// <para>示例值：6753520403404030215</para>
        /// </summary>
        [JsonPropertyName("shift_id")]
        public string ShiftId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户考勤记录</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("records")]
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
            [JsonPropertyName("check_in_record_id")]
            public string CheckInRecordId { get; set; } = string.Empty;

            /// <summary>
            /// <para>上班打卡记录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("check_in_record")]
            public UserFlow? CheckInRecord { get; set; }

            /// <summary>
            /// <para>上班打卡记录</para>
            /// </summary>
            public record UserFlow
            {
                /// <summary>
                /// <para>用户 ID，对应employee_type</para>
                /// <para>必填：是</para>
                /// <para>示例值：abd754f7</para>
                /// </summary>
                [JsonPropertyName("user_id")]
                public string UserId { get; set; } = string.Empty;

                /// <summary>
                /// <para>记录创建者 ID，对应employee_type</para>
                /// <para>必填：是</para>
                /// <para>示例值：abd754f7</para>
                /// </summary>
                [JsonPropertyName("creator_id")]
                public string CreatorId { get; set; } = string.Empty;

                /// <summary>
                /// <para>打卡位置名称信息</para>
                /// <para>必填：是</para>
                /// <para>示例值：西溪八方城</para>
                /// </summary>
                [JsonPropertyName("location_name")]
                public string LocationName { get; set; } = string.Empty;

                /// <summary>
                /// <para>打卡时间，精确到秒的时间戳</para>
                /// <para>必填：是</para>
                /// <para>示例值：1611476284</para>
                /// </summary>
                [JsonPropertyName("check_time")]
                public string CheckTime { get; set; } = string.Empty;

                /// <summary>
                /// <para>打卡备注</para>
                /// <para>必填：是</para>
                /// <para>示例值：上班打卡</para>
                /// </summary>
                [JsonPropertyName("comment")]
                public string Comment { get; set; } = string.Empty;

                /// <summary>
                /// <para>考勤内部的打卡记录ID（导入时此参数无效）</para>
                /// <para>必填：否</para>
                /// <para>示例值：6709359313699356941</para>
                /// </summary>
                [JsonPropertyName("record_id")]
                public string? RecordId { get; set; }

                /// <summary>
                /// <para>打卡 Wi-Fi 的 SSID</para>
                /// <para>必填：否</para>
                /// <para>示例值：b0:b8:67:5c:1d:72</para>
                /// </summary>
                [JsonPropertyName("ssid")]
                public string? Ssid { get; set; }

                /// <summary>
                /// <para>打卡 Wi-Fi 的 MAC 地址</para>
                /// <para>必填：否</para>
                /// <para>示例值：b0:b8:67:5c:1d:72</para>
                /// </summary>
                [JsonPropertyName("bssid")]
                public string? Bssid { get; set; }

                /// <summary>
                /// <para>是否为外勤打卡</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_field")]
                public bool? IsField { get; set; }

                /// <summary>
                /// <para>是否为 Wi-Fi 打卡</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_wifi")]
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
                [JsonPropertyName("type")]
                public int? Type { get; set; }

                /// <summary>
                /// <para>打卡照片列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("photo_urls")]
                public string[]? PhotoUrls { get; set; }

                /// <summary>
                /// <para>打卡设备ID（只支持小程序打卡，导入时无效）</para>
                /// <para>必填：否</para>
                /// <para>示例值：99e0609ee053448596502691a81428654d7ded64c7bd85acd982d26b3636c37d</para>
                /// </summary>
                [JsonPropertyName("device_id")]
                public string? DeviceId { get; set; }

                /// <summary>
                /// <para>打卡结果。目前仅返回 `PendingApproval`，表示待生效。如需获取上班打卡结果，请使用 `check_in_result` 参数。</para>
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
                [JsonPropertyName("check_result")]
                public string? CheckResult { get; set; }

                /// <summary>
                /// <para>用户导入的外部打卡记录ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：record_123</para>
                /// </summary>
                [JsonPropertyName("external_id")]
                public string? ExternalId { get; set; }

                /// <summary>
                /// <para>唯一幂等键</para>
                /// <para>必填：否</para>
                /// <para>示例值：****_***</para>
                /// </summary>
                [JsonPropertyName("idempotent_id")]
                public string? IdempotentId { get; set; }
            }

            /// <summary>
            /// <para>下班打卡记录 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：6709359313699356942</para>
            /// </summary>
            [JsonPropertyName("check_out_record_id")]
            public string CheckOutRecordId { get; set; } = string.Empty;

            /// <summary>
            /// <para>下班打卡记录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("check_out_record")]
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
            /// <item>Todo：未打卡</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("check_in_result")]
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
            /// <item>Todo：未打卡</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("check_out_result")]
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
            [JsonPropertyName("check_in_result_supplement")]
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
            [JsonPropertyName("check_out_result_supplement")]
            public string CheckOutResultSupplement { get; set; } = string.Empty;

            /// <summary>
            /// <para>上班打卡时间，秒级时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1609722000</para>
            /// </summary>
            [JsonPropertyName("check_in_shift_time")]
            public string? CheckInShiftTime { get; set; }

            /// <summary>
            /// <para>下班打卡时间，秒级时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1609754400</para>
            /// </summary>
            [JsonPropertyName("check_out_shift_time")]
            public string? CheckOutShiftTime { get; set; }

            /// <summary>
            /// <para>班次类型，0正常，1加班班次</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("task_shift_type")]
            public int? TaskShiftType { get; set; }
        }
    }

    /// <summary>
    /// <para>无效用户 ID 列表，对应employee_type</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_user_ids")]
    public string[]? InvalidUserIds { get; set; }

    /// <summary>
    /// <para>没有权限用户 ID 列表，对应employee_type</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("unauthorized_user_ids")]
    public string[]? UnauthorizedUserIds { get; set; }
}
