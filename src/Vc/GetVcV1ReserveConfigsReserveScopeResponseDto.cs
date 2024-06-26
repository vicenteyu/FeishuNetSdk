// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="GetVcV1ReserveConfigsReserveScopeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询会议室预定限制 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 查询会议室预定限制 响应体
/// <para>查询会议室预定限制。</para>
/// <para>接口ID：7152043170151333892</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/reserve_scope</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config%2freserve_scope</para>
/// </summary>
public record GetVcV1ReserveConfigsReserveScopeResponseDto
{
    /// <summary>
    /// <para>预定审批设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approve_config")]
    public ApprovalConfig? ApproveConfig { get; set; }

    /// <summary>
    /// <para>预定审批设置</para>
    /// </summary>
    public record ApprovalConfig
    {
        /// <summary>
        /// <para>预定审批开关：0 代表关闭，1 代表打开。</para>
        /// <para>说明：</para>
        /// <para>- 未设置值时不更新原开关的值，但此时必填 approval_condition</para>
        /// <para>- 设置值为 1 时，必填 approval_condition</para>
        /// <para>- 设置值为 0 时整个</para>
        /// <para>approval_config 其他字段均可省略。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>最大值：1</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("approval_switch")]
        public int? ApprovalSwitch { get; set; }

        /// <summary>
        /// <para>预定审批条件：0 代表所有预定均需审批，1 代表满足条件的需审批</para>
        /// <para>说明：为 1 时必填 **meeting_duration**</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>最大值：1</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("approval_condition")]
        public int? ApprovalCondition { get; set; }

        /// <summary>
        /// <para>超过 meeting_duration</para>
        /// <para>的预定需要审批（单位：小时，取值范围[0.1-99]）</para>
        /// <para>说明：</para>
        /// <para>- 当 approval_condition</para>
        /// <para>为 0 ，更新时如果未设置值，默认更新为 99 .</para>
        /// <para>- 传入的值小数点后超过 2 位，自动四舍五入保留两位。</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("meeting_duration")]
        public float? MeetingDuration { get; set; }

        /// <summary>
        /// <para>审批人列表，当打开审批开关时，至少需要设置一位审批人</para>
        /// <para>必填：否</para>
        /// <para>示例值：[{user_id:"ou_e8bce6c3935ef1fc1b432992fd9d3db8"}]</para>
        /// </summary>
        [JsonPropertyName("approvers")]
        public SubscribeUser[]? Approvers { get; set; }

        /// <summary>
        /// <para>审批人列表，当打开审批开关时，至少需要设置一位审批人</para>
        /// </summary>
        public record SubscribeUser
        {
            /// <summary>
            /// <para>预定管理员ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：ou_a27b0xxxc98f856</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string UserId { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>预定时间设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("time_config")]
    public GetVcV1ReserveConfigsReserveScopeResponseDtoTimeConfig? TimeConfig { get; set; }

    /// <summary>
    /// <para>预定时间设置</para>
    /// </summary>
    public record GetVcV1ReserveConfigsReserveScopeResponseDtoTimeConfig
    {
        /// <summary>
        /// <para>是否覆盖子层级及会议室</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("if_cover_child_scope")]
        public bool? IfCoverChildScope { get; set; }

        /// <summary>
        /// <para>预定时间开关：0 代表关闭，1 代表开启</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最大值：1</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("time_switch")]
        public int TimeSwitch { get; set; }

        /// <summary>
        /// <para>最早可提前</para>
        /// <para>days_in_advance 预定会议室（单位：天，取值范围[1-730]）</para>
        /// <para>说明：不填写时，默认更新为 365</para>
        /// <para>必填：否</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonPropertyName("days_in_advance")]
        public int? DaysInAdvance { get; set; }

        /// <summary>
        /// <para>开放当天可于</para>
        /// <para>opening_hour 开始预定（单位：秒，取值范围[0,86400]）</para>
        /// <para>说明：</para>
        /// <para>- 不填写时默认更新为</para>
        /// <para>28800</para>
        /// <para>- 如果填写的值不是 60</para>
        /// <para>的倍数，则自动会更新为离其最近的 60 整数倍的值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：27900</para>
        /// </summary>
        [JsonPropertyName("opening_hour")]
        public string? OpeningHour { get; set; }

        /// <summary>
        /// <para>每日可预定时间范围的开始时间（单位：秒，取值范围[0,86400]）</para>
        /// <para>说明：</para>
        /// <para>- 不填写时，默认更新为 0 ，此时填写的 end_time 不得小于 30。</para>
        /// <para>- 当 start_time 与</para>
        /// <para>end_time 均填写时</para>
        /// <para>end_time 至少超过</para>
        /// <para>start_time 30 。</para>
        /// <para>- 如果填写的值不是 60 的倍数，则自动会更新为离其最近的 60 整数倍的值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>每日可预定时间范围结束时间（单位：秒，取值范围[0,86400]）</para>
        /// <para>说明：</para>
        /// <para>- 不填写时，默认更新为 86400 ，此时填写的</para>
        /// <para>start_time 不得大于等于 86370 。</para>
        /// <para>- 当 start_time 与</para>
        /// <para>end_time 均填写时</para>
        /// <para>end_time 至少要超过</para>
        /// <para>start_time 30。</para>
        /// <para>- 如果填写的值不是 60 的倍数，则自动会更新为离其最近的 60 整数倍的值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：86400</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>单次会议室可预定时长上限（单位：小时，取值范围[1,99]）</para>
        /// <para>说明：不填写时默认更新为 2</para>
        /// <para>必填：否</para>
        /// <para>示例值：24</para>
        /// </summary>
        [JsonPropertyName("max_duration")]
        public int? MaxDuration { get; set; }
    }

    /// <summary>
    /// <para>预定范围设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reserve_scope_config")]
    public GetVcV1ReserveConfigsReserveScopeResponseDtoReserveScopeConfig? ReserveScopeConfig { get; set; }

    /// <summary>
    /// <para>预定范围设置</para>
    /// </summary>
    public record GetVcV1ReserveConfigsReserveScopeResponseDtoReserveScopeConfig
    {
        /// <summary>
        /// <para>是否覆盖子层级及会议室</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("if_cover_child_scope")]
        public bool? IfCoverChildScope { get; set; }

        /// <summary>
        /// <para>可预定成员范围：0 代表部分成员，1 代表全部成员。</para>
        /// <para>说明：</para>
        /// <para>- 此值必填。</para>
        /// <para>- 当设置为 0 时，至少需要 1 个预定部门或预定人</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>最大值：1</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("allow_all_users")]
        public int? AllowAllUsers { get; set; }

        /// <summary>
        /// <para>可预定成员列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：[{user_id:"ou_e8bce6c3935ef1fc1b432992fd9d3db8"}]</para>
        /// </summary>
        [JsonPropertyName("allow_users")]
        public SubscribeUser[]? AllowUsers { get; set; }

        /// <summary>
        /// <para>可预定成员列表</para>
        /// </summary>
        public record SubscribeUser
        {
            /// <summary>
            /// <para>预定管理员ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：ou_a27bxxx8f856</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string UserId { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>可预定部门列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：[{department_id:"od-5c07f0c117cf8795f25610a69363ce31"}]</para>
        /// </summary>
        [JsonPropertyName("allow_depts")]
        public SubscribeDepartment[]? AllowDepts { get; set; }

        /// <summary>
        /// <para>可预定部门列表</para>
        /// </summary>
        public record SubscribeDepartment
        {
            /// <summary>
            /// <para>预定管理部门ID，使用open_department_id</para>
            /// <para>必填：是</para>
            /// <para>示例值：od-47d8b5xxxcc5f61a</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string DepartmentId { get; set; } = string.Empty;
        }
    }
}
