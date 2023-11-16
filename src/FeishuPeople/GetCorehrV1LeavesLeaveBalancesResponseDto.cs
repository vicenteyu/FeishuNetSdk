namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 批量查询员工假期余额 响应体
/// <para>批量获取员工各个假期的余额数据。</para>
/// <para>接口ID：7126729166647869443</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/leave/leave_balances</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fleave_balances</para>
/// </summary>
public record GetCorehrV1LeavesLeaveBalancesResponseDto
{
    /// <summary>
    /// <para>员工假期余额信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_leave_balance_list")]
    public EmploymentLeaveBalance[]? EmploymentLeaveBalanceLists { get; set; }

    /// <summary>
    /// <para>员工假期余额信息列表</para>
    /// </summary>
    public record EmploymentLeaveBalance
    {
        /// <summary>
        /// <para>雇佣信息ID</para>
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
        /// <para>截止日期，即查询截止到某天余额数据的日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2022-07-29</para>
        /// </summary>
        [JsonPropertyName("as_of_date")]
        public string AsOfDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>假期余额列表</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("leave_balance_list")]
        public LeaveBalance[] LeaveBalanceLists { get; set; } = Array.Empty<LeaveBalance>();

        /// <summary>
        /// <para>假期余额列表</para>
        /// </summary>
        public record LeaveBalance
        {
            /// <summary>
            /// <para>假期类型ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：4718803945687580505</para>
            /// </summary>
            [JsonPropertyName("leave_type_id")]
            public string LeaveTypeId { get; set; } = string.Empty;

            /// <summary>
            /// <para>假期类型名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("leave_type_name")]
            public I18n[] LeaveTypeNames { get; set; } = Array.Empty<I18n>();

            /// <summary>
            /// <para>假期类型名称</para>
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
            /// <para>结转的历史周期授予时长</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("historical_cycles_left")]
            public string? HistoricalCyclesLeft { get; set; }

            /// <summary>
            /// <para>本周期授予时长</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("this_cycle_total")]
            public string? ThisCycleTotal { get; set; }

            /// <summary>
            /// <para>本周期已休时长</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("this_cycle_taken")]
            public string ThisCycleTaken { get; set; } = string.Empty;

            /// <summary>
            /// <para>假期余额</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("leave_balance")]
            public string LeaveBalanceSuffix { get; set; } = string.Empty;

            /// <summary>
            /// <para>假期时长单位</para>
            /// <para>可选值有：</para>
            /// <para>- 1: 天</para>
            /// <para>- 2: 小时</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("leave_duration_unit")]
            public int LeaveDurationUnit { get; set; }
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
    /// <para>示例值：eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
