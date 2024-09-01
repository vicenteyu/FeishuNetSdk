// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="VcReserveConfigUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新会议室预定限制 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc.Events;
/// <summary>
/// 更新会议室预定限制 事件体
/// <para>当更新会议室预定限制时，会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=vc&amp;version=v1&amp;resource=reserve_config&amp;event=updated)</para>
/// <para>接口ID：7194805625627983875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config%2fevents%2fupdated</para>
/// </summary>
public record VcReserveConfigUpdatedV1EventBodyDto() : EventBodyDto("vc.reserve_config.updated_v1")
{
    /// <summary>
    /// <para>会议室或层级id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("scope_id")]
    public string? ScopeId { get; set; }

    /// <summary>
    /// <para>1代表层级，2代表会议室</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 取值范围：`1` ～ `2`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("scope_type")]
    public int? ScopeType { get; set; }

    /// <summary>
    /// <para>预定审批设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approve_config")]
    public ApprovalConfigEvent? ApproveConfig { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record ApprovalConfigEvent
    {
        /// <summary>
        /// <para>预定审批开关，0关闭，1打开</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 取值范围：`0` ～ `1`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("approval_switch")]
        public int? ApprovalSwitch { get; set; }

        /// <summary>
        /// <para>预定审批条件，0所有预定需要审批，1满足条件需审批</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 取值范围：`0` ～ `1`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("approval_condition")]
        public int? ApprovalCondition { get; set; }

        /// <summary>
        /// <para>超过 meeting_duration小时需要审批</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("meeting_duration")]
        public float? MeetingDuration { get; set; }

        /// <summary>
        /// <para>审批人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("approvers")]
        public SubscribeUserEvent[]? Approvers { get; set; }
    }

    /// <summary>
    /// <para>预定时间设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("time_config")]
    public TimeConfigSuffix? TimeConfig { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record TimeConfigSuffix
    {
        /// <summary>
        /// <para>预定时间开关：0 代表关闭，1 代表开启</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 取值范围：`0` ～ `1`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("time_switch")]
        public int? TimeSwitch { get; set; }

        /// <summary>
        /// <para>最早可提前</para>
        /// <para>days_in_advance 预定会议室（单位：天，取值范围[1-730]）</para>
        /// <para>说明</para>
        /// <para>：不填写时，默认更新为 365</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("days_in_advance")]
        public int? DaysInAdvance { get; set; }

        /// <summary>
        /// <para>开放当天可于</para>
        /// <para>opening_hour 开始预定（单位：秒，取值范围[0,86400]）</para>
        /// <para>说明</para>
        /// <para>：</para>
        /// <para>1. 不填写时默认更新为</para>
        /// <para>28800</para>
        /// <para>2. 如果填写的值不是 60</para>
        /// <para>的倍数，则自动会更新为离其最近的 60 整数倍的值。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("opening_hour")]
        public string? OpeningHour { get; set; }

        /// <summary>
        /// <para>每日可预定时间范围的开始时间（单位：秒，取值范围[0,86400]）</para>
        /// <para>说明</para>
        /// <para>：</para>
        /// <para>1. 不填写时，默认更新为 0 ，此时填写的 end_time 不得小于 30。</para>
        /// <para>2. 当 start_time 与</para>
        /// <para>end_time 均填写时</para>
        /// <para>end_time 至少超过</para>
        /// <para>start_time 30 。</para>
        /// <para>3. 如果填写的值不是 60 的倍数，则自动会更新为离其最近的 60 整数倍的值。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>每日可预定时间范围结束时间（单位：秒，取值范围[0,86400]）</para>
        /// <para>说明</para>
        /// <para>：</para>
        /// <para>1. 不填写时，默认更新为 86400 ，此时填写的</para>
        /// <para>start_time 不得大于等于 86370 。</para>
        /// <para>2. 当 start_time 与</para>
        /// <para>end_time 均填写时</para>
        /// <para>end_time 至少要超过</para>
        /// <para>start_time 30。</para>
        /// <para>3. 如果填写的值不是 60 的倍数，则自动会更新为离其最近的 60 整数倍的值。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>单次会议室可预定时长上限（单位：小时，取值范围[1,99]）</para>
        /// <para>说明</para>
        /// <para>：不填写时默认更新为 2</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("max_duration")]
        public int? MaxDuration { get; set; }
    }

    /// <summary>
    /// <para>预定范围设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reserve_scope_config")]
    public ReserveScopeConfigEvent? ReserveScopeConfig { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record ReserveScopeConfigEvent
    {
        /// <summary>
        /// <para>可预定成员范围，0部分成员，1全部成员</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 取值范围：`0` ～ `1`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("allow_all_users")]
        public int? AllowAllUsers { get; set; }

        /// <summary>
        /// <para>可预定成员列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("allow_users")]
        public SubscribeUserEvent[]? AllowUsers { get; set; }


        /// <summary>
        /// <para>可预定部门列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("allow_depts")]
        public SubscribeDepartment[]? AllowDepts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record SubscribeDepartment
        {
            /// <summary>
            /// <para>预定管理部门ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public record SubscribeUserEvent
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public UserIdSuffix? UserId { get; set; }
    }
}
