// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-11-08
// ************************************************************************
// <copyright file="GetCorehrV1LeavesLeaveRequestHistoryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询员工请假记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 批量查询员工请假记录 响应体
/// <para>批量获取员工的请假记录数据。对应页面为假勤管理-休假管理-[请假记录](https://example.feishu.cn/people/workforce-management/manage/leave/leave_admin/leave_request)</para>
/// <para>接口ID：7126729166647902211</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/leave/leave_request_history</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fleave_request_history</para>
/// </summary>
public record GetCorehrV1LeavesLeaveRequestHistoryResponseDto : IPageableResponse<GetCorehrV1LeavesLeaveRequestHistoryResponseDto.LeaveRequest>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public LeaveRequest[]? Items => LeaveRequestLists;

    /// <summary>
    /// <para>请假记录信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("leave_request_list")]
    public LeaveRequest[]? LeaveRequestLists { get; set; }

    /// <summary>
    /// <para>请假记录信息列表</para>
    /// </summary>
    public record LeaveRequest
    {
        /// <summary>
        /// <para>请假记录ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：4718803945687580505</para>
        /// </summary>
        [JsonPropertyName("leave_request_id")]
        public string LeaveRequestId { get; set; } = string.Empty;

        /// <summary>
        /// <para>员工ID，ID 类型与 user_id_type 一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：4718803945687580505</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string EmploymentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>员工姓名</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("employment_name")]
        public I18n[] EmploymentNames { get; set; } = [];

        /// <summary>
        /// <para>员工姓名</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>名称信息的语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>假期类型ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("leave_type_id")]
        public string LeaveTypeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期类型名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("leave_type_name")]
        public I18n[] LeaveTypeNames { get; set; } = [];

        /// <summary>
        /// <para>假期开始时间，格式可能为：</para>
        /// <para>- 字符串日期：如 "2022-09-09"</para>
        /// <para>- 字符串日期加 morning/afternoon：如 "2022-09-09 morning""</para>
        /// <para>- 小时假如需返回精准到小时的时间格式，请联系[技术支持](https://applink.feishu.cn/TLJpeNdW) 开通</para>
        /// <para>必填：是</para>
        /// <para>示例值：2022-07-06</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期结束时间，格式可能为：</para>
        /// <para>- 字符串日期：如 "2022-09-09"</para>
        /// <para>- 字符串日期加 morning/afternoon：如 "2022-09-09 morning""</para>
        /// <para>- 小时假如需返回精准到小时的时间格式，请联系[技术支持](https://applink.feishu.cn/TLJpeNdW) 开通</para>
        /// <para>必填：是</para>
        /// <para>示例值：2023-01-05</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期时长</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("leave_duration")]
        public string LeaveDuration { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期时长单位</para>
        /// <para>可选值有：</para>
        /// <para>- 1: 天</para>
        /// <para>- 2: 小时</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("leave_duration_unit")]
        public int LeaveDurationUnit { get; set; }

        /// <summary>
        /// <para>请假记录的状态</para>
        /// <para>可选值有：</para>
        /// <para>- 1：已通过</para>
        /// <para>- 2：审批中</para>
        /// <para>- 3：审批中（更正）</para>
        /// <para>- 4：审批中（取消休假）</para>
        /// <para>- 5：审批中（返岗）</para>
        /// <para>- 6：已返岗</para>
        /// <para>- 7：已拒绝</para>
        /// <para>- 8：已取消</para>
        /// <para>- 9：已撤回</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("leave_request_status")]
        public int LeaveRequestStatus { get; set; }

        /// <summary>
        /// <para>数据来源</para>
        /// <para>可选值有：</para>
        /// <para>- "manual"：手动创建</para>
        /// <para>- "system"：系统创建"</para>
        /// <para>必填：是</para>
        /// <para>示例值：manual</para>
        /// </summary>
        [JsonPropertyName("grant_source")]
        public string GrantSource { get; set; } = string.Empty;

        /// <summary>
        /// <para>返岗时间，格式为秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1662134400</para>
        /// </summary>
        [JsonPropertyName("return_time")]
        public string ReturnTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>发起时间，格式为秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1659080476</para>
        /// </summary>
        [JsonPropertyName("submitted_at")]
        public string SubmittedAt { get; set; } = string.Empty;

        /// <summary>
        /// <para>发起人，ID 类型与 user_id_type 一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：7109664941775241244</para>
        /// </summary>
        [JsonPropertyName("submitted_by")]
        public string SubmittedBy { get; set; } = string.Empty;

        /// <summary>
        /// <para>备注</para>
        /// <para>必填：是</para>
        /// <para>示例值：备注</para>
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批通过日期，格式为yyyy-MM-dd</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-09-09</para>
        /// </summary>
        [JsonPropertyName("approval_date")]
        public string? ApprovalDate { get; set; }

        /// <summary>
        /// <para>（暂未开放）是否带薪</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_deducted")]
        public bool? IsDeducted { get; set; }

        /// <summary>
        /// <para>请假详情</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("details")]
        public LeaveRequestDetail[]? Details { get; set; }

        /// <summary>
        /// <para>请假详情</para>
        /// </summary>
        public record LeaveRequestDetail
        {
            /// <summary>
            /// <para>请假记录id</para>
            /// <para>必填：是</para>
            /// <para>示例值：4718803945687580505</para>
            /// </summary>
            [JsonPropertyName("leave_request_id")]
            public string LeaveRequestId { get; set; } = string.Empty;

            /// <summary>
            /// <para>假期发生日期</para>
            /// <para>必填：是</para>
            /// <para>示例值：2022-07-07</para>
            /// </summary>
            [JsonPropertyName("leave_date")]
            public string LeaveDate { get; set; } = string.Empty;

            /// <summary>
            /// <para>假期时长</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("leave_duration")]
            public string LeaveDuration { get; set; } = string.Empty;

            /// <summary>
            /// <para>假期时长单位，1：天，2：小时</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("leave_duration_unit")]
            public int LeaveDurationUnit { get; set; }

            /// <summary>
            /// <para>是否影响算薪，1：不参与算薪计算, 非对应的日期类型或者无对应的假期计划，2：影响算薪，3：不影响算薪</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("paid_type")]
            public int PaidType { get; set; }
        }

        /// <summary>
        /// <para>（暂未开放）假期类型枚举</para>
        /// <para>必填：否</para>
        /// <para>示例值：Annual Leave</para>
        /// </summary>
        [JsonPropertyName("leave_type_code")]
        public string? LeaveTypeCode { get; set; }

        /// <summary>
        /// <para>（暂未开放）实际结束日期，格式为yyyy-MM-dd</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-08-02</para>
        /// </summary>
        [JsonPropertyName("actual_end_date")]
        public string? ActualEndDate { get; set; }

        /// <summary>
        /// <para>（暂未开放）预估结束日期，格式为yyyy-MM-dd</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-08-02</para>
        /// </summary>
        [JsonPropertyName("estimated_end_date")]
        public string? EstimatedEndDate { get; set; }

        /// <summary>
        /// <para>时区</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Shanghai</para>
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }

        /// <summary>
        /// <para>（暂未开放）请假记录数据来源</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("data_source")]
        public int? DataSource { get; set; }

        /// <summary>
        /// <para>请假申请流程ID。注意：导入的请假不会返回leave_process_id。可用于[获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leave_process_id")]
        public string[]? LeaveProcessId { get; set; }

        /// <summary>
        /// <para>请假更正流程ID。可用于[获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leave_correct_process_id")]
        public string[]? LeaveCorrectProcessId { get; set; }

        /// <summary>
        /// <para>请假取消流程ID。可用于[获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leave_cancel_process_id")]
        public string[]? LeaveCancelProcessId { get; set; }

        /// <summary>
        /// <para>请假返岗流程ID。可用于[获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leave_return_process_id")]
        public string[]? LeaveReturnProcessId { get; set; }

        /// <summary>
        /// <para>WorkDay专用 扣薪类型, 1不参与算薪 2影响算薪 3不影响算薪</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("wd_paid_type")]
        public int? WdPaidType { get; set; }

        /// <summary>
        /// <para>请假更正流程信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leave_correct_process_info")]
        public LeaveProcessInfo[]? LeaveCorrectProcessInfos { get; set; }

        /// <summary>
        /// <para>请假更正流程信息</para>
        /// </summary>
        public record LeaveProcessInfo
        {
            /// <summary>
            /// <para>流程id。注意：导入的请假不会返回leave_process_id。详情可查看[获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get)</para>
            /// <para>必填：是</para>
            /// <para>示例值：4718803945687580505</para>
            /// </summary>
            [JsonPropertyName("process_id")]
            public string ProcessId { get; set; } = string.Empty;

            /// <summary>
            /// <para>流程状态</para>
            /// <para>可选值有</para>
            /// <para>- "inProgress"：审批中</para>
            /// <para>- "rejected"：已拒绝</para>
            /// <para>- "withdrawn"：已撤回</para>
            /// <para>- "passed"：已通过</para>
            /// <para>- "revoked"：已撤销</para>
            /// <para>- "toStart"：待发起</para>
            /// <para>必填：是</para>
            /// <para>示例值：passed</para>
            /// </summary>
            [JsonPropertyName("process_status")]
            public string ProcessStatus { get; set; } = string.Empty;

            /// <summary>
            /// <para>流程发起时间</para>
            /// <para>必填：是</para>
            /// <para>示例值：2024-01-01 00:00:00</para>
            /// </summary>
            [JsonPropertyName("process_apply_time")]
            public string ProcessApplyTime { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：[1712932008000,\"7356863257632491046\"]</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
