namespace FeishuNetSdk.Attendance;
/// <summary>
/// 获取可补卡时间 响应体
/// <para>获取用户某天可以补的第几次上 / 下班卡的时间。</para>
/// <para>接口ID：7044467124773453825</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task_remedy/query_user_allowed_remedys</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task_remedy%2fquery_user_allowed_remedys</para>
/// </summary>
public record PostAttendanceV1UserTaskRemedysQueryUserAllowedRemedysResponseDto
{
    /// <summary>
    /// <para>用户可补卡时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_allowed_remedys")]
    public UserAllowedRemedy[]? UserAllowedRemedys { get; set; }

    /// <summary>
    /// <para>用户可补卡时间</para>
    /// </summary>
    public record UserAllowedRemedy
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：abd754f7</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>补卡日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：20210104</para>
        /// </summary>
        [JsonPropertyName("remedy_date")]
        public int RemedyDate { get; set; }

        /// <summary>
        /// <para>是否为自由班次，若为自由班次，则不用选择考虑第几次上下班，直接选择补卡时间即可</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_free_punch")]
        public bool? IsFreePunch { get; set; }

        /// <summary>
        /// <para>第几次上下班，0：第 1 次上下班，1：第 2 次上下班，2：第 3 次上下班</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("punch_no")]
        public int? PunchNo { get; set; }

        /// <summary>
        /// <para>上班 / 下班，1：上班，2：下班</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("work_type")]
        public int? WorkType { get; set; }

        /// <summary>
        /// <para>打卡状态，Early：早退，Late：迟到，Lack：缺卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：Lack</para>
        /// </summary>
        [JsonPropertyName("punch_status")]
        public string? PunchStatus { get; set; }

        /// <summary>
        /// <para>正常的应打卡时间，时间格式为 yyyy-MM-dd HH:mm</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-07-0109:00</para>
        /// </summary>
        [JsonPropertyName("normal_punch_time")]
        public string? NormalPunchTime { get; set; }

        /// <summary>
        /// <para>可选的补卡时间的最小值，时间格式为 yyyy-MM-dd HH:mm</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-07-0108:00</para>
        /// </summary>
        [JsonPropertyName("remedy_start_time")]
        public string? RemedyStartTime { get; set; }

        /// <summary>
        /// <para>可选的补卡时间的最大值，时间格式为 yyyy-MM-dd HH:mm</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-07-0110:00</para>
        /// </summary>
        [JsonPropertyName("remedy_end_time")]
        public string? RemedyEndTime { get; set; }
    }
}
