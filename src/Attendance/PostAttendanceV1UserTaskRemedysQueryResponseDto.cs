using Newtonsoft.Json;
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 获取补卡记录 响应体
/// <para>获取授权内员工的补卡记录。</para>
/// <para>接口ID：7044467124773666817</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task_remedy/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task_remedy%2fquery</para>
/// </summary>
public record PostAttendanceV1UserTaskRemedysQueryResponseDto
{
    /// <summary>
    /// <para>补卡记录列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_remedys")]
    public UserTaskRemedy[]? UserRemedys { get; set; }

    /// <summary>
    /// <para>补卡记录列表</para>
    /// </summary>
    public record UserTaskRemedy
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：abd754f7</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>补卡日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：20210701</para>
        /// </summary>
        [JsonProperty("remedy_date")]
        public int RemedyDate { get; set; }

        /// <summary>
        /// <para>第几次上下班，0：第 1 次上下班，1：第 2 次上下班，2：第 3 次上下班，自由班制填 0</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonProperty("punch_no")]
        public int PunchNo { get; set; }

        /// <summary>
        /// <para>上班 / 下班，1：上班，2：下班，自由班制填 0</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("work_type")]
        public int WorkType { get; set; }

        /// <summary>
        /// <para>审批 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6737202939523236113</para>
        /// </summary>
        [JsonProperty("approval_id")]
        public string? ApprovalId { get; set; }

        /// <summary>
        /// <para>补卡时间，时间格式为 yyyy-MM-dd HH:mm</para>
        /// <para>必填：是</para>
        /// <para>示例值：2021-07-0108:00</para>
        /// </summary>
        [JsonProperty("remedy_time")]
        public string RemedyTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>补卡状态（默认为审批中）</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：审批中</item>
        /// <item>1：未通过</item>
        /// <item>2：已通过</item>
        /// <item>3：已取消</item>
        /// <item>4：通过后撤回</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>补卡原因</para>
        /// <para>必填：是</para>
        /// <para>示例值：忘记打卡</para>
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; } = string.Empty;

        /// <summary>
        /// <para>补卡时间，精确到秒的时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1611476284</para>
        /// </summary>
        [JsonProperty("time")]
        public string? Time { get; set; }

        /// <summary>
        /// <para>补卡时考勤组时区</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Shanghai</para>
        /// </summary>
        [JsonProperty("time_zone")]
        public string? TimeZone { get; set; }

        /// <summary>
        /// <para>补卡发起时间，精确到秒的时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1611476284</para>
        /// </summary>
        [JsonProperty("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>补卡状态更新时间，精确到秒的时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1611476284</para>
        /// </summary>
        [JsonProperty("update_time")]
        public string? UpdateTime { get; set; }
    }
}
