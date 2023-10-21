using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 批量查询员工请假记录 响应体
/// <para>批量获取员工的请假记录数据。</para>
/// <para>接口ID：7126729166647902211</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/leave/leave_request_history</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fleave_request_history</para>
/// </summary>
public record GetCorehrV1LeavesLeaveRequestHistoryResponseDto
{
    /// <summary>
    /// <para>请假记录信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("leave_request_list")]
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
        [JsonProperty("leave_request_id")]
        public string LeaveRequestId { get; set; } = string.Empty;

        /// <summary>
        /// <para>雇佣信息ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：4718803945687580505</para>
        /// </summary>
        [JsonProperty("employment_id")]
        public string EmploymentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>员工姓名</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("employment_name")]
        public I18n[] EmploymentNames { get; set; } = Array.Empty<I18n>();

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
            [JsonProperty("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonProperty("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>假期类型ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonProperty("leave_type_id")]
        public string LeaveTypeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期类型名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("leave_type_name")]
        public I18n[] LeaveTypeNames { get; set; } = Array.Empty<I18n>();

        /// <summary>
        /// <para>假期开始时间，格式可能为：</para>
        /// <para>- 字符串日期：如 "2022-09-09"</para>
        /// <para>- 字符串日期加 morning/afternoon：如 "2022-09-09 morning""</para>
        /// <para>必填：是</para>
        /// <para>示例值：2022-07-06morning</para>
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期结束时间，格式可能为：</para>
        /// <para>- 字符串日期：如 "2022-09-09"</para>
        /// <para>- 字符串日期加 morning/afternoon：如 "2022-09-09 morning""</para>
        /// <para>必填：是</para>
        /// <para>示例值：2023-01-05</para>
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期时长</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonProperty("leave_duration")]
        public string LeaveDuration { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期时长单位</para>
        /// <para>可选值有：</para>
        /// <para>- 1: 天</para>
        /// <para>- 2: 小时</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonProperty("leave_duration_unit")]
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
        [JsonProperty("leave_request_status")]
        public int LeaveRequestStatus { get; set; }

        /// <summary>
        /// <para>数据来源</para>
        /// <para>可选值有：</para>
        /// <para>- "manual"：手动创建</para>
        /// <para>- "system"：系统创建"</para>
        /// <para>必填：是</para>
        /// <para>示例值：manual</para>
        /// </summary>
        [JsonProperty("grant_source")]
        public string GrantSource { get; set; } = string.Empty;

        /// <summary>
        /// <para>返岗时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1662134400</para>
        /// </summary>
        [JsonProperty("return_time")]
        public string ReturnTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>发起时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1659080476</para>
        /// </summary>
        [JsonProperty("submitted_at")]
        public string SubmittedAt { get; set; } = string.Empty;

        /// <summary>
        /// <para>发起人</para>
        /// <para>必填：是</para>
        /// <para>示例值：7109664941775241244</para>
        /// </summary>
        [JsonProperty("submitted_by")]
        public string SubmittedBy { get; set; } = string.Empty;

        /// <summary>
        /// <para>备注</para>
        /// <para>必填：是</para>
        /// <para>示例值：备注</para>
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }
}
